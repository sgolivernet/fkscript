tree grammar FKVMGen;

options {
	tokenVocab=FKVM;
	ASTLabelType=FkvmAST;
	output=template;
	language=CSharp;
}

@members {
	int nEtiqueta = 1;
	
	private string traducirTipo(String t)
	{
		string op = "";
	
		if(t.Equals("int"))
			op = "i";
		else if(t.Equals("float"))
			op = "f";
		else if(t.Equals("string"))
			op = "s";
		else if(t.Equals("bool"))
			op = "b";
		
		return op;
	}
	
	private string operadorComparacion(String t)
	{
		string op = "";
		
		if(t.Equals("int") || t.Equals("float"))
			op = "ncmp";
		else if(t.Equals("string"))
			op = "scmp";
		else if(t.Equals("bool"))
			op = "bcmp";
		
		return op;
	}
}

programa[int locales] : ^(PROGRAMA declaraciones_api principal[locales]) -> {$principal.st} ;

declaraciones_api : ^(LISTADECLARACIONESAPI declaracion_api*) ;

declaracion_api : ^(DECLARACIONAPI tipo IDENT) ;

principal[int locales] : ^('program' tipo IDENT li=lista_instrucciones) 
                         -> principal(nom={$IDENT.text}, loc={locales}, instr={$li.st});

lista_instrucciones : ^(LISTAINSTRUCCIONES (i+=instruccion)*) -> listainst(instr={$i});

instruccion : inst_decl -> {$inst_decl.st} 
	    | inst_asig -> {$inst_asig.st}
	    | inst_if -> {$inst_if.st}
	    | inst_while -> {$inst_while.st}
	    | inst_return -> {$inst_return.st}
	    | inst_expr -> {$inst_expr.st}
	    ;

inst_expr : expresion -> instexpr(exp={$expresion.st}) ;
			
inst_decl : ^(DECLARACION tipo IDENT) -> declaracion(tipo={$tipo.text}, id={$IDENT.text});

inst_asig 
@init {
string oper = "";
}
        : ^(ASIGNACION IDENT expresion) {oper = traducirTipo($ASIGNACION.expType)+"store";} 
           -> asignacion(op={oper}, nv={$IDENT.symbol.numvar}, val={$expresion.st});

inst_if : ^('if' expresion isi=lista_instrucciones ielse=lista_instrucciones) 
        -> instif(cond={$expresion.st},instsi={$isi.st},instelse={$ielse.st},et1={nEtiqueta++},et2={nEtiqueta++});

inst_while : ^('while' expresion li=lista_instrucciones) 
             -> instwhile(cond={$expresion.st},instrucciones={$li.st},et1={nEtiqueta++},et2={nEtiqueta++});

inst_return
@init {
string oper = "";
}
        : ^(r='return' expresion) {oper = traducirTipo($r.expType)+"ret";} -> return(op={oper}, v={$expresion.st});

tipo : 'int' -> {%{"int"}}
     | 'float' -> {%{"float"}}
     | 'string' -> {%{"string"}}
     | 'bool' -> {%{"bool"}}
     | 'void' -> {%{"void"}}
     ;

literal : LIT_ENTERO -> lit_entero(v={$LIT_ENTERO.text})
        | LIT_REAL -> lit_real(v={$LIT_REAL.text})
        | LIT_CADENA -> lit_cadena(v={$LIT_CADENA.text})
        | LIT_LOGICO -> lit_logico(v={$LIT_LOGICO.text})
        ;
        
expresion
@init {
string oper = "";
string operc = "";
}
          : ^(opc=opComparacion e1=expresion e2=expresion) {operc = operadorComparacion($opc.opSecType);}
             -> op_comparacion(opc={operc}, op={$opc.st}, e1={$e1.st}, e2={$e2.st}, et1={nEtiqueta++})
          | ^(opa=opAritmetico e1=expresion e2=expresion)  {oper = traducirTipo($opa.opType)+$opa.st.ToString();}
             -> op_aritmetico(op={oper}, e1={$e1.st}, e2={$e2.st})
          | ^(MENOSUNARIO e1=expresion) -> opmenosunario(e1={$e1.st})
          | ^('!' e1=expresion) -> opno(e1={$e1.st})
          | IDENT {oper = traducirTipo($IDENT.expType)+"load";} -> ident(op={oper}, nv={$IDENT.symbol.numvar})
          | literal -> {$literal.st}
          | llamada -> {$llamada.st}
          ;
          
llamada : ^(LLAMADA IDENT le=lista_expr) -> llamada(id={$IDENT.text}, lp={$le.st}) ;

lista_expr : ^(LISTAEXPRESIONES exp+=expresion*) -> listaparams(lp={$exp}) ;

opAritmetico returns [string opType]
          : op='+' -> {%{"add"}; $opType=$op.expType;}
          | op='-' -> {%{"sub"}; $opType=$op.expType;}
          | op='*' -> {%{"mul"}; $opType=$op.expType;}
          | op='/' -> {%{"div"}; $opType=$op.expType;}
          ;

opComparacion returns [string opSecType]
          : op='==' -> {%{"ifeq"}; $opSecType=$op.expSecType;}
          | op='!=' -> {%{"ifne"}; $opSecType=$op.expSecType;}
          | op='>=' -> {%{"ifge"}; $opSecType=$op.expSecType;}
          | op='<=' -> {%{"ifle"}; $opSecType=$op.expSecType;}
          | op='>' -> {%{"ifgt"}; $opSecType=$op.expSecType;}
          | op='<' -> {%{"iflt"}; $opSecType=$op.expSecType;}
          ;












