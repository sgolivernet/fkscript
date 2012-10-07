lexer grammar FKVM;
options {
  language=CSharp;

}
@members {
	public int numErrors = 0;

	public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
	{
		numErrors++;
		return base.GetErrorMessage(e,tokenNames);
	}
}

T24 : 'api' ;
T25 : '(' ;
T26 : ')' ;
T27 : ';' ;
T28 : 'program' ;
T29 : '{' ;
T30 : '}' ;
T31 : ',' ;
T32 : '=' ;
T33 : 'if' ;
T34 : 'else' ;
T35 : 'while' ;
T36 : 'return' ;
T37 : 'int' ;
T38 : 'float' ;
T39 : 'string' ;
T40 : 'bool' ;
T41 : 'void' ;
T42 : '||' ;
T43 : '&&' ;
T44 : '==' ;
T45 : '!=' ;
T46 : '>' ;
T47 : '<' ;
T48 : '>=' ;
T49 : '<=' ;
T50 : '+' ;
T51 : '-' ;
T52 : '*' ;
T53 : '/' ;
T54 : '!' ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 152
fragment LETRA : 'a'..'z'|'A'..'Z' ;
// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 153
fragment DIGITO : '0'..'9' ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 155
LIT_ENTERO : DIGITO+ ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 157
LIT_REAL : LIT_ENTERO '.' LIT_ENTERO ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 159
LIT_CADENA : '"' (~('"'|'\n'|'\r'|'\t'))* '"' ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 161
LIT_LOGICO : 'true'|'false' ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 163
IDENT : (LETRA|'_')(LETRA|DIGITO|'_')* ;

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 165
COMENTARIO : '//' (~('\n'|'\r'))* '\r'? '\n' {$channel=HIDDEN;};

// $ANTLR src "D:\Proyectos\ProyectosVS\FKVM\FKVM\src\antlr\FKVM.g" 167
WS : (' '|'\r'|'\n'|'\t')+ {$channel=HIDDEN;} ;
