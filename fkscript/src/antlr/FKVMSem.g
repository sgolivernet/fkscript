tree grammar FKVMSem;

options {
	tokenVocab=FKVM;
	ASTLabelType=FkvmAST;
	language=CSharp;
}

@header {
using System.Collections.Generic;
}

@members {
public Dictionary<string,Symbol> symtable;
public int numErrors = 0;

public FKVM.FKVMCompiler.ReportarError reportarError;

public bool comprobarTipoAsig(string t1, string t2)
{
	bool res = false;
	
	if(t1.Equals(t2) ||
      (t1.Equals("int") && t2.Equals("float")) ||
      (t1.Equals("float") && t2.Equals("int")) )
    {
    	res = true; 
    }
	
	return res;
}

public bool comprobarTipoExpComp(string t1, string t2)
{
	bool res = false;
	
	if(t1.Equals(t2) ||
      (t1.Equals("int") && t2.Equals("float")) ||
      (t1.Equals("float") && t2.Equals("int")) )
    {
    	res = true; 
    }
	
	return res;
}

public bool comprobarTipoExpArit(string t1, string t2)
{
	bool res = false;
	
	if((t1.Equals("int") && t2.Equals("int"))     ||
       (t1.Equals("float") && t2.Equals("float")) ||
	   (t1.Equals("int") && t2.Equals("float"))   ||
       (t1.Equals("float") && t2.Equals("int"))   ||
       (t1.Equals("string") && t2.Equals("string")))
    {
    	res = true; 
    }
	
	return res;
}

public void registrarError(int linea, string msg)
{
	numErrors++;
	
	if(reportarError != null)
		reportarError("Line " + linea + ": " + msg);
	else
		Console.WriteLine("Line " + linea + ": " + msg);
}
}

programa[Dictionary<string,Symbol> symtable]
@init {
this.symtable = symtable;
} 
: ^(PROGRAMA declaraciones_api principal) ;

declaraciones_api : ^(LISTADECLARACIONESAPI declaracion_api*) ;

declaracion_api : ^(DECLARACIONAPI tipo IDENT) ;

principal : ^('program' tipo IDENT lista_instrucciones);

lista_instrucciones : ^(LISTAINSTRUCCIONES instruccion*);

instruccion : inst_decl 
	    | inst_asig
	    | inst_if
	    | inst_while
	    | inst_return
	    | inst_expr
	    ;
			
inst_expr : expresion ;
			
inst_decl : ^(DECLARACION tipo IDENT) ;

inst_asig 
@init {
FkvmAST root = (FkvmAST)input.LT(1);
}
: ^(ASIGNACION IDENT e1=expresion) {
	root.expType = $e1.type; 
	
	if(symtable.ContainsKey($IDENT.text))
	{
		$IDENT.symbol = (Symbol)symtable[$IDENT.text];
		
		if(!comprobarTipoAsig(root.expType,$IDENT.symbol.type)) 
		{
			registrarError(root.Line, "Incorrect type in assignment.");
		}
	}
	else
	{
		registrarError(root.Line, "Identifier '" + $IDENT.text + "' has not been declared.");
	}	
};

inst_if : ^(ins='if' e1=expresion lista_instrucciones lista_instrucciones) {
		
	if(!$e1.type.Equals("bool"))
        {
        	registrarError($ins.Line, "Incorrect type in IF instruction.");
        }
};

inst_while : ^(ins='while' e1=expresion lista_instrucciones) {
	
	if(!$e1.type.Equals("bool"))
        {
        	registrarError($ins.Line, "Incorrect type in WHILE instruction.");
        }
};

inst_return 
@init {
FkvmAST root = (FkvmAST)input.LT(1);
}
     : ^('return' e1=expresion) {root.expType = $e1.type;};

tipo : 'int'
     | 'float'
     | 'bool'
     | 'string'
     | 'void'
     ;

literal returns [String type] 
@init {
$type="";
FkvmAST root = (FkvmAST)input.LT(1);
}
@after {
root.expType = $type;
}
        : LIT_ENTERO {$type="int";}
        | LIT_REAL {$type="float";}
        | LIT_CADENA {$type="string";}
        | LIT_LOGICO {$type="bool";}
        ;
        
expresion returns [String type]
@init {
$type="";
FkvmAST root = (FkvmAST)input.LT(1);
}
@after {
root.expType = $type;
}
          : ^(opComparacion e1=expresion e2=expresion) {
          			$type= "bool";
          			root.expSecType = $e1.type;
          			
          			if(!comprobarTipoExpComp($e1.type, $e2.type))
          			{
          				registrarError(root.Line, "Incorrect types in expression.");
          			}
          	}
          | ^(opAritmetico e1=expresion e2=expresion) {
          			$type=$e1.type;
          			
          			if(!comprobarTipoExpArit($e1.type, $e2.type))
          			{
          			   	registrarError(root.Line, "Incorrect types in expression.");
          			}
          	}
          | ^(MENOSUNARIO e1=expresion) {
          			$type=$e1.type;
          			
          			if(!($e1.type.Equals("int") || $e1.type.Equals("float")))
          			{
          				registrarError(root.Line, "Incorrect types in expression.");
          			}
          	}
          | ^('!' e1=expresion) {
          			$type=$e1.type;
          			
          			if(!$e1.type.Equals("bool"))
          			{
          				registrarError(root.Line, "Incorrect types in expression.");
          			}
          	}
          | IDENT {
          		if(symtable.ContainsKey($IDENT.text))
          		{
          			root.symbol = (Symbol)symtable[$IDENT.text]; $type=root.symbol.type;
          		}
			    else
				{
					registrarError(root.Line, "Identifier '" + $IDENT.text + "' has not been declared.");
				}
          }
          | literal {$type=$literal.type;}
          | llamada {$type=$llamada.type;}
          ;
          
llamada returns [String type] 
@init {
$type="";
FkvmAST root = (FkvmAST)input.LT(1);
}
@after {
root.expType = $type;
}
: ^(LLAMADA IDENT lista_expr) {
		if(symtable.ContainsKey($IDENT.text))
        {
        	root.symbol = (Symbol)symtable[$IDENT.text]; $type=root.symbol.type;
        }
		else
		{
			registrarError(root.Line, "Api function '" + $IDENT.text + "' has not been declared.");
		}
} ;

lista_expr : ^(LISTAEXPRESIONES expresion*)
            ;

opAritmetico : '+'|'-'|'*'|'/' ;

opComparacion : '=='|'!='|'>='|'<='|'>'|'<' ;
