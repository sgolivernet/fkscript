// $ANTLR 3.0.1 D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g 2007-09-09 16:16:58

using System.Collections.Generic;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class FKVMSem : TreeParser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"PROGRAMA", 
		"DECLARACION", 
		"DECLARACIONPARAM", 
		"LISTADECLARACIONESAPI", 
		"DECLARACIONAPI", 
		"ASIGNACION", 
		"MENOSUNARIO", 
		"LISTAINSTRUCCIONES", 
		"LLAMADA", 
		"LISTAEXPRESIONES", 
		"LISTAPARAMETROS", 
		"IDENT", 
		"LIT_ENTERO", 
		"LIT_REAL", 
		"LIT_CADENA", 
		"LIT_LOGICO", 
		"LETRA", 
		"DIGITO", 
		"COMENTARIO", 
		"WS", 
		"'api'", 
		"'('", 
		"')'", 
		"';'", 
		"'program'", 
		"'{'", 
		"'}'", 
		"','", 
		"'='", 
		"'if'", 
		"'else'", 
		"'while'", 
		"'return'", 
		"'int'", 
		"'float'", 
		"'string'", 
		"'bool'", 
		"'void'", 
		"'||'", 
		"'&&'", 
		"'=='", 
		"'!='", 
		"'>'", 
		"'<'", 
		"'>='", 
		"'<='", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'!'"
    };

    public const int DIGITO = 21;
    public const int DECLARACIONAPI = 8;
    public const int ASIGNACION = 9;
    public const int LISTADECLARACIONESAPI = 7;
    public const int LIT_ENTERO = 16;
    public const int LISTAINSTRUCCIONES = 11;
    public const int LLAMADA = 12;
    public const int EOF = -1;
    public const int LISTAEXPRESIONES = 13;
    public const int LIT_CADENA = 18;
    public const int LISTAPARAMETROS = 14;
    public const int WS = 23;
    public const int DECLARACIONPARAM = 6;
    public const int MENOSUNARIO = 10;
    public const int COMENTARIO = 22;
    public const int DECLARACION = 5;
    public const int PROGRAMA = 4;
    public const int IDENT = 15;
    public const int LIT_REAL = 17;
    public const int LIT_LOGICO = 19;
    public const int LETRA = 20;
    
    
        public FKVMSem(ITreeNodeStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g"; }
	}

    
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


    
    // $ANTLR start programa
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:74:1: programa[Dictionary<string,Symbol> symtable] : ^( PROGRAMA declaraciones_api principal ) ;
    public void programa(Dictionary<string, Symbol> symtable) // throws RecognitionException [1]
    {   
        
        this.symtable = symtable;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:78:1: ( ^( PROGRAMA declaraciones_api principal ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:78:3: ^( PROGRAMA declaraciones_api principal )
            {
            	Match(input,PROGRAMA,FOLLOW_PROGRAMA_in_programa55); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_declaraciones_api_in_programa57);
            	declaraciones_api();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_principal_in_programa59);
            	principal();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end programa

    
    // $ANTLR start declaraciones_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:80:1: declaraciones_api : ^( LISTADECLARACIONESAPI ( declaracion_api )* ) ;
    public void declaraciones_api() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:80:19: ( ^( LISTADECLARACIONESAPI ( declaracion_api )* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:80:21: ^( LISTADECLARACIONESAPI ( declaracion_api )* )
            {
            	Match(input,LISTADECLARACIONESAPI,FOLLOW_LISTADECLARACIONESAPI_in_declaraciones_api70); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:80:45: ( declaracion_api )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);
            	        
            	        if ( (LA1_0 == DECLARACIONAPI) )
            	        {
            	            alt1 = 1;
            	        }
            	        
            	    
            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:80:45: declaracion_api
            	    		    {
            	    		    	PushFollow(FOLLOW_declaracion_api_in_declaraciones_api72);
            	    		    	declaracion_api();
            	    		    	followingStackPointer_--;

            	    		    
            	    		    }
            	    		    break;
            	    
            	    		default:
            	    		    goto loop1;
            	        }
            	    } while (true);
            	    
            	    loop1:
            	    	;	// Stops C# compiler whinging that label 'loop1' has no statements

            	
            	    Match(input, Token.UP, null); 
            	}
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end declaraciones_api

    
    // $ANTLR start declaracion_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:82:1: declaracion_api : ^( DECLARACIONAPI tipo IDENT ) ;
    public void declaracion_api() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:82:17: ( ^( DECLARACIONAPI tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:82:19: ^( DECLARACIONAPI tipo IDENT )
            {
            	Match(input,DECLARACIONAPI,FOLLOW_DECLARACIONAPI_in_declaracion_api84); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_declaracion_api86);
            	tipo();
            	followingStackPointer_--;

            	Match(input,IDENT,FOLLOW_IDENT_in_declaracion_api88); 
            	
            	Match(input, Token.UP, null); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end declaracion_api

    
    // $ANTLR start principal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:84:1: principal : ^( 'program' tipo IDENT lista_instrucciones ) ;
    public void principal() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:84:11: ( ^( 'program' tipo IDENT lista_instrucciones ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:84:13: ^( 'program' tipo IDENT lista_instrucciones )
            {
            	Match(input,28,FOLLOW_28_in_principal99); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_principal101);
            	tipo();
            	followingStackPointer_--;

            	Match(input,IDENT,FOLLOW_IDENT_in_principal103); 
            	PushFollow(FOLLOW_lista_instrucciones_in_principal105);
            	lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end principal

    
    // $ANTLR start lista_instrucciones
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:86:1: lista_instrucciones : ^( LISTAINSTRUCCIONES ( instruccion )* ) ;
    public void lista_instrucciones() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:86:21: ( ^( LISTAINSTRUCCIONES ( instruccion )* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:86:23: ^( LISTAINSTRUCCIONES ( instruccion )* )
            {
            	Match(input,LISTAINSTRUCCIONES,FOLLOW_LISTAINSTRUCCIONES_in_lista_instrucciones115); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:86:44: ( instruccion )*
            	    do 
            	    {
            	        int alt2 = 2;
            	        int LA2_0 = input.LA(1);
            	        
            	        if ( (LA2_0 == DECLARACION || (LA2_0 >= ASIGNACION && LA2_0 <= MENOSUNARIO) || LA2_0 == LLAMADA || (LA2_0 >= IDENT && LA2_0 <= LIT_LOGICO) || LA2_0 == 33 || (LA2_0 >= 35 && LA2_0 <= 36) || (LA2_0 >= 44 && LA2_0 <= 54)) )
            	        {
            	            alt2 = 1;
            	        }
            	        
            	    
            	        switch (alt2) 
            	    	{
            	    		case 1 :
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:86:44: instruccion
            	    		    {
            	    		    	PushFollow(FOLLOW_instruccion_in_lista_instrucciones117);
            	    		    	instruccion();
            	    		    	followingStackPointer_--;

            	    		    
            	    		    }
            	    		    break;
            	    
            	    		default:
            	    		    goto loop2;
            	        }
            	    } while (true);
            	    
            	    loop2:
            	    	;	// Stops C# compiler whinging that label 'loop2' has no statements

            	
            	    Match(input, Token.UP, null); 
            	}
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end lista_instrucciones

    
    // $ANTLR start instruccion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:88:1: instruccion : ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr );
    public void instruccion() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:88:13: ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr )
            int alt3 = 6;
            switch ( input.LA(1) ) 
            {
            case DECLARACION:
            	{
                alt3 = 1;
                }
                break;
            case ASIGNACION:
            	{
                alt3 = 2;
                }
                break;
            case 33:
            	{
                alt3 = 3;
                }
                break;
            case 35:
            	{
                alt3 = 4;
                }
                break;
            case 36:
            	{
                alt3 = 5;
                }
                break;
            case MENOSUNARIO:
            case LLAMADA:
            case IDENT:
            case LIT_ENTERO:
            case LIT_REAL:
            case LIT_CADENA:
            case LIT_LOGICO:
            case 44:
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
            case 50:
            case 51:
            case 52:
            case 53:
            case 54:
            	{
                alt3 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("88:1: instruccion : ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr );", 3, 0, input);
            
            	    throw nvae_d3s0;
            }
            
            switch (alt3) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:88:15: inst_decl
                    {
                    	PushFollow(FOLLOW_inst_decl_in_instruccion127);
                    	inst_decl();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:89:6: inst_asig
                    {
                    	PushFollow(FOLLOW_inst_asig_in_instruccion135);
                    	inst_asig();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:90:6: inst_if
                    {
                    	PushFollow(FOLLOW_inst_if_in_instruccion142);
                    	inst_if();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:91:6: inst_while
                    {
                    	PushFollow(FOLLOW_inst_while_in_instruccion149);
                    	inst_while();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:92:6: inst_return
                    {
                    	PushFollow(FOLLOW_inst_return_in_instruccion156);
                    	inst_return();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:93:6: inst_expr
                    {
                    	PushFollow(FOLLOW_inst_expr_in_instruccion163);
                    	inst_expr();
                    	followingStackPointer_--;

                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end instruccion

    
    // $ANTLR start inst_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:96:1: inst_expr : expresion ;
    public void inst_expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:96:11: ( expresion )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:96:13: expresion
            {
            	PushFollow(FOLLOW_expresion_in_inst_expr178);
            	expresion();
            	followingStackPointer_--;

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_expr

    
    // $ANTLR start inst_decl
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:98:1: inst_decl : ^( DECLARACION tipo IDENT ) ;
    public void inst_decl() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:98:11: ( ^( DECLARACION tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:98:13: ^( DECLARACION tipo IDENT )
            {
            	Match(input,DECLARACION,FOLLOW_DECLARACION_in_inst_decl191); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_inst_decl193);
            	tipo();
            	followingStackPointer_--;

            	Match(input,IDENT,FOLLOW_IDENT_in_inst_decl195); 
            	
            	Match(input, Token.UP, null); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_decl

    
    // $ANTLR start inst_asig
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:100:1: inst_asig : ^( ASIGNACION IDENT e1= expresion ) ;
    public void inst_asig() // throws RecognitionException [1]
    {   
        FkvmAST IDENT1 = null;
        String e1 = null;
        
    
        
        FkvmAST root = (FkvmAST)input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:104:1: ( ^( ASIGNACION IDENT e1= expresion ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:104:3: ^( ASIGNACION IDENT e1= expresion )
            {
            	Match(input,ASIGNACION,FOLLOW_ASIGNACION_in_inst_asig212); 
            	
            	Match(input, Token.DOWN, null); 
            	IDENT1 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_inst_asig214); 
            	PushFollow(FOLLOW_expresion_in_inst_asig218);
            	e1 = expresion();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            		root.expType = e1; 
            		
            		if(symtable.ContainsKey(IDENT1.Text))
            		{
            			IDENT1.symbol = (Symbol)symtable[IDENT1.Text];
            			
            			if(!comprobarTipoAsig(root.expType,IDENT1.symbol.type)) 
            			{
            				registrarError(root.Line, "Incorrect type in assignment.");
            			}
            		}
            		else
            		{
            			registrarError(root.Line, "Identifier '" + IDENT1.Text + "' has not been declared.");
            		}	

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_asig

    
    // $ANTLR start inst_if
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:122:1: inst_if : ^(ins= 'if' e1= expresion lista_instrucciones lista_instrucciones ) ;
    public void inst_if() // throws RecognitionException [1]
    {   
        FkvmAST ins = null;
        String e1 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:122:9: ( ^(ins= 'if' e1= expresion lista_instrucciones lista_instrucciones ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:122:11: ^(ins= 'if' e1= expresion lista_instrucciones lista_instrucciones )
            {
            	ins = (FkvmAST)input.LT(1);
            	Match(input,33,FOLLOW_33_in_inst_if232); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_if236);
            	e1 = expresion();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_if238);
            	lista_instrucciones();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_if240);
            	lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            			
            		if(!e1.Equals("bool"))
            	        {
            	        	registrarError(ins.Line, "Incorrect type in IF instruction.");
            	        }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_if

    
    // $ANTLR start inst_while
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:130:1: inst_while : ^(ins= 'while' e1= expresion lista_instrucciones ) ;
    public void inst_while() // throws RecognitionException [1]
    {   
        FkvmAST ins = null;
        String e1 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:130:12: ( ^(ins= 'while' e1= expresion lista_instrucciones ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:130:14: ^(ins= 'while' e1= expresion lista_instrucciones )
            {
            	ins = (FkvmAST)input.LT(1);
            	Match(input,35,FOLLOW_35_in_inst_while254); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_while258);
            	e1 = expresion();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_while260);
            	lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            		
            		if(!e1.Equals("bool"))
            	        {
            	        	registrarError(ins.Line, "Incorrect type in WHILE instruction.");
            	        }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_while

    
    // $ANTLR start inst_return
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:138:1: inst_return : ^( 'return' e1= expresion ) ;
    public void inst_return() // throws RecognitionException [1]
    {   
        String e1 = null;
        
    
        
        FkvmAST root = (FkvmAST)input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:142:6: ( ^( 'return' e1= expresion ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:142:8: ^( 'return' e1= expresion )
            {
            	Match(input,36,FOLLOW_36_in_inst_return283); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_return287);
            	e1 = expresion();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	root.expType = e1;
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end inst_return

    
    // $ANTLR start tipo
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:144:1: tipo : ( 'int' | 'float' | 'bool' | 'string' | 'void' );
    public void tipo() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:144:6: ( 'int' | 'float' | 'bool' | 'string' | 'void' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:
            {
            	if ( (input.LA(1) >= 37 && input.LA(1) <= 41) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_tipo0);    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end tipo

    
    // $ANTLR start literal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:151:1: literal returns [String type] : ( LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO );
    public String literal() // throws RecognitionException [1]
    {   

        String type = null;
    
        
        type = "";
        FkvmAST root = (FkvmAST)input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:159:9: ( LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO )
            int alt4 = 4;
            switch ( input.LA(1) ) 
            {
            case LIT_ENTERO:
            	{
                alt4 = 1;
                }
                break;
            case LIT_REAL:
            	{
                alt4 = 2;
                }
                break;
            case LIT_CADENA:
            	{
                alt4 = 3;
                }
                break;
            case LIT_LOGICO:
            	{
                alt4 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("151:1: literal returns [String type] : ( LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO );", 4, 0, input);
            
            	    throw nvae_d4s0;
            }
            
            switch (alt4) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:159:11: LIT_ENTERO
                    {
                    	Match(input,LIT_ENTERO,FOLLOW_LIT_ENTERO_in_literal371); 
                    	type = "int";
                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:160:11: LIT_REAL
                    {
                    	Match(input,LIT_REAL,FOLLOW_LIT_REAL_in_literal385); 
                    	type = "float";
                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:161:11: LIT_CADENA
                    {
                    	Match(input,LIT_CADENA,FOLLOW_LIT_CADENA_in_literal399); 
                    	type = "string";
                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:162:11: LIT_LOGICO
                    {
                    	Match(input,LIT_LOGICO,FOLLOW_LIT_LOGICO_in_literal413); 
                    	type = "bool";
                    
                    }
                    break;
            
            }
            
            root.expType = type;
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return type;
    }
    // $ANTLR end literal

    
    // $ANTLR start expresion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:165:1: expresion returns [String type] : ( ^( opComparacion e1= expresion e2= expresion ) | ^( opAritmetico e1= expresion e2= expresion ) | ^( MENOSUNARIO e1= expresion ) | ^( '!' e1= expresion ) | IDENT | literal | llamada );
    public String expresion() // throws RecognitionException [1]
    {   

        String type = null;
    
        FkvmAST IDENT2 = null;
        String e1 = null;

        String e2 = null;

        String literal3 = null;

        String llamada4 = null;
        
    
        
        type = "";
        FkvmAST root = (FkvmAST)input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:173:11: ( ^( opComparacion e1= expresion e2= expresion ) | ^( opAritmetico e1= expresion e2= expresion ) | ^( MENOSUNARIO e1= expresion ) | ^( '!' e1= expresion ) | IDENT | literal | llamada )
            int alt5 = 7;
            switch ( input.LA(1) ) 
            {
            case 44:
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
            	{
                alt5 = 1;
                }
                break;
            case 50:
            case 51:
            case 52:
            case 53:
            	{
                alt5 = 2;
                }
                break;
            case MENOSUNARIO:
            	{
                alt5 = 3;
                }
                break;
            case 54:
            	{
                alt5 = 4;
                }
                break;
            case IDENT:
            	{
                alt5 = 5;
                }
                break;
            case LIT_ENTERO:
            case LIT_REAL:
            case LIT_CADENA:
            case LIT_LOGICO:
            	{
                alt5 = 6;
                }
                break;
            case LLAMADA:
            	{
                alt5 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("165:1: expresion returns [String type] : ( ^( opComparacion e1= expresion e2= expresion ) | ^( opAritmetico e1= expresion e2= expresion ) | ^( MENOSUNARIO e1= expresion ) | ^( '!' e1= expresion ) | IDENT | literal | llamada );", 5, 0, input);
            
            	    throw nvae_d5s0;
            }
            
            switch (alt5) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:173:13: ^( opComparacion e1= expresion e2= expresion )
                    {
                    	PushFollow(FOLLOW_opComparacion_in_expresion465);
                    	opComparacion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion469);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	PushFollow(FOLLOW_expresion_in_expresion473);
                    	e2 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	          			type =  "bool";
                    	          			root.expSecType = e1;
                    	          			
                    	          			if(!comprobarTipoExpComp(e1, e2))
                    	          			{
                    	          				registrarError(root.Line, "Incorrect types in expression.");
                    	          			}
                    	          	
                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:182:13: ^( opAritmetico e1= expresion e2= expresion )
                    {
                    	PushFollow(FOLLOW_opAritmetico_in_expresion491);
                    	opAritmetico();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion495);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	PushFollow(FOLLOW_expresion_in_expresion499);
                    	e2 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	          			type = e1;
                    	          			
                    	          			if(!comprobarTipoExpArit(e1, e2))
                    	          			{
                    	          			   	registrarError(root.Line, "Incorrect types in expression.");
                    	          			}
                    	          	
                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:190:13: ^( MENOSUNARIO e1= expresion )
                    {
                    	Match(input,MENOSUNARIO,FOLLOW_MENOSUNARIO_in_expresion517); 
                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion521);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	          			type = e1;
                    	          			
                    	          			if(!(e1.Equals("int") || e1.Equals("float")))
                    	          			{
                    	          				registrarError(root.Line, "Incorrect types in expression.");
                    	          			}
                    	          	
                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:198:13: ^( '!' e1= expresion )
                    {
                    	Match(input,54,FOLLOW_54_in_expresion539); 
                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion543);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	          			type = e1;
                    	          			
                    	          			if(!e1.Equals("bool"))
                    	          			{
                    	          				registrarError(root.Line, "Incorrect types in expression.");
                    	          			}
                    	          	
                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:206:13: IDENT
                    {
                    	IDENT2 = (FkvmAST)input.LT(1);
                    	Match(input,IDENT,FOLLOW_IDENT_in_expresion560); 
                    	
                    	          		if(symtable.ContainsKey(IDENT2.Text))
                    	          		{
                    	          			root.symbol = (Symbol)symtable[IDENT2.Text]; type = root.symbol.type;
                    	          		}
                    				    else
                    					{
                    						registrarError(root.Line, "Identifier '" + IDENT2.Text + "' has not been declared.");
                    					}
                    	          
                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:216:13: literal
                    {
                    	PushFollow(FOLLOW_literal_in_expresion576);
                    	literal3 = literal();
                    	followingStackPointer_--;

                    	type = literal3;
                    
                    }
                    break;
                case 7 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:217:13: llamada
                    {
                    	PushFollow(FOLLOW_llamada_in_expresion592);
                    	llamada4 = llamada();
                    	followingStackPointer_--;

                    	type = llamada4;
                    
                    }
                    break;
            
            }
            
            root.expType = type;
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return type;
    }
    // $ANTLR end expresion

    
    // $ANTLR start llamada
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:220:1: llamada returns [String type] : ^( LLAMADA IDENT lista_expr ) ;
    public String llamada() // throws RecognitionException [1]
    {   

        String type = null;
    
        FkvmAST IDENT5 = null;
    
        
        type = "";
        FkvmAST root = (FkvmAST)input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:228:1: ( ^( LLAMADA IDENT lista_expr ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:228:3: ^( LLAMADA IDENT lista_expr )
            {
            	Match(input,LLAMADA,FOLLOW_LLAMADA_in_llamada639); 
            	
            	Match(input, Token.DOWN, null); 
            	IDENT5 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_llamada641); 
            	PushFollow(FOLLOW_lista_expr_in_llamada643);
            	lista_expr();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            			if(symtable.ContainsKey(IDENT5.Text))
            	        {
            	        	root.symbol = (Symbol)symtable[IDENT5.Text]; type = root.symbol.type;
            	        }
            			else
            			{
            				registrarError(root.Line, "Api function '" + IDENT5.Text + "' has not been declared.");
            			}

            
            }
    
            
            root.expType = type;
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return type;
    }
    // $ANTLR end llamada

    
    // $ANTLR start lista_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:239:1: lista_expr : ^( LISTAEXPRESIONES ( expresion )* ) ;
    public void lista_expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:239:12: ( ^( LISTAEXPRESIONES ( expresion )* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:239:14: ^( LISTAEXPRESIONES ( expresion )* )
            {
            	Match(input,LISTAEXPRESIONES,FOLLOW_LISTAEXPRESIONES_in_lista_expr656); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:239:33: ( expresion )*
            	    do 
            	    {
            	        int alt6 = 2;
            	        int LA6_0 = input.LA(1);
            	        
            	        if ( (LA6_0 == MENOSUNARIO || LA6_0 == LLAMADA || (LA6_0 >= IDENT && LA6_0 <= LIT_LOGICO) || (LA6_0 >= 44 && LA6_0 <= 54)) )
            	        {
            	            alt6 = 1;
            	        }
            	        
            	    
            	        switch (alt6) 
            	    	{
            	    		case 1 :
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:239:33: expresion
            	    		    {
            	    		    	PushFollow(FOLLOW_expresion_in_lista_expr658);
            	    		    	expresion();
            	    		    	followingStackPointer_--;

            	    		    
            	    		    }
            	    		    break;
            	    
            	    		default:
            	    		    goto loop6;
            	        }
            	    } while (true);
            	    
            	    loop6:
            	    	;	// Stops C# compiler whinging that label 'loop6' has no statements

            	
            	    Match(input, Token.UP, null); 
            	}
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end lista_expr

    
    // $ANTLR start opAritmetico
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:242:1: opAritmetico : ( '+' | '-' | '*' | '/' );
    public void opAritmetico() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:242:14: ( '+' | '-' | '*' | '/' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:
            {
            	if ( (input.LA(1) >= 50 && input.LA(1) <= 53) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_opAritmetico0);    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end opAritmetico

    
    // $ANTLR start opComparacion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:244:1: opComparacion : ( '==' | '!=' | '>=' | '<=' | '>' | '<' );
    public void opComparacion() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:244:15: ( '==' | '!=' | '>=' | '<=' | '>' | '<' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMSem.g:
            {
            	if ( (input.LA(1) >= 44 && input.LA(1) <= 49) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_opComparacion0);    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end opComparacion


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_PROGRAMA_in_programa55 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_declaraciones_api_in_programa57 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_principal_in_programa59 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTADECLARACIONESAPI_in_declaraciones_api70 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_declaracion_api_in_declaraciones_api72 = new BitSet(new ulong[]{0x0000000000000108UL});
    public static readonly BitSet FOLLOW_DECLARACIONAPI_in_declaracion_api84 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_declaracion_api86 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_declaracion_api88 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_28_in_principal99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_principal101 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_principal103 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_principal105 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTAINSTRUCCIONES_in_lista_instrucciones115 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_instruccion_in_lista_instrucciones117 = new BitSet(new ulong[]{0x007FF01A000F9628UL});
    public static readonly BitSet FOLLOW_inst_decl_in_instruccion127 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_asig_in_instruccion135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_if_in_instruccion142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_while_in_instruccion149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_return_in_instruccion156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_expr_in_instruccion163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_expr178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECLARACION_in_inst_decl191 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_inst_decl193 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_decl195 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASIGNACION_in_inst_asig212 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_asig214 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_asig218 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_33_in_inst_if232 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_if236 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_if238 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_if240 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_35_in_inst_while254 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_while258 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_while260 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_36_in_inst_return283 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_return287 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_set_in_tipo0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_ENTERO_in_literal371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_REAL_in_literal385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_CADENA_in_literal399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_LOGICO_in_literal413 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opComparacion_in_expresion465 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion469 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion473 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_opAritmetico_in_expresion491 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion495 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion499 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MENOSUNARIO_in_expresion517 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion521 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_54_in_expresion539 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion543 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IDENT_in_expresion560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_expresion576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_llamada_in_expresion592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LLAMADA_in_llamada639 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENT_in_llamada641 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_lista_expr_in_llamada643 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTAEXPRESIONES_in_lista_expr656 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_lista_expr658 = new BitSet(new ulong[]{0x007FF000000F9408UL});
    public static readonly BitSet FOLLOW_set_in_opAritmetico0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_opComparacion0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
