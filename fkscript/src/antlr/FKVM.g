grammar FKVM;

options {
	output=AST;
	ASTLabelType=FkvmAST;
	language=CSharp;
}

tokens {
    PROGRAMA;
	DECLARACION;
	DECLARACIONPARAM;
	LISTADECLARACIONESAPI;
	DECLARACIONAPI;
	ASIGNACION;
	MENOSUNARIO;
	LISTAINSTRUCCIONES;
	LLAMADA;
	LISTAEXPRESIONES;
	LISTAPARAMETROS;
}

@header {
using System.Collections.Generic;
}

@lexer::members {
	public int numErrors = 0;

	public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
	{
		numErrors++;
		return base.GetErrorMessage(e,tokenNames);
	}
}

@members {
	public Dictionary<string,Symbol> symtable = new Dictionary<string,Symbol>();
	public int numVars = 0;
	public int numErrors = 0;
	
	public FKVM.FKVMCompiler.ReportarError reportarError;

	public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
	{
		numErrors++;
		
		string msg = base.GetErrorMessage(e,tokenNames);
		
		if(reportarError != null)
			reportarError("Line " + e.Line + ":" + e.CharPositionInLine + " " + msg);
		
		return msg;
	}
}

//*************************************************************
// PARSER
//*************************************************************

programa : declaraciones_api principal -> ^(PROGRAMA declaraciones_api principal) ;

declaraciones_api : (lista+=declaracion_api)* -> ^(LISTADECLARACIONESAPI $lista*) ;

declaracion_api : 'api' tipo IDENT '(' lista_decl ')' ';' {
     if(!symtable.ContainsKey($IDENT.text))
     {
           symtable.Add($IDENT.text, new Symbol($tipo.text, -1));
     }
     } -> ^(DECLARACIONAPI tipo IDENT) ;

principal : 'program'^ tipo IDENT '{'! lista_instrucciones '}'! ;

lista_instrucciones : (lista+=instruccion)* -> ^(LISTAINSTRUCCIONES $lista*);

instruccion : inst_decl
	    | inst_asig 
	    | inst_if 
	    | inst_while 
	    | inst_return 
	    | inst_expr;
			
inst_expr : expresion ';'! ;

inst_decl : tipo IDENT ';' {
     if(!symtable.ContainsKey($IDENT.text))
     {
           symtable.Add($IDENT.text, new Symbol($tipo.text, numVars++));
     }
     } -> ^(DECLARACION tipo IDENT);
     
lista_decl : ld+=decl (',' ld+=decl)* -> ^(LISTAPARAMETROS $ld*)
           | -> ^(LISTAPARAMETROS) //Sin parámetros
           ;

decl : tipo IDENT -> ^(DECLARACIONPARAM tipo IDENT) ;

inst_asig : IDENT '=' expresion ';' -> ^(ASIGNACION IDENT expresion);

inst_if	: 'if'^ '('! expresion ')'! '{'! lista_instrucciones '}'! else_otras ;

else_otras : 'else'! '{'! lista_instrucciones '}'! 
           | -> ^(LISTAINSTRUCCIONES);

inst_while : 'while'^ '('! expresion ')'! '{'! lista_instrucciones '}'! ;

inst_return : 'return'^ expresion ';'! ;

tipo : 'int'|'float'|'string'|'bool'|'void' ;

literal : LIT_ENTERO
        | LIT_REAL
        | LIT_CADENA
        | LIT_LOGICO ;

expresion : expOr ;

expOr : expAnd ('||'^ expAnd)* ;

expAnd : expComp ('&&'^ expComp)* ;

expComp : expMasMenos (
		('=='^|'!='^|'>'^|'<'^|'>='^|'<='^) expMasMenos)* ;
		
expMasMenos : expMultDiv (
		('+'^|'-'^) expMultDiv)* ;
		
expMultDiv : expMenos (
		('*'^|'/'^) expMenos)* ;

expMenos : '-' expNo -> ^(MENOSUNARIO expNo) 
         | '+'? expNo -> expNo;

expNo : ('!'^)? acceso ;

acceso : IDENT
	   | literal
	   | llamada
	   | '('! expresion ')'! ;

llamada : IDENT '(' lista_expr ')' -> ^(LLAMADA IDENT lista_expr);

lista_expr : lista+=expresion (',' lista+=expresion)* -> ^(LISTAEXPRESIONES $lista*)
            | -> ^(LISTAEXPRESIONES) //Sin parámetros 
            ;


//*************************************************************
// LEXER
//*************************************************************

fragment LETRA : 'a'..'z'|'A'..'Z' ;
fragment DIGITO : '0'..'9' ;

LIT_ENTERO : DIGITO+ ;

LIT_REAL : LIT_ENTERO '.' LIT_ENTERO ;

LIT_CADENA : '"' (~('"'|'\n'|'\r'|'\t'))* '"' ;

LIT_LOGICO : 'true'|'false' ;

IDENT : (LETRA|'_')(LETRA|DIGITO|'_')* ;

COMENTARIO : '//' (~('\n'|'\r'))* '\r'? '\n' {$channel=HIDDEN;};

WS : (' '|'\r'|'\n'|'\t')+ {$channel=HIDDEN;} ;
