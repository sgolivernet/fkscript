// $ANTLR 3.0.1 D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g 2007-09-09 13:38:56

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class FKVMLexer : Lexer 
{
    public const int DIGITO = 21;
    public const int ASIGNACION = 9;
    public const int LISTADECLARACIONESAPI = 7;
    public const int T29 = 29;
    public const int T28 = 28;
    public const int T27 = 27;
    public const int LLAMADA = 12;
    public const int T26 = 26;
    public const int T25 = 25;
    public const int EOF = -1;
    public const int T24 = 24;
    public const int LISTAPARAMETROS = 14;
    public const int DECLARACIONPARAM = 6;
    public const int MENOSUNARIO = 10;
    public const int COMENTARIO = 22;
    public const int DECLARACION = 5;
    public const int IDENT = 15;
    public const int LIT_REAL = 17;
    public const int T38 = 38;
    public const int T37 = 37;
    public const int T39 = 39;
    public const int T34 = 34;
    public const int LIT_LOGICO = 19;
    public const int T33 = 33;
    public const int T36 = 36;
    public const int T35 = 35;
    public const int T30 = 30;
    public const int T32 = 32;
    public const int T31 = 31;
    public const int DECLARACIONAPI = 8;
    public const int T49 = 49;
    public const int T48 = 48;
    public const int LIT_ENTERO = 16;
    public const int LISTAINSTRUCCIONES = 11;
    public const int T43 = 43;
    public const int Tokens = 55;
    public const int LISTAEXPRESIONES = 13;
    public const int T42 = 42;
    public const int T41 = 41;
    public const int T40 = 40;
    public const int T47 = 47;
    public const int T46 = 46;
    public const int T45 = 45;
    public const int T44 = 44;
    public const int LIT_CADENA = 18;
    public const int WS = 23;
    public const int T50 = 50;
    public const int PROGRAMA = 4;
    public const int T52 = 52;
    public const int T51 = 51;
    public const int LETRA = 20;
    public const int T54 = 54;
    public const int T53 = 53;
    
    	public int numErrors = 0;
    
    	public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
    	{
    		numErrors++;
    		return base.GetErrorMessage(e,tokenNames);
    	}


    public FKVMLexer() 
    {
		InitializeCyclicDFAs();
    }
    public FKVMLexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g";} 
    }

    // $ANTLR start T24 
    public void mT24() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T24;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:16:5: ( 'api' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:16:7: 'api'
            {
            	Match("api"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T24

    // $ANTLR start T25 
    public void mT25() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T25;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:17:5: ( '(' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:17:7: '('
            {
            	Match('('); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T25

    // $ANTLR start T26 
    public void mT26() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T26;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:18:5: ( ')' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:18:7: ')'
            {
            	Match(')'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T26

    // $ANTLR start T27 
    public void mT27() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T27;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:19:5: ( ';' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:19:7: ';'
            {
            	Match(';'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T27

    // $ANTLR start T28 
    public void mT28() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T28;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:20:5: ( 'program' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:20:7: 'program'
            {
            	Match("program"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T28

    // $ANTLR start T29 
    public void mT29() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T29;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:21:5: ( '{' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:21:7: '{'
            {
            	Match('{'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T29

    // $ANTLR start T30 
    public void mT30() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T30;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:22:5: ( '}' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:22:7: '}'
            {
            	Match('}'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T30

    // $ANTLR start T31 
    public void mT31() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T31;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:23:5: ( ',' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:23:7: ','
            {
            	Match(','); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T31

    // $ANTLR start T32 
    public void mT32() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T32;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:24:5: ( '=' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:24:7: '='
            {
            	Match('='); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T32

    // $ANTLR start T33 
    public void mT33() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T33;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:25:5: ( 'if' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:25:7: 'if'
            {
            	Match("if"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T33

    // $ANTLR start T34 
    public void mT34() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T34;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:26:5: ( 'else' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:26:7: 'else'
            {
            	Match("else"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T34

    // $ANTLR start T35 
    public void mT35() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T35;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:27:5: ( 'while' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:27:7: 'while'
            {
            	Match("while"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T35

    // $ANTLR start T36 
    public void mT36() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T36;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:28:5: ( 'return' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:28:7: 'return'
            {
            	Match("return"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T36

    // $ANTLR start T37 
    public void mT37() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T37;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:29:5: ( 'int' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:29:7: 'int'
            {
            	Match("int"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T37

    // $ANTLR start T38 
    public void mT38() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T38;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:30:5: ( 'float' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:30:7: 'float'
            {
            	Match("float"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T38

    // $ANTLR start T39 
    public void mT39() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T39;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:31:5: ( 'string' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:31:7: 'string'
            {
            	Match("string"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T39

    // $ANTLR start T40 
    public void mT40() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T40;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:32:5: ( 'bool' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:32:7: 'bool'
            {
            	Match("bool"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T40

    // $ANTLR start T41 
    public void mT41() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T41;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:33:5: ( 'void' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:33:7: 'void'
            {
            	Match("void"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T41

    // $ANTLR start T42 
    public void mT42() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T42;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:34:5: ( '||' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:34:7: '||'
            {
            	Match("||"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T42

    // $ANTLR start T43 
    public void mT43() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T43;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:35:5: ( '&&' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:35:7: '&&'
            {
            	Match("&&"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T43

    // $ANTLR start T44 
    public void mT44() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T44;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:36:5: ( '==' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:36:7: '=='
            {
            	Match("=="); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T44

    // $ANTLR start T45 
    public void mT45() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T45;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:37:5: ( '!=' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:37:7: '!='
            {
            	Match("!="); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T45

    // $ANTLR start T46 
    public void mT46() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T46;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:38:5: ( '>' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:38:7: '>'
            {
            	Match('>'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T46

    // $ANTLR start T47 
    public void mT47() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T47;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:39:5: ( '<' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:39:7: '<'
            {
            	Match('<'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T47

    // $ANTLR start T48 
    public void mT48() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T48;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:40:5: ( '>=' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:40:7: '>='
            {
            	Match(">="); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T48

    // $ANTLR start T49 
    public void mT49() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T49;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:41:5: ( '<=' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:41:7: '<='
            {
            	Match("<="); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T49

    // $ANTLR start T50 
    public void mT50() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T50;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:42:5: ( '+' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:42:7: '+'
            {
            	Match('+'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T50

    // $ANTLR start T51 
    public void mT51() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T51;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:43:5: ( '-' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:43:7: '-'
            {
            	Match('-'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T51

    // $ANTLR start T52 
    public void mT52() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T52;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:44:5: ( '*' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:44:7: '*'
            {
            	Match('*'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T52

    // $ANTLR start T53 
    public void mT53() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T53;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:45:5: ( '/' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:45:7: '/'
            {
            	Match('/'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T53

    // $ANTLR start T54 
    public void mT54() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T54;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:46:5: ( '!' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:46:7: '!'
            {
            	Match('!'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T54

    // $ANTLR start LETRA 
    public void mLETRA() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:152:16: ( 'a' .. 'z' | 'A' .. 'Z' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end LETRA

    // $ANTLR start DIGITO 
    public void mDIGITO() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:153:17: ( '0' .. '9' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:153:19: '0' .. '9'
            {
            	MatchRange('0','9'); 
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end DIGITO

    // $ANTLR start LIT_ENTERO 
    public void mLIT_ENTERO() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LIT_ENTERO;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:155:12: ( ( DIGITO )+ )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:155:14: ( DIGITO )+
            {
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:155:14: ( DIGITO )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:155:14: DIGITO
            			    {
            			    	mDIGITO(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LIT_ENTERO

    // $ANTLR start LIT_REAL 
    public void mLIT_REAL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LIT_REAL;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:157:10: ( LIT_ENTERO '.' LIT_ENTERO )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:157:12: LIT_ENTERO '.' LIT_ENTERO
            {
            	mLIT_ENTERO(); 
            	Match('.'); 
            	mLIT_ENTERO(); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LIT_REAL

    // $ANTLR start LIT_CADENA 
    public void mLIT_CADENA() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LIT_CADENA;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:159:12: ( '\"' (~ ( '\"' | '\\n' | '\\r' | '\\t' ) )* '\"' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:159:14: '\"' (~ ( '\"' | '\\n' | '\\r' | '\\t' ) )* '\"'
            {
            	Match('\"'); 
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:159:18: (~ ( '\"' | '\\n' | '\\r' | '\\t' ) )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\b') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '!') || (LA2_0 >= '#' && LA2_0 <= '\uFFFE')) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:159:19: ~ ( '\"' | '\\n' | '\\r' | '\\t' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\b') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop2;
            	    }
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements

            	Match('\"'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LIT_CADENA

    // $ANTLR start LIT_LOGICO 
    public void mLIT_LOGICO() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LIT_LOGICO;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:161:12: ( 'true' | 'false' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);
            
            if ( (LA3_0 == 't') )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 'f') )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("161:1: LIT_LOGICO : ( 'true' | 'false' );", 3, 0, input);
            
                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:161:14: 'true'
                    {
                    	Match("true"); 

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:161:21: 'false'
                    {
                    	Match("false"); 

                    
                    }
                    break;
            
            }
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LIT_LOGICO

    // $ANTLR start IDENT 
    public void mIDENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = IDENT;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:163:7: ( ( LETRA | '_' ) ( LETRA | DIGITO | '_' )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:163:9: ( LETRA | '_' ) ( LETRA | DIGITO | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:163:20: ( LETRA | DIGITO | '_' )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( ((LA4_0 >= '0' && LA4_0 <= '9') || (LA4_0 >= 'A' && LA4_0 <= 'Z') || LA4_0 == '_' || (LA4_0 >= 'a' && LA4_0 <= 'z')) )
            	    {
            	        alt4 = 1;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop4;
            	    }
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end IDENT

    // $ANTLR start COMENTARIO 
    public void mCOMENTARIO() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = COMENTARIO;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:12: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:14: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:19: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);
            	    
            	    if ( ((LA5_0 >= '\u0000' && LA5_0 <= '\t') || (LA5_0 >= '\u000B' && LA5_0 <= '\f') || (LA5_0 >= '\u000E' && LA5_0 <= '\uFFFE')) )
            	    {
            	        alt5 = 1;
            	    }
            	    
            	
            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:20: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop5;
            	    }
            	} while (true);
            	
            	loop5:
            		;	// Stops C# compiler whinging that label 'loop5' has no statements

            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:35: ( '\\r' )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);
            	
            	if ( (LA6_0 == '\r') )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:165:35: '\\r'
            	        {
            	        	Match('\r'); 
            	        
            	        }
            	        break;
            	
            	}

            	Match('\n'); 
            	channel=HIDDEN;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end COMENTARIO

    // $ANTLR start WS 
    public void mWS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WS;
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:167:4: ( ( ' ' | '\\r' | '\\n' | '\\t' )+ )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:167:6: ( ' ' | '\\r' | '\\n' | '\\t' )+
            {
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:167:6: ( ' ' | '\\r' | '\\n' | '\\t' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( ((LA7_0 >= '\t' && LA7_0 <= '\n') || LA7_0 == '\r' || LA7_0 == ' ') )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements

            	channel=HIDDEN;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WS

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:8: ( T24 | T25 | T26 | T27 | T28 | T29 | T30 | T31 | T32 | T33 | T34 | T35 | T36 | T37 | T38 | T39 | T40 | T41 | T42 | T43 | T44 | T45 | T46 | T47 | T48 | T49 | T50 | T51 | T52 | T53 | T54 | LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO | IDENT | COMENTARIO | WS )
        int alt8 = 38;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:10: T24
                {
                	mT24(); 
                
                }
                break;
            case 2 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:14: T25
                {
                	mT25(); 
                
                }
                break;
            case 3 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:18: T26
                {
                	mT26(); 
                
                }
                break;
            case 4 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:22: T27
                {
                	mT27(); 
                
                }
                break;
            case 5 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:26: T28
                {
                	mT28(); 
                
                }
                break;
            case 6 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:30: T29
                {
                	mT29(); 
                
                }
                break;
            case 7 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:34: T30
                {
                	mT30(); 
                
                }
                break;
            case 8 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:38: T31
                {
                	mT31(); 
                
                }
                break;
            case 9 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:42: T32
                {
                	mT32(); 
                
                }
                break;
            case 10 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:46: T33
                {
                	mT33(); 
                
                }
                break;
            case 11 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:50: T34
                {
                	mT34(); 
                
                }
                break;
            case 12 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:54: T35
                {
                	mT35(); 
                
                }
                break;
            case 13 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:58: T36
                {
                	mT36(); 
                
                }
                break;
            case 14 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:62: T37
                {
                	mT37(); 
                
                }
                break;
            case 15 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:66: T38
                {
                	mT38(); 
                
                }
                break;
            case 16 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:70: T39
                {
                	mT39(); 
                
                }
                break;
            case 17 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:74: T40
                {
                	mT40(); 
                
                }
                break;
            case 18 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:78: T41
                {
                	mT41(); 
                
                }
                break;
            case 19 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:82: T42
                {
                	mT42(); 
                
                }
                break;
            case 20 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:86: T43
                {
                	mT43(); 
                
                }
                break;
            case 21 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:90: T44
                {
                	mT44(); 
                
                }
                break;
            case 22 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:94: T45
                {
                	mT45(); 
                
                }
                break;
            case 23 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:98: T46
                {
                	mT46(); 
                
                }
                break;
            case 24 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:102: T47
                {
                	mT47(); 
                
                }
                break;
            case 25 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:106: T48
                {
                	mT48(); 
                
                }
                break;
            case 26 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:110: T49
                {
                	mT49(); 
                
                }
                break;
            case 27 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:114: T50
                {
                	mT50(); 
                
                }
                break;
            case 28 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:118: T51
                {
                	mT51(); 
                
                }
                break;
            case 29 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:122: T52
                {
                	mT52(); 
                
                }
                break;
            case 30 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:126: T53
                {
                	mT53(); 
                
                }
                break;
            case 31 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:130: T54
                {
                	mT54(); 
                
                }
                break;
            case 32 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:134: LIT_ENTERO
                {
                	mLIT_ENTERO(); 
                
                }
                break;
            case 33 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:145: LIT_REAL
                {
                	mLIT_REAL(); 
                
                }
                break;
            case 34 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:154: LIT_CADENA
                {
                	mLIT_CADENA(); 
                
                }
                break;
            case 35 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:165: LIT_LOGICO
                {
                	mLIT_LOGICO(); 
                
                }
                break;
            case 36 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:176: IDENT
                {
                	mIDENT(); 
                
                }
                break;
            case 37 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:182: COMENTARIO
                {
                	mCOMENTARIO(); 
                
                }
                break;
            case 38 :
                // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:1:193: WS
                {
                	mWS(); 
                
                }
                break;
        
        }
    
    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	}

    static readonly short[] DFA8_eot = {
        -1, 30, -1, -1, -1, 30, -1, -1, -1, 35, 30, 30, 30, 30, 30, 30, 
        30, 30, -1, -1, 47, 49, 51, -1, -1, -1, 53, 54, -1, 30, -1, -1, 
        30, 30, -1, -1, 59, 30, 30, 30, 30, 30, 30, 30, 30, 30, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, 30, 70, 30, -1, 72, 30, 30, 30, 
        30, 30, 30, 30, 30, 30, -1, 30, -1, 83, 30, 30, 30, 30, 30, 89, 
        90, 91, 30, -1, 93, 30, 91, 95, 30, -1, -1, -1, 30, -1, 98, -1, 
        99, 100, -1, -1, -1
        };
    static readonly short[] DFA8_eof = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1
        };
    static readonly int[] DFA8_min = {
        9, 112, 0, 0, 0, 114, 0, 0, 0, 61, 102, 108, 104, 101, 97, 116, 
        111, 111, 0, 0, 61, 61, 61, 0, 0, 0, 47, 46, 0, 114, 0, 0, 105, 
        111, 0, 0, 48, 116, 115, 105, 116, 108, 111, 114, 111, 105, 0, 0, 
        0, 0, 0, 0, 0, 0, 0, 0, 117, 48, 103, 0, 48, 101, 108, 117, 115, 
        97, 105, 108, 100, 101, 0, 114, 0, 48, 101, 114, 101, 116, 110, 
        48, 48, 48, 97, 0, 48, 110, 48, 48, 103, 0, 0, 0, 109, 0, 48, 0, 
        48, 48, 0, 0, 0
        };
    static readonly int[] DFA8_max = {
        125, 112, 0, 0, 0, 114, 0, 0, 0, 61, 110, 108, 104, 101, 108, 116, 
        111, 111, 0, 0, 61, 61, 61, 0, 0, 0, 47, 57, 0, 114, 0, 0, 105, 
        111, 0, 0, 122, 116, 115, 105, 116, 108, 111, 114, 111, 105, 0, 
        0, 0, 0, 0, 0, 0, 0, 0, 0, 117, 122, 103, 0, 122, 101, 108, 117, 
        115, 97, 105, 108, 100, 101, 0, 114, 0, 122, 101, 114, 101, 116, 
        110, 122, 122, 122, 97, 0, 122, 110, 122, 122, 103, 0, 0, 0, 109, 
        0, 122, 0, 122, 122, 0, 0, 0
        };
    static readonly short[] DFA8_accept = {
        -1, -1, 2, 3, 4, -1, 6, 7, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        19, 20, -1, -1, -1, 27, 28, 29, -1, -1, 34, -1, 36, 38, -1, -1, 
        21, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 22, 31, 25, 23, 26, 
        24, 37, 30, 32, 33, -1, -1, -1, 10, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, 1, -1, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 
        -1, -1, -1, -1, -1, 17, 18, 35, -1, 12, -1, 15, -1, -1, 13, 16, 
        5
        };
    static readonly short[] DFA8_special = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1, -1, -1
        };
    
    static readonly short[] dfa8_transition_null = null;

    static readonly short[] dfa8_transition0 = {
    	48
    	};
    static readonly short[] dfa8_transition1 = {
    	96
    	};
    static readonly short[] dfa8_transition2 = {
    	79
    	};
    static readonly short[] dfa8_transition3 = {
    	67
    	};
    static readonly short[] dfa8_transition4 = {
    	88
    	};
    static readonly short[] dfa8_transition5 = {
    	30, 30, 30, 30, 30, 30, 30, 30, 30, 30, -1, -1, -1, -1, -1, -1, -1, 
    	    30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 
    	    30, 30, 30, 30, 30, 30, 30, 30, 30, 30, -1, -1, -1, -1, 30, -1, 
    	    30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 
    	    30, 30, 30, 30, 30, 30, 30, 30, 30, 30
    	};
    static readonly short[] dfa8_transition6 = {
    	78
    	};
    static readonly short[] dfa8_transition7 = {
    	66
    	};
    static readonly short[] dfa8_transition8 = {
    	33
    	};
    static readonly short[] dfa8_transition9 = {
    	80
    	};
    static readonly short[] dfa8_transition10 = {
    	68
    	};
    static readonly short[] dfa8_transition11 = {
    	50
    	};
    static readonly short[] dfa8_transition12 = {
    	32
    	};
    static readonly short[] dfa8_transition13 = {
    	43
    	};
    static readonly short[] dfa8_transition14 = {
    	44
    	};
    static readonly short[] dfa8_transition15 = {
    	45
    	};
    static readonly short[] dfa8_transition16 = {
    	52
    	};
    static readonly short[] dfa8_transition17 = {
    	39
    	};
    static readonly short[] dfa8_transition18 = {
    	38
    	};
    static readonly short[] dfa8_transition19 = {
    	64
    	};
    static readonly short[] dfa8_transition20 = {
    	76
    	};
    static readonly short[] dfa8_transition21 = {
    	69
    	};
    static readonly short[] dfa8_transition22 = {
    	81
    	};
    static readonly short[] dfa8_transition23 = {
    	40
    	};
    static readonly short[] dfa8_transition24 = {
    	36, -1, -1, -1, -1, -1, -1, -1, 37
    	};
    static readonly short[] dfa8_transition25 = {
    	56
    	};
    static readonly short[] dfa8_transition26 = {
    	55, -1, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27
    	};
    static readonly short[] dfa8_transition27 = {
    	57
    	};
    static readonly short[] dfa8_transition28 = {
    	86
    	};
    static readonly short[] dfa8_transition29 = {
    	34
    	};
    static readonly short[] dfa8_transition30 = {
    	97
    	};
    static readonly short[] dfa8_transition31 = {
    	82
    	};
    static readonly short[] dfa8_transition32 = {
    	92
    	};
    static readonly short[] dfa8_transition33 = {
    	58
    	};
    static readonly short[] dfa8_transition34 = {
    	71
    	};
    static readonly short[] dfa8_transition35 = {
    	41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 42
    	};
    static readonly short[] dfa8_transition36 = {
    	61
    	};
    static readonly short[] dfa8_transition37 = {
    	62
    	};
    static readonly short[] dfa8_transition38 = {
    	46
    	};
    static readonly short[] dfa8_transition39 = {
    	74
    	};
    static readonly short[] dfa8_transition40 = {
    	73
    	};
    static readonly short[] dfa8_transition41 = {
    	63
    	};
    static readonly short[] dfa8_transition42 = {
    	31, 31, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, 31, 20, 28, -1, -1, -1, 19, -1, 2, 3, 25, 
    	    23, 8, 24, -1, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, -1, 
    	    4, 22, 9, 21, -1, -1, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 
    	    30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, -1, 
    	    -1, -1, -1, 30, -1, 1, 16, 30, 30, 11, 14, 30, 30, 10, 30, 30, 
    	    30, 30, 30, 30, 5, 30, 13, 15, 29, 30, 17, 12, 30, 30, 30, 6, 18, 
    	    7
    	};
    static readonly short[] dfa8_transition43 = {
    	75
    	};
    static readonly short[] dfa8_transition44 = {
    	84
    	};
    static readonly short[] dfa8_transition45 = {
    	60
    	};
    static readonly short[] dfa8_transition46 = {
    	94
    	};
    static readonly short[] dfa8_transition47 = {
    	85
    	};
    static readonly short[] dfa8_transition48 = {
    	65
    	};
    static readonly short[] dfa8_transition49 = {
    	87
    	};
    static readonly short[] dfa8_transition50 = {
    	77
    	};
    
    static readonly short[][] DFA8_transition = {
    	dfa8_transition42,
    	dfa8_transition12,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition8,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition29,
    	dfa8_transition24,
    	dfa8_transition18,
    	dfa8_transition17,
    	dfa8_transition23,
    	dfa8_transition35,
    	dfa8_transition13,
    	dfa8_transition14,
    	dfa8_transition15,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition38,
    	dfa8_transition0,
    	dfa8_transition11,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition16,
    	dfa8_transition26,
    	dfa8_transition_null,
    	dfa8_transition25,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition27,
    	dfa8_transition33,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition45,
    	dfa8_transition36,
    	dfa8_transition37,
    	dfa8_transition41,
    	dfa8_transition19,
    	dfa8_transition48,
    	dfa8_transition7,
    	dfa8_transition3,
    	dfa8_transition10,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition21,
    	dfa8_transition5,
    	dfa8_transition34,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition40,
    	dfa8_transition39,
    	dfa8_transition43,
    	dfa8_transition20,
    	dfa8_transition50,
    	dfa8_transition6,
    	dfa8_transition2,
    	dfa8_transition9,
    	dfa8_transition22,
    	dfa8_transition_null,
    	dfa8_transition31,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition44,
    	dfa8_transition47,
    	dfa8_transition28,
    	dfa8_transition49,
    	dfa8_transition4,
    	dfa8_transition5,
    	dfa8_transition5,
    	dfa8_transition5,
    	dfa8_transition32,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition46,
    	dfa8_transition5,
    	dfa8_transition5,
    	dfa8_transition1,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition30,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition_null,
    	dfa8_transition5,
    	dfa8_transition5,
    	dfa8_transition_null,
    	dfa8_transition_null,
    	dfa8_transition_null
        };
    
    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer) 
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept     = DFA8_accept;
            this.special    = DFA8_special;
            this.transition = DFA8_transition;
        }
    
        override public string Description
        {
            get { return "1:1: Tokens : ( T24 | T25 | T26 | T27 | T28 | T29 | T30 | T31 | T32 | T33 | T34 | T35 | T36 | T37 | T38 | T39 | T40 | T41 | T42 | T43 | T44 | T45 | T46 | T47 | T48 | T49 | T50 | T51 | T52 | T53 | T54 | LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO | IDENT | COMENTARIO | WS );"; }
        }
    
    }
    
 
    
}
