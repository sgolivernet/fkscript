// $ANTLR 3.0.1 D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g 2007-09-09 16:23:14

using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using Hashtable = System.Collections.Hashtable;

public class FKVMGen : TreeParser 
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
    
    
        public FKVMGen(ITreeNodeStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("FKVMGenTemplates", typeof(AngleBracketTemplateLexer));
    
    public StringTemplateGroup TemplateLib
    {
     	get { return this.templateLib; }
     	set { this.templateLib = value; }
    }
    
    /// <summary> Allows convenient multi-value initialization:
    ///  "new STAttrMap().Add(...).Add(...)"
    /// </summary>
    protected class STAttrMap : Hashtable
    {
      public STAttrMap Add(string attrName, object value) 
      {
        base.Add(attrName, value);
        return this;
      }
      public STAttrMap Add(string attrName, int value) 
      {
        base.Add(attrName, value);
        return this;
      }
    }

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g"; }
	}

    
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


    public class programa_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start programa
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:44:1: programa[int locales] : ^( PROGRAMA declaraciones_api principal[locales] ) -> {$principal.st};
    public programa_return programa(int locales) // throws RecognitionException [1]
    {   
        programa_return retval = new programa_return();
        retval.start = input.LT(1);
    
        principal_return principal1 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:44:23: ( ^( PROGRAMA declaraciones_api principal[locales] ) -> {$principal.st})
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:44:25: ^( PROGRAMA declaraciones_api principal[locales] )
            {
            	Match(input,PROGRAMA,FOLLOW_PROGRAMA_in_programa49); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_declaraciones_api_in_programa51);
            	declaraciones_api();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_principal_in_programa53);
            	principal1 = principal(locales);
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 44:74: -> {$principal.st}
            	{
            	    retval.st = principal1.st;
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
        return retval;
    }
    // $ANTLR end programa

    public class declaraciones_api_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start declaraciones_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:46:1: declaraciones_api : ^( LISTADECLARACIONESAPI ( declaracion_api )* ) ;
    public declaraciones_api_return declaraciones_api() // throws RecognitionException [1]
    {   
        declaraciones_api_return retval = new declaraciones_api_return();
        retval.start = input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:46:19: ( ^( LISTADECLARACIONESAPI ( declaracion_api )* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:46:21: ^( LISTADECLARACIONESAPI ( declaracion_api )* )
            {
            	Match(input,LISTADECLARACIONESAPI,FOLLOW_LISTADECLARACIONESAPI_in_declaraciones_api69); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:46:45: ( declaracion_api )*
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
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:46:45: declaracion_api
            	    		    {
            	    		    	PushFollow(FOLLOW_declaracion_api_in_declaraciones_api71);
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
        return retval;
    }
    // $ANTLR end declaraciones_api

    public class declaracion_api_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start declaracion_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:48:1: declaracion_api : ^( DECLARACIONAPI tipo IDENT ) ;
    public declaracion_api_return declaracion_api() // throws RecognitionException [1]
    {   
        declaracion_api_return retval = new declaracion_api_return();
        retval.start = input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:48:17: ( ^( DECLARACIONAPI tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:48:19: ^( DECLARACIONAPI tipo IDENT )
            {
            	Match(input,DECLARACIONAPI,FOLLOW_DECLARACIONAPI_in_declaracion_api83); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_declaracion_api85);
            	tipo();
            	followingStackPointer_--;

            	Match(input,IDENT,FOLLOW_IDENT_in_declaracion_api87); 
            	
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
        return retval;
    }
    // $ANTLR end declaracion_api

    public class principal_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start principal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:50:1: principal[int locales] : ^( 'program' tipo IDENT li= lista_instrucciones ) -> principal(nom=$IDENT.textloc=localesinstr=$li.st);
    public principal_return principal(int locales) // throws RecognitionException [1]
    {   
        principal_return retval = new principal_return();
        retval.start = input.LT(1);
    
        FkvmAST IDENT2 = null;
        lista_instrucciones_return li = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:50:24: ( ^( 'program' tipo IDENT li= lista_instrucciones ) -> principal(nom=$IDENT.textloc=localesinstr=$li.st))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:50:26: ^( 'program' tipo IDENT li= lista_instrucciones )
            {
            	Match(input,28,FOLLOW_28_in_principal99); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_principal101);
            	tipo();
            	followingStackPointer_--;

            	IDENT2 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_principal103); 
            	PushFollow(FOLLOW_lista_instrucciones_in_principal107);
            	li = lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 51:26: -> principal(nom=$IDENT.textloc=localesinstr=$li.st)
            	{
            	    retval.st = templateLib.GetInstanceOf("principal",
            	  new STAttrMap().Add("nom", IDENT2.Text).Add("loc", locales).Add("instr", li.st));
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
        return retval;
    }
    // $ANTLR end principal

    public class lista_instrucciones_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start lista_instrucciones
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:53:1: lista_instrucciones : ^( LISTAINSTRUCCIONES (i+= instruccion )* ) -> listainst(instr=$i);
    public lista_instrucciones_return lista_instrucciones() // throws RecognitionException [1]
    {   
        lista_instrucciones_return retval = new lista_instrucciones_return();
        retval.start = input.LT(1);
    
        IList list_i = null;
        RuleReturnScope i = null;
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:53:21: ( ^( LISTAINSTRUCCIONES (i+= instruccion )* ) -> listainst(instr=$i))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:53:23: ^( LISTAINSTRUCCIONES (i+= instruccion )* )
            {
            	Match(input,LISTAINSTRUCCIONES,FOLLOW_LISTAINSTRUCCIONES_in_lista_instrucciones162); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:53:44: (i+= instruccion )*
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
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:53:45: i+= instruccion
            	    		    {
            	    		    	PushFollow(FOLLOW_instruccion_in_lista_instrucciones167);
            	    		    	i = instruccion();
            	    		    	followingStackPointer_--;
            	    		    	
            	    		    	if (list_i == null) list_i = new ArrayList();
            	    		    	list_i.Add(i.Template);

            	    		    
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
            	
            	// TEMPLATE REWRITE
            	// 53:63: -> listainst(instr=$i)
            	{
            	    retval.st = templateLib.GetInstanceOf("listainst",
            	  new STAttrMap().Add("instr", list_i));
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
        return retval;
    }
    // $ANTLR end lista_instrucciones

    public class instruccion_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start instruccion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:55:1: instruccion : ( inst_decl -> {$inst_decl.st} | inst_asig -> {$inst_asig.st} | inst_if -> {$inst_if.st} | inst_while -> {$inst_while.st} | inst_return -> {$inst_return.st} | inst_expr -> {$inst_expr.st});
    public instruccion_return instruccion() // throws RecognitionException [1]
    {   
        instruccion_return retval = new instruccion_return();
        retval.start = input.LT(1);
    
        inst_decl_return inst_decl3 = null;

        inst_asig_return inst_asig4 = null;

        inst_if_return inst_if5 = null;

        inst_while_return inst_while6 = null;

        inst_return_return inst_return7 = null;

        inst_expr_return inst_expr8 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:55:13: ( inst_decl -> {$inst_decl.st} | inst_asig -> {$inst_asig.st} | inst_if -> {$inst_if.st} | inst_while -> {$inst_while.st} | inst_return -> {$inst_return.st} | inst_expr -> {$inst_expr.st})
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
            	        new NoViableAltException("55:1: instruccion : ( inst_decl -> {$inst_decl.st} | inst_asig -> {$inst_asig.st} | inst_if -> {$inst_if.st} | inst_while -> {$inst_while.st} | inst_return -> {$inst_return.st} | inst_expr -> {$inst_expr.st});", 3, 0, input);
            
            	    throw nvae_d3s0;
            }
            
            switch (alt3) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:55:15: inst_decl
                    {
                    	PushFollow(FOLLOW_inst_decl_in_instruccion187);
                    	inst_decl3 = inst_decl();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 55:25: -> {$inst_decl.st}
                    	{
                    	    retval.st = inst_decl3.st;
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:56:8: inst_asig
                    {
                    	PushFollow(FOLLOW_inst_asig_in_instruccion201);
                    	inst_asig4 = inst_asig();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 56:18: -> {$inst_asig.st}
                    	{
                    	    retval.st = inst_asig4.st;
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:57:8: inst_if
                    {
                    	PushFollow(FOLLOW_inst_if_in_instruccion214);
                    	inst_if5 = inst_if();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 57:16: -> {$inst_if.st}
                    	{
                    	    retval.st = inst_if5.st;
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:58:8: inst_while
                    {
                    	PushFollow(FOLLOW_inst_while_in_instruccion227);
                    	inst_while6 = inst_while();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 58:19: -> {$inst_while.st}
                    	{
                    	    retval.st = inst_while6.st;
                    	}
                    	

                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:59:8: inst_return
                    {
                    	PushFollow(FOLLOW_inst_return_in_instruccion240);
                    	inst_return7 = inst_return();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 59:20: -> {$inst_return.st}
                    	{
                    	    retval.st = inst_return7.st;
                    	}
                    	

                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:60:8: inst_expr
                    {
                    	PushFollow(FOLLOW_inst_expr_in_instruccion253);
                    	inst_expr8 = inst_expr();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 60:18: -> {$inst_expr.st}
                    	{
                    	    retval.st = inst_expr8.st;
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end instruccion

    public class inst_expr_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:63:1: inst_expr : expresion -> instexpr(exp=$expresion.st);
    public inst_expr_return inst_expr() // throws RecognitionException [1]
    {   
        inst_expr_return retval = new inst_expr_return();
        retval.start = input.LT(1);
    
        expresion_return expresion9 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:63:11: ( expresion -> instexpr(exp=$expresion.st))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:63:13: expresion
            {
            	PushFollow(FOLLOW_expresion_in_inst_expr271);
            	expresion9 = expresion();
            	followingStackPointer_--;

            	
            	// TEMPLATE REWRITE
            	// 63:23: -> instexpr(exp=$expresion.st)
            	{
            	    retval.st = templateLib.GetInstanceOf("instexpr",
            	  new STAttrMap().Add("exp", expresion9.st));
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
        return retval;
    }
    // $ANTLR end inst_expr

    public class inst_decl_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_decl
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:65:1: inst_decl : ^( DECLARACION tipo IDENT ) -> declaracion(tipo=$tipo.textid=$IDENT.text);
    public inst_decl_return inst_decl() // throws RecognitionException [1]
    {   
        inst_decl_return retval = new inst_decl_return();
        retval.start = input.LT(1);
    
        FkvmAST IDENT11 = null;
        tipo_return tipo10 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:65:11: ( ^( DECLARACION tipo IDENT ) -> declaracion(tipo=$tipo.textid=$IDENT.text))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:65:13: ^( DECLARACION tipo IDENT )
            {
            	Match(input,DECLARACION,FOLLOW_DECLARACION_in_inst_decl293); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_tipo_in_inst_decl295);
            	tipo10 = tipo();
            	followingStackPointer_--;

            	IDENT11 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_inst_decl297); 
            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 65:39: -> declaracion(tipo=$tipo.textid=$IDENT.text)
            	{
            	    retval.st = templateLib.GetInstanceOf("declaracion",
            	  new STAttrMap().Add("tipo", input.TokenStream.ToString(
            	  input.TreeAdaptor.GetTokenStartIndex(tipo10.start),
            	  input.TreeAdaptor.GetTokenStopIndex(tipo10.start) )).Add("id", IDENT11.Text));
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
        return retval;
    }
    // $ANTLR end inst_decl

    public class inst_asig_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_asig
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:67:1: inst_asig : ^( ASIGNACION IDENT expresion ) -> asignacion(op=opernv=$IDENT.symbol.numvarval=$expresion.st);
    public inst_asig_return inst_asig() // throws RecognitionException [1]
    {   
        inst_asig_return retval = new inst_asig_return();
        retval.start = input.LT(1);
    
        FkvmAST ASIGNACION12 = null;
        FkvmAST IDENT13 = null;
        expresion_return expresion14 = null;
        
    
        
        string oper = "";
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:71:9: ( ^( ASIGNACION IDENT expresion ) -> asignacion(op=opernv=$IDENT.symbol.numvarval=$expresion.st))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:71:11: ^( ASIGNACION IDENT expresion )
            {
            	ASIGNACION12 = (FkvmAST)input.LT(1);
            	Match(input,ASIGNACION,FOLLOW_ASIGNACION_in_inst_asig335); 
            	
            	Match(input, Token.DOWN, null); 
            	IDENT13 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_inst_asig337); 
            	PushFollow(FOLLOW_expresion_in_inst_asig339);
            	expresion14 = expresion();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	oper = traducirTipo(ASIGNACION12.expType)+"store";
            	
            	// TEMPLATE REWRITE
            	// 72:12: -> asignacion(op=opernv=$IDENT.symbol.numvarval=$expresion.st)
            	{
            	    retval.st = templateLib.GetInstanceOf("asignacion",
            	  new STAttrMap().Add("op", oper).Add("nv", IDENT13.symbol.numvar).Add("val", expresion14.st));
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
        return retval;
    }
    // $ANTLR end inst_asig

    public class inst_if_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_if
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:74:1: inst_if : ^( 'if' expresion isi= lista_instrucciones ielse= lista_instrucciones ) -> instif(cond=$expresion.stinstsi=$isi.stinstelse=$ielse.stet1=nEtiqueta++et2=nEtiqueta++);
    public inst_if_return inst_if() // throws RecognitionException [1]
    {   
        inst_if_return retval = new inst_if_return();
        retval.start = input.LT(1);
    
        lista_instrucciones_return isi = null;

        lista_instrucciones_return ielse = null;

        expresion_return expresion15 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:74:9: ( ^( 'if' expresion isi= lista_instrucciones ielse= lista_instrucciones ) -> instif(cond=$expresion.stinstsi=$isi.stinstelse=$ielse.stet1=nEtiqueta++et2=nEtiqueta++))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:74:11: ^( 'if' expresion isi= lista_instrucciones ielse= lista_instrucciones )
            {
            	Match(input,33,FOLLOW_33_in_inst_if382); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_if384);
            	expresion15 = expresion();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_if388);
            	isi = lista_instrucciones();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_if392);
            	ielse = lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 75:9: -> instif(cond=$expresion.stinstsi=$isi.stinstelse=$ielse.stet1=nEtiqueta++et2=nEtiqueta++)
            	{
            	    retval.st = templateLib.GetInstanceOf("instif",
            	  new STAttrMap().Add("cond", expresion15.st).Add("instsi", isi.st).Add("instelse", ielse.st).Add("et1", nEtiqueta++).Add("et2", nEtiqueta++));
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
        return retval;
    }
    // $ANTLR end inst_if

    public class inst_while_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_while
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:77:1: inst_while : ^( 'while' expresion li= lista_instrucciones ) -> instwhile(cond=$expresion.stinstrucciones=$li.stet1=nEtiqueta++);
    public inst_while_return inst_while() // throws RecognitionException [1]
    {   
        inst_while_return retval = new inst_while_return();
        retval.start = input.LT(1);
    
        lista_instrucciones_return li = null;

        expresion_return expresion16 = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:77:12: ( ^( 'while' expresion li= lista_instrucciones ) -> instwhile(cond=$expresion.stinstrucciones=$li.stet1=nEtiqueta++))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:77:14: ^( 'while' expresion li= lista_instrucciones )
            {
            	Match(input,35,FOLLOW_35_in_inst_while436); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_while438);
            	expresion16 = expresion();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_lista_instrucciones_in_inst_while442);
            	li = lista_instrucciones();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 78:14: -> instwhile(cond=$expresion.stinstrucciones=$li.stet1=nEtiqueta++)
            	{
            	    retval.st = templateLib.GetInstanceOf("instwhile",
            	  new STAttrMap().Add("cond", expresion16.st).Add("instrucciones", li.st).Add("et1", nEtiqueta++));
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
        return retval;
    }
    // $ANTLR end inst_while

    public class inst_return_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start inst_return
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:80:1: inst_return : ^(r= 'return' expresion ) -> return(op=operv=$expresion.st);
    public inst_return_return inst_return() // throws RecognitionException [1]
    {   
        inst_return_return retval = new inst_return_return();
        retval.start = input.LT(1);
    
        FkvmAST r = null;
        expresion_return expresion17 = null;
        
    
        
        string oper = "";
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:84:9: ( ^(r= 'return' expresion ) -> return(op=operv=$expresion.st))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:84:11: ^(r= 'return' expresion )
            {
            	r = (FkvmAST)input.LT(1);
            	Match(input,36,FOLLOW_36_in_inst_return498); 
            	
            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expresion_in_inst_return500);
            	expresion17 = expresion();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	oper = traducirTipo(r.expType)+"ret";
            	
            	// TEMPLATE REWRITE
            	// 84:76: -> return(op=operv=$expresion.st)
            	{
            	    retval.st = templateLib.GetInstanceOf("return",
            	  new STAttrMap().Add("op", oper).Add("v", expresion17.st));
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
        return retval;
    }
    // $ANTLR end inst_return

    public class tipo_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start tipo
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:86:1: tipo : ( 'int' -> {%{\"int\"}} | 'float' -> {%{\"float\"}} | 'string' -> {%{\"string\"}} | 'bool' -> {%{\"bool\"}} | 'void' -> {%{\"void\"}});
    public tipo_return tipo() // throws RecognitionException [1]
    {   
        tipo_return retval = new tipo_return();
        retval.start = input.LT(1);
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:86:6: ( 'int' -> {%{\"int\"}} | 'float' -> {%{\"float\"}} | 'string' -> {%{\"string\"}} | 'bool' -> {%{\"bool\"}} | 'void' -> {%{\"void\"}})
            int alt4 = 5;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt4 = 1;
                }
                break;
            case 38:
            	{
                alt4 = 2;
                }
                break;
            case 39:
            	{
                alt4 = 3;
                }
                break;
            case 40:
            	{
                alt4 = 4;
                }
                break;
            case 41:
            	{
                alt4 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("86:1: tipo : ( 'int' -> {%{\"int\"}} | 'float' -> {%{\"float\"}} | 'string' -> {%{\"string\"}} | 'bool' -> {%{\"bool\"}} | 'void' -> {%{\"void\"}});", 4, 0, input);
            
            	    throw nvae_d4s0;
            }
            
            switch (alt4) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:86:8: 'int'
                    {
                    	Match(input,37,FOLLOW_37_in_tipo525); 
                    	
                    	// TEMPLATE REWRITE
                    	// 86:14: -> {%{\"int\"}}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"int");
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:87:8: 'float'
                    {
                    	Match(input,38,FOLLOW_38_in_tipo538); 
                    	
                    	// TEMPLATE REWRITE
                    	// 87:16: -> {%{\"float\"}}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"float");
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:88:8: 'string'
                    {
                    	Match(input,39,FOLLOW_39_in_tipo551); 
                    	
                    	// TEMPLATE REWRITE
                    	// 88:17: -> {%{\"string\"}}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"string");
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:89:8: 'bool'
                    {
                    	Match(input,40,FOLLOW_40_in_tipo564); 
                    	
                    	// TEMPLATE REWRITE
                    	// 89:15: -> {%{\"bool\"}}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"bool");
                    	}
                    	

                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:90:8: 'void'
                    {
                    	Match(input,41,FOLLOW_41_in_tipo577); 
                    	
                    	// TEMPLATE REWRITE
                    	// 90:15: -> {%{\"void\"}}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"void");
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end tipo

    public class literal_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start literal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:93:1: literal : ( LIT_ENTERO -> lit_entero(v=$LIT_ENTERO.text) | LIT_REAL -> lit_real(v=$LIT_REAL.text) | LIT_CADENA -> lit_cadena(v=$LIT_CADENA.text) | LIT_LOGICO -> lit_logico(v=$LIT_LOGICO.text));
    public literal_return literal() // throws RecognitionException [1]
    {   
        literal_return retval = new literal_return();
        retval.start = input.LT(1);
    
        FkvmAST LIT_ENTERO18 = null;
        FkvmAST LIT_REAL19 = null;
        FkvmAST LIT_CADENA20 = null;
        FkvmAST LIT_LOGICO21 = null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:93:9: ( LIT_ENTERO -> lit_entero(v=$LIT_ENTERO.text) | LIT_REAL -> lit_real(v=$LIT_REAL.text) | LIT_CADENA -> lit_cadena(v=$LIT_CADENA.text) | LIT_LOGICO -> lit_logico(v=$LIT_LOGICO.text))
            int alt5 = 4;
            switch ( input.LA(1) ) 
            {
            case LIT_ENTERO:
            	{
                alt5 = 1;
                }
                break;
            case LIT_REAL:
            	{
                alt5 = 2;
                }
                break;
            case LIT_CADENA:
            	{
                alt5 = 3;
                }
                break;
            case LIT_LOGICO:
            	{
                alt5 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("93:1: literal : ( LIT_ENTERO -> lit_entero(v=$LIT_ENTERO.text) | LIT_REAL -> lit_real(v=$LIT_REAL.text) | LIT_CADENA -> lit_cadena(v=$LIT_CADENA.text) | LIT_LOGICO -> lit_logico(v=$LIT_LOGICO.text));", 5, 0, input);
            
            	    throw nvae_d5s0;
            }
            
            switch (alt5) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:93:11: LIT_ENTERO
                    {
                    	LIT_ENTERO18 = (FkvmAST)input.LT(1);
                    	Match(input,LIT_ENTERO,FOLLOW_LIT_ENTERO_in_literal595); 
                    	
                    	// TEMPLATE REWRITE
                    	// 93:22: -> lit_entero(v=$LIT_ENTERO.text)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("lit_entero",
                    	  new STAttrMap().Add("v", LIT_ENTERO18.Text));
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:94:11: LIT_REAL
                    {
                    	LIT_REAL19 = (FkvmAST)input.LT(1);
                    	Match(input,LIT_REAL,FOLLOW_LIT_REAL_in_literal616); 
                    	
                    	// TEMPLATE REWRITE
                    	// 94:20: -> lit_real(v=$LIT_REAL.text)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("lit_real",
                    	  new STAttrMap().Add("v", LIT_REAL19.Text));
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:95:11: LIT_CADENA
                    {
                    	LIT_CADENA20 = (FkvmAST)input.LT(1);
                    	Match(input,LIT_CADENA,FOLLOW_LIT_CADENA_in_literal637); 
                    	
                    	// TEMPLATE REWRITE
                    	// 95:22: -> lit_cadena(v=$LIT_CADENA.text)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("lit_cadena",
                    	  new STAttrMap().Add("v", LIT_CADENA20.Text));
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:96:11: LIT_LOGICO
                    {
                    	LIT_LOGICO21 = (FkvmAST)input.LT(1);
                    	Match(input,LIT_LOGICO,FOLLOW_LIT_LOGICO_in_literal658); 
                    	
                    	// TEMPLATE REWRITE
                    	// 96:22: -> lit_logico(v=$LIT_LOGICO.text)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("lit_logico",
                    	  new STAttrMap().Add("v", LIT_LOGICO21.Text));
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end literal

    public class expresion_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start expresion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:99:1: expresion : ( ^(opc= opComparacion e1= expresion e2= expresion ) -> op_comparacion(opc=opercop=$opc.ste1=$e1.ste2=$e2.stet1=nEtiqueta++) | ^(opa= opAritmetico e1= expresion e2= expresion ) -> op_aritmetico(op=opere1=$e1.ste2=$e2.st) | ^( MENOSUNARIO e1= expresion ) -> opmenosunario(e1=$e1.st) | ^( '!' e1= expresion ) -> opno(e1=$e1.st) | IDENT -> ident(op=opernv=$IDENT.symbol.numvar) | literal -> {$literal.st} | llamada -> {$llamada.st});
    public expresion_return expresion() // throws RecognitionException [1]
    {   
        expresion_return retval = new expresion_return();
        retval.start = input.LT(1);
    
        FkvmAST IDENT22 = null;
        opComparacion_return opc = null;

        expresion_return e1 = null;

        expresion_return e2 = null;

        opAritmetico_return opa = null;

        literal_return literal23 = null;

        llamada_return llamada24 = null;
        
    
        
        string oper = "";
        string operc = "";
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:104:11: ( ^(opc= opComparacion e1= expresion e2= expresion ) -> op_comparacion(opc=opercop=$opc.ste1=$e1.ste2=$e2.stet1=nEtiqueta++) | ^(opa= opAritmetico e1= expresion e2= expresion ) -> op_aritmetico(op=opere1=$e1.ste2=$e2.st) | ^( MENOSUNARIO e1= expresion ) -> opmenosunario(e1=$e1.st) | ^( '!' e1= expresion ) -> opno(e1=$e1.st) | IDENT -> ident(op=opernv=$IDENT.symbol.numvar) | literal -> {$literal.st} | llamada -> {$llamada.st})
            int alt6 = 7;
            switch ( input.LA(1) ) 
            {
            case 44:
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
            	{
                alt6 = 1;
                }
                break;
            case 50:
            case 51:
            case 52:
            case 53:
            	{
                alt6 = 2;
                }
                break;
            case MENOSUNARIO:
            	{
                alt6 = 3;
                }
                break;
            case 54:
            	{
                alt6 = 4;
                }
                break;
            case IDENT:
            	{
                alt6 = 5;
                }
                break;
            case LIT_ENTERO:
            case LIT_REAL:
            case LIT_CADENA:
            case LIT_LOGICO:
            	{
                alt6 = 6;
                }
                break;
            case LLAMADA:
            	{
                alt6 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("99:1: expresion : ( ^(opc= opComparacion e1= expresion e2= expresion ) -> op_comparacion(opc=opercop=$opc.ste1=$e1.ste2=$e2.stet1=nEtiqueta++) | ^(opa= opAritmetico e1= expresion e2= expresion ) -> op_aritmetico(op=opere1=$e1.ste2=$e2.st) | ^( MENOSUNARIO e1= expresion ) -> opmenosunario(e1=$e1.st) | ^( '!' e1= expresion ) -> opno(e1=$e1.st) | IDENT -> ident(op=opernv=$IDENT.symbol.numvar) | literal -> {$literal.st} | llamada -> {$llamada.st});", 6, 0, input);
            
            	    throw nvae_d6s0;
            }
            
            switch (alt6) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:104:13: ^(opc= opComparacion e1= expresion e2= expresion )
                    {
                    	PushFollow(FOLLOW_opComparacion_in_expresion710);
                    	opc = opComparacion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion714);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	PushFollow(FOLLOW_expresion_in_expresion718);
                    	e2 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	operc = operadorComparacion(opc.opSecType);
                    	
                    	// TEMPLATE REWRITE
                    	// 105:14: -> op_comparacion(opc=opercop=$opc.ste1=$e1.ste2=$e2.stet1=nEtiqueta++)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("op_comparacion",
                    	  new STAttrMap().Add("opc", operc).Add("op", opc.st).Add("e1", e1.st).Add("e2", e2.st).Add("et1", nEtiqueta++));
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:106:13: ^(opa= opAritmetico e1= expresion e2= expresion )
                    {
                    	PushFollow(FOLLOW_opAritmetico_in_expresion780);
                    	opa = opAritmetico();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion784);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	PushFollow(FOLLOW_expresion_in_expresion788);
                    	e2 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	oper = traducirTipo(opa.opType)+opa.st.ToString();
                    	
                    	// TEMPLATE REWRITE
                    	// 107:14: -> op_aritmetico(op=opere1=$e1.ste2=$e2.st)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("op_aritmetico",
                    	  new STAttrMap().Add("op", oper).Add("e1", e1.st).Add("e2", e2.st));
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:108:13: ^( MENOSUNARIO e1= expresion )
                    {
                    	Match(input,MENOSUNARIO,FOLLOW_MENOSUNARIO_in_expresion839); 
                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion843);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	// TEMPLATE REWRITE
                    	// 108:41: -> opmenosunario(e1=$e1.st)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("opmenosunario",
                    	  new STAttrMap().Add("e1", e1.st));
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:109:13: ^( '!' e1= expresion )
                    {
                    	Match(input,54,FOLLOW_54_in_expresion868); 
                    	
                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expresion_in_expresion872);
                    	e1 = expresion();
                    	followingStackPointer_--;

                    	
                    	Match(input, Token.UP, null); 
                    	
                    	// TEMPLATE REWRITE
                    	// 109:33: -> opno(e1=$e1.st)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("opno",
                    	  new STAttrMap().Add("e1", e1.st));
                    	}
                    	

                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:110:13: IDENT
                    {
                    	IDENT22 = (FkvmAST)input.LT(1);
                    	Match(input,IDENT,FOLLOW_IDENT_in_expresion896); 
                    	oper = traducirTipo(IDENT22.expType)+"load";
                    	
                    	// TEMPLATE REWRITE
                    	// 110:65: -> ident(op=opernv=$IDENT.symbol.numvar)
                    	{
                    	    retval.st = templateLib.GetInstanceOf("ident",
                    	  new STAttrMap().Add("op", oper).Add("nv", IDENT22.symbol.numvar));
                    	}
                    	

                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:111:13: literal
                    {
                    	PushFollow(FOLLOW_literal_in_expresion926);
                    	literal23 = literal();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 111:21: -> {$literal.st}
                    	{
                    	    retval.st = literal23.st;
                    	}
                    	

                    
                    }
                    break;
                case 7 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:112:13: llamada
                    {
                    	PushFollow(FOLLOW_llamada_in_expresion944);
                    	llamada24 = llamada();
                    	followingStackPointer_--;

                    	
                    	// TEMPLATE REWRITE
                    	// 112:21: -> {$llamada.st}
                    	{
                    	    retval.st = llamada24.st;
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end expresion

    public class llamada_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start llamada
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:115:1: llamada : ^( LLAMADA IDENT le= lista_expr ) -> llamada(id=$IDENT.textlp=$le.st);
    public llamada_return llamada() // throws RecognitionException [1]
    {   
        llamada_return retval = new llamada_return();
        retval.start = input.LT(1);
    
        FkvmAST IDENT25 = null;
        lista_expr_return le = null;
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:115:9: ( ^( LLAMADA IDENT le= lista_expr ) -> llamada(id=$IDENT.textlp=$le.st))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:115:11: ^( LLAMADA IDENT le= lista_expr )
            {
            	Match(input,LLAMADA,FOLLOW_LLAMADA_in_llamada978); 
            	
            	Match(input, Token.DOWN, null); 
            	IDENT25 = (FkvmAST)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_llamada980); 
            	PushFollow(FOLLOW_lista_expr_in_llamada984);
            	le = lista_expr();
            	followingStackPointer_--;

            	
            	Match(input, Token.UP, null); 
            	
            	// TEMPLATE REWRITE
            	// 115:42: -> llamada(id=$IDENT.textlp=$le.st)
            	{
            	    retval.st = templateLib.GetInstanceOf("llamada",
            	  new STAttrMap().Add("id", IDENT25.Text).Add("lp", le.st));
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
        return retval;
    }
    // $ANTLR end llamada

    public class lista_expr_return : TreeRuleReturnScope 
    {
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start lista_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:117:1: lista_expr : ^( LISTAEXPRESIONES (exp+= expresion )* ) -> listaparams(lp=$exp);
    public lista_expr_return lista_expr() // throws RecognitionException [1]
    {   
        lista_expr_return retval = new lista_expr_return();
        retval.start = input.LT(1);
    
        IList list_exp = null;
        RuleReturnScope exp = null;
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:117:12: ( ^( LISTAEXPRESIONES (exp+= expresion )* ) -> listaparams(lp=$exp))
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:117:14: ^( LISTAEXPRESIONES (exp+= expresion )* )
            {
            	Match(input,LISTAEXPRESIONES,FOLLOW_LISTAEXPRESIONES_in_lista_expr1009); 
            	
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:117:36: (exp+= expresion )*
            	    do 
            	    {
            	        int alt7 = 2;
            	        int LA7_0 = input.LA(1);
            	        
            	        if ( (LA7_0 == MENOSUNARIO || LA7_0 == LLAMADA || (LA7_0 >= IDENT && LA7_0 <= LIT_LOGICO) || (LA7_0 >= 44 && LA7_0 <= 54)) )
            	        {
            	            alt7 = 1;
            	        }
            	        
            	    
            	        switch (alt7) 
            	    	{
            	    		case 1 :
            	    		    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:117:36: exp+= expresion
            	    		    {
            	    		    	PushFollow(FOLLOW_expresion_in_lista_expr1013);
            	    		    	exp = expresion();
            	    		    	followingStackPointer_--;
            	    		    	
            	    		    	if (list_exp == null) list_exp = new ArrayList();
            	    		    	list_exp.Add(exp.Template);

            	    		    
            	    		    }
            	    		    break;
            	    
            	    		default:
            	    		    goto loop7;
            	        }
            	    } while (true);
            	    
            	    loop7:
            	    	;	// Stops C# compiler whinging that label 'loop7' has no statements

            	
            	    Match(input, Token.UP, null); 
            	}
            	
            	// TEMPLATE REWRITE
            	// 117:50: -> listaparams(lp=$exp)
            	{
            	    retval.st = templateLib.GetInstanceOf("listaparams",
            	  new STAttrMap().Add("lp", list_exp));
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
        return retval;
    }
    // $ANTLR end lista_expr

    public class opAritmetico_return : TreeRuleReturnScope 
    {
        public string opType;
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start opAritmetico
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:119:1: opAritmetico returns [string opType] : (op= '+' -> {%{\"add\"}; $opType=$op.expType;} | op= '-' -> {%{\"sub\"}; $opType=$op.expType;} | op= '*' -> {%{\"mul\"}; $opType=$op.expType;} | op= '/' -> {%{\"div\"}; $opType=$op.expType;});
    public opAritmetico_return opAritmetico() // throws RecognitionException [1]
    {   
        opAritmetico_return retval = new opAritmetico_return();
        retval.start = input.LT(1);
    
        FkvmAST op = null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:120:11: (op= '+' -> {%{\"add\"}; $opType=$op.expType;} | op= '-' -> {%{\"sub\"}; $opType=$op.expType;} | op= '*' -> {%{\"mul\"}; $opType=$op.expType;} | op= '/' -> {%{\"div\"}; $opType=$op.expType;})
            int alt8 = 4;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt8 = 1;
                }
                break;
            case 51:
            	{
                alt8 = 2;
                }
                break;
            case 52:
            	{
                alt8 = 3;
                }
                break;
            case 53:
            	{
                alt8 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("119:1: opAritmetico returns [string opType] : (op= '+' -> {%{\"add\"}; $opType=$op.expType;} | op= '-' -> {%{\"sub\"}; $opType=$op.expType;} | op= '*' -> {%{\"mul\"}; $opType=$op.expType;} | op= '/' -> {%{\"div\"}; $opType=$op.expType;});", 8, 0, input);
            
            	    throw nvae_d8s0;
            }
            
            switch (alt8) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:120:13: op= '+'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,50,FOLLOW_50_in_opAritmetico1049); 
                    	
                    	// TEMPLATE REWRITE
                    	// 120:20: -> {%{\"add\"}; $opType=$op.expType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"add"); retval.opType = op.expType;;
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:121:13: op= '-'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,51,FOLLOW_51_in_opAritmetico1069); 
                    	
                    	// TEMPLATE REWRITE
                    	// 121:20: -> {%{\"sub\"}; $opType=$op.expType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"sub"); retval.opType = op.expType;;
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:122:13: op= '*'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,52,FOLLOW_52_in_opAritmetico1089); 
                    	
                    	// TEMPLATE REWRITE
                    	// 122:20: -> {%{\"mul\"}; $opType=$op.expType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"mul"); retval.opType = op.expType;;
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:123:13: op= '/'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,53,FOLLOW_53_in_opAritmetico1109); 
                    	
                    	// TEMPLATE REWRITE
                    	// 123:20: -> {%{\"div\"}; $opType=$op.expType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"div"); retval.opType = op.expType;;
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end opAritmetico

    public class opComparacion_return : TreeRuleReturnScope 
    {
        public string opSecType;
        public StringTemplate st;
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };
    
    // $ANTLR start opComparacion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:126:1: opComparacion returns [string opSecType] : (op= '==' -> {%{\"ifeq\"}; $opSecType=$op.expSecType;} | op= '!=' -> {%{\"ifne\"}; $opSecType=$op.expSecType;} | op= '>=' -> {%{\"ifge\"}; $opSecType=$op.expSecType;} | op= '<=' -> {%{\"ifle\"}; $opSecType=$op.expSecType;} | op= '>' -> {%{\"ifgt\"}; $opSecType=$op.expSecType;} | op= '<' -> {%{\"iflt\"}; $opSecType=$op.expSecType;});
    public opComparacion_return opComparacion() // throws RecognitionException [1]
    {   
        opComparacion_return retval = new opComparacion_return();
        retval.start = input.LT(1);
    
        FkvmAST op = null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:127:11: (op= '==' -> {%{\"ifeq\"}; $opSecType=$op.expSecType;} | op= '!=' -> {%{\"ifne\"}; $opSecType=$op.expSecType;} | op= '>=' -> {%{\"ifge\"}; $opSecType=$op.expSecType;} | op= '<=' -> {%{\"ifle\"}; $opSecType=$op.expSecType;} | op= '>' -> {%{\"ifgt\"}; $opSecType=$op.expSecType;} | op= '<' -> {%{\"iflt\"}; $opSecType=$op.expSecType;})
            int alt9 = 6;
            switch ( input.LA(1) ) 
            {
            case 44:
            	{
                alt9 = 1;
                }
                break;
            case 45:
            	{
                alt9 = 2;
                }
                break;
            case 48:
            	{
                alt9 = 3;
                }
                break;
            case 49:
            	{
                alt9 = 4;
                }
                break;
            case 46:
            	{
                alt9 = 5;
                }
                break;
            case 47:
            	{
                alt9 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("126:1: opComparacion returns [string opSecType] : (op= '==' -> {%{\"ifeq\"}; $opSecType=$op.expSecType;} | op= '!=' -> {%{\"ifne\"}; $opSecType=$op.expSecType;} | op= '>=' -> {%{\"ifge\"}; $opSecType=$op.expSecType;} | op= '<=' -> {%{\"ifle\"}; $opSecType=$op.expSecType;} | op= '>' -> {%{\"ifgt\"}; $opSecType=$op.expSecType;} | op= '<' -> {%{\"iflt\"}; $opSecType=$op.expSecType;});", 9, 0, input);
            
            	    throw nvae_d9s0;
            }
            
            switch (alt9) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:127:13: op= '=='
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,44,FOLLOW_44_in_opComparacion1148); 
                    	
                    	// TEMPLATE REWRITE
                    	// 127:21: -> {%{\"ifeq\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"ifeq"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:128:13: op= '!='
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,45,FOLLOW_45_in_opComparacion1168); 
                    	
                    	// TEMPLATE REWRITE
                    	// 128:21: -> {%{\"ifne\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"ifne"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:129:13: op= '>='
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,48,FOLLOW_48_in_opComparacion1188); 
                    	
                    	// TEMPLATE REWRITE
                    	// 129:21: -> {%{\"ifge\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"ifge"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:130:13: op= '<='
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,49,FOLLOW_49_in_opComparacion1208); 
                    	
                    	// TEMPLATE REWRITE
                    	// 130:21: -> {%{\"ifle\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"ifle"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:131:13: op= '>'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,46,FOLLOW_46_in_opComparacion1228); 
                    	
                    	// TEMPLATE REWRITE
                    	// 131:20: -> {%{\"ifgt\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"ifgt"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVMGen.g:132:13: op= '<'
                    {
                    	op = (FkvmAST)input.LT(1);
                    	Match(input,47,FOLLOW_47_in_opComparacion1248); 
                    	
                    	// TEMPLATE REWRITE
                    	// 132:20: -> {%{\"iflt\"}; $opSecType=$op.expSecType;}
                    	{
                    	    retval.st = new StringTemplate(templateLib,"iflt"); retval.opSecType = op.expSecType;;
                    	}
                    	

                    
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
        return retval;
    }
    // $ANTLR end opComparacion


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_PROGRAMA_in_programa49 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_declaraciones_api_in_programa51 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_principal_in_programa53 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTADECLARACIONESAPI_in_declaraciones_api69 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_declaracion_api_in_declaraciones_api71 = new BitSet(new ulong[]{0x0000000000000108UL});
    public static readonly BitSet FOLLOW_DECLARACIONAPI_in_declaracion_api83 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_declaracion_api85 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_declaracion_api87 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_28_in_principal99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_principal101 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_principal103 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_principal107 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTAINSTRUCCIONES_in_lista_instrucciones162 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_instruccion_in_lista_instrucciones167 = new BitSet(new ulong[]{0x007FF01A000F9628UL});
    public static readonly BitSet FOLLOW_inst_decl_in_instruccion187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_asig_in_instruccion201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_if_in_instruccion214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_while_in_instruccion227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_return_in_instruccion240 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_expr_in_instruccion253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_expr271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECLARACION_in_inst_decl293 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tipo_in_inst_decl295 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_decl297 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASIGNACION_in_inst_asig335 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_asig337 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_asig339 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_33_in_inst_if382 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_if384 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_if388 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_if392 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_35_in_inst_while436 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_while438 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_while442 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_36_in_inst_return498 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_return500 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_37_in_tipo525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tipo538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tipo551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tipo564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tipo577 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_ENTERO_in_literal595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_REAL_in_literal616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_CADENA_in_literal637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIT_LOGICO_in_literal658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opComparacion_in_expresion710 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion714 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion718 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_opAritmetico_in_expresion780 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion784 = new BitSet(new ulong[]{0x007FF000000F9400UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion788 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MENOSUNARIO_in_expresion839 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion843 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_54_in_expresion868 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_expresion872 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IDENT_in_expresion896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_expresion926 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_llamada_in_expresion944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LLAMADA_in_llamada978 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENT_in_llamada980 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_lista_expr_in_llamada984 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LISTAEXPRESIONES_in_lista_expr1009 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expresion_in_lista_expr1013 = new BitSet(new ulong[]{0x007FF000000F9408UL});
    public static readonly BitSet FOLLOW_50_in_opAritmetico1049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_opAritmetico1069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_opAritmetico1089 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_opAritmetico1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_opComparacion1148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_opComparacion1168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_opComparacion1188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_opComparacion1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_opComparacion1228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_opComparacion1248 = new BitSet(new ulong[]{0x0000000000000002UL});

}
