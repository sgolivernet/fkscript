// $ANTLR 3.0.1 D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g 2007-09-09 13:38:55

using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;




using Antlr.Runtime.Tree;

public class FKVMParser : Parser 
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
    public const int LETRA = 20;
    public const int LIT_LOGICO = 19;
    
    
        public FKVMParser(ITokenStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();
    
    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set { this.adaptor = value; }
    }

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g"; }
	}

    
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


    public class programa_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start programa
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:61:1: programa : declaraciones_api principal -> ^( PROGRAMA declaraciones_api principal ) ;
    public programa_return programa() // throws RecognitionException [1]
    {   
        programa_return retval = new programa_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        declaraciones_api_return declaraciones_api1 = null;

        principal_return principal2 = null;
        
        
        RewriteRuleSubtreeStream stream_principal = new RewriteRuleSubtreeStream(adaptor,"rule principal");
        RewriteRuleSubtreeStream stream_declaraciones_api = new RewriteRuleSubtreeStream(adaptor,"rule declaraciones_api");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:61:10: ( declaraciones_api principal -> ^( PROGRAMA declaraciones_api principal ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:61:12: declaraciones_api principal
            {
            	PushFollow(FOLLOW_declaraciones_api_in_programa110);
            	declaraciones_api1 = declaraciones_api();
            	followingStackPointer_--;
            	
            	stream_declaraciones_api.Add(declaraciones_api1.Tree);
            	PushFollow(FOLLOW_principal_in_programa112);
            	principal2 = principal();
            	followingStackPointer_--;
            	
            	stream_principal.Add(principal2.Tree);
            	
            	// AST REWRITE
            	// elements:          principal, declaraciones_api
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 61:40: -> ^( PROGRAMA declaraciones_api principal )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:61:43: ^( PROGRAMA declaraciones_api principal )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(PROGRAMA, "PROGRAMA"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_declaraciones_api.Next());
            	    adaptor.AddChild(root_1, stream_principal.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class declaraciones_api_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start declaraciones_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:1: declaraciones_api : (lista+= declaracion_api )* -> ^( LISTADECLARACIONESAPI ( $lista)* ) ;
    public declaraciones_api_return declaraciones_api() // throws RecognitionException [1]
    {   
        declaraciones_api_return retval = new declaraciones_api_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IList list_lista = null;
        RuleReturnScope lista = null;
        RewriteRuleSubtreeStream stream_declaracion_api = new RewriteRuleSubtreeStream(adaptor,"rule declaracion_api");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:19: ( (lista+= declaracion_api )* -> ^( LISTADECLARACIONESAPI ( $lista)* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:21: (lista+= declaracion_api )*
            {
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:21: (lista+= declaracion_api )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == 24) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:22: lista+= declaracion_api
            			    {
            			    	PushFollow(FOLLOW_declaracion_api_in_declaraciones_api134);
            			    	lista = declaracion_api();
            			    	followingStackPointer_--;
            			    	
            			    	stream_declaracion_api.Add(lista.Tree);
            			    	if (list_lista == null) list_lista = new ArrayList();
            			    	list_lista.Add(lista);

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop1;
            	    }
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            	
            	// AST REWRITE
            	// elements:          lista
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  lista
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	RewriteRuleSubtreeStream stream_lista = new RewriteRuleSubtreeStream(adaptor, "token lista", list_lista);
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 63:47: -> ^( LISTADECLARACIONESAPI ( $lista)* )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:50: ^( LISTADECLARACIONESAPI ( $lista)* )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTADECLARACIONESAPI, "LISTADECLARACIONESAPI"), root_1);
            	    
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:63:74: ( $lista)*
            	    while ( stream_lista.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, ((ParserRuleReturnScope)stream_lista.Next()).Tree);
            	    
            	    }
            	    stream_lista.Reset();
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class declaracion_api_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start declaracion_api
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:65:1: declaracion_api : 'api' tipo IDENT '(' lista_decl ')' ';' -> ^( DECLARACIONAPI tipo IDENT ) ;
    public declaracion_api_return declaracion_api() // throws RecognitionException [1]
    {   
        declaracion_api_return retval = new declaracion_api_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal3 = null;
        IToken IDENT5 = null;
        IToken char_literal6 = null;
        IToken char_literal8 = null;
        IToken char_literal9 = null;
        tipo_return tipo4 = null;

        lista_decl_return lista_decl7 = null;
        
        
        FkvmAST string_literal3_tree=null;
        FkvmAST IDENT5_tree=null;
        FkvmAST char_literal6_tree=null;
        FkvmAST char_literal8_tree=null;
        FkvmAST char_literal9_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_24 = new RewriteRuleTokenStream(adaptor,"token 24");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_tipo = new RewriteRuleSubtreeStream(adaptor,"rule tipo");
        RewriteRuleSubtreeStream stream_lista_decl = new RewriteRuleSubtreeStream(adaptor,"rule lista_decl");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:65:17: ( 'api' tipo IDENT '(' lista_decl ')' ';' -> ^( DECLARACIONAPI tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:65:19: 'api' tipo IDENT '(' lista_decl ')' ';'
            {
            	string_literal3 = (IToken)input.LT(1);
            	Match(input,24,FOLLOW_24_in_declaracion_api155); 
            	stream_24.Add(string_literal3);

            	PushFollow(FOLLOW_tipo_in_declaracion_api157);
            	tipo4 = tipo();
            	followingStackPointer_--;
            	
            	stream_tipo.Add(tipo4.Tree);
            	IDENT5 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_declaracion_api159); 
            	stream_IDENT.Add(IDENT5);

            	char_literal6 = (IToken)input.LT(1);
            	Match(input,25,FOLLOW_25_in_declaracion_api161); 
            	stream_25.Add(char_literal6);

            	PushFollow(FOLLOW_lista_decl_in_declaracion_api163);
            	lista_decl7 = lista_decl();
            	followingStackPointer_--;
            	
            	stream_lista_decl.Add(lista_decl7.Tree);
            	char_literal8 = (IToken)input.LT(1);
            	Match(input,26,FOLLOW_26_in_declaracion_api165); 
            	stream_26.Add(char_literal8);

            	char_literal9 = (IToken)input.LT(1);
            	Match(input,27,FOLLOW_27_in_declaracion_api167); 
            	stream_27.Add(char_literal9);

            	
            	     if(!symtable.ContainsKey(IDENT5.Text))
            	     {
            	           symtable.Add(IDENT5.Text, new Symbol(input.ToString(tipo4.start,tipo4.stop), -1));
            	     }
            	     
            	
            	// AST REWRITE
            	// elements:          tipo, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 70:8: -> ^( DECLARACIONAPI tipo IDENT )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:70:11: ^( DECLARACIONAPI tipo IDENT )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(DECLARACIONAPI, "DECLARACIONAPI"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_tipo.Next());
            	    adaptor.AddChild(root_1, stream_IDENT.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class principal_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start principal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:72:1: principal : 'program' tipo IDENT '{' lista_instrucciones '}' ;
    public principal_return principal() // throws RecognitionException [1]
    {   
        principal_return retval = new principal_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal10 = null;
        IToken IDENT12 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        tipo_return tipo11 = null;

        lista_instrucciones_return lista_instrucciones14 = null;
        
        
        FkvmAST string_literal10_tree=null;
        FkvmAST IDENT12_tree=null;
        FkvmAST char_literal13_tree=null;
        FkvmAST char_literal15_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:72:11: ( 'program' tipo IDENT '{' lista_instrucciones '}' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:72:13: 'program' tipo IDENT '{' lista_instrucciones '}'
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	string_literal10 = (IToken)input.LT(1);
            	Match(input,28,FOLLOW_28_in_principal188); 
            	string_literal10_tree = (FkvmAST)adaptor.Create(string_literal10);
            	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal10_tree, root_0);

            	PushFollow(FOLLOW_tipo_in_principal191);
            	tipo11 = tipo();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, tipo11.Tree);
            	IDENT12 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_principal193); 
            	IDENT12_tree = (FkvmAST)adaptor.Create(IDENT12);
            	adaptor.AddChild(root_0, IDENT12_tree);

            	char_literal13 = (IToken)input.LT(1);
            	Match(input,29,FOLLOW_29_in_principal195); 
            	PushFollow(FOLLOW_lista_instrucciones_in_principal198);
            	lista_instrucciones14 = lista_instrucciones();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, lista_instrucciones14.Tree);
            	char_literal15 = (IToken)input.LT(1);
            	Match(input,30,FOLLOW_30_in_principal200); 
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class lista_instrucciones_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start lista_instrucciones
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:1: lista_instrucciones : (lista+= instruccion )* -> ^( LISTAINSTRUCCIONES ( $lista)* ) ;
    public lista_instrucciones_return lista_instrucciones() // throws RecognitionException [1]
    {   
        lista_instrucciones_return retval = new lista_instrucciones_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IList list_lista = null;
        RuleReturnScope lista = null;
        RewriteRuleSubtreeStream stream_instruccion = new RewriteRuleSubtreeStream(adaptor,"rule instruccion");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:21: ( (lista+= instruccion )* -> ^( LISTAINSTRUCCIONES ( $lista)* ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:23: (lista+= instruccion )*
            {
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:23: (lista+= instruccion )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( ((LA2_0 >= IDENT && LA2_0 <= LIT_LOGICO) || LA2_0 == 25 || LA2_0 == 33 || (LA2_0 >= 35 && LA2_0 <= 41) || (LA2_0 >= 50 && LA2_0 <= 51) || LA2_0 == 54) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:24: lista+= instruccion
            			    {
            			    	PushFollow(FOLLOW_instruccion_in_lista_instrucciones213);
            			    	lista = instruccion();
            			    	followingStackPointer_--;
            			    	
            			    	stream_instruccion.Add(lista.Tree);
            			    	if (list_lista == null) list_lista = new ArrayList();
            			    	list_lista.Add(lista);

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop2;
            	    }
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements

            	
            	// AST REWRITE
            	// elements:          lista
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  lista
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	RewriteRuleSubtreeStream stream_lista = new RewriteRuleSubtreeStream(adaptor, "token lista", list_lista);
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 74:45: -> ^( LISTAINSTRUCCIONES ( $lista)* )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:48: ^( LISTAINSTRUCCIONES ( $lista)* )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAINSTRUCCIONES, "LISTAINSTRUCCIONES"), root_1);
            	    
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:74:69: ( $lista)*
            	    while ( stream_lista.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, ((ParserRuleReturnScope)stream_lista.Next()).Tree);
            	    
            	    }
            	    stream_lista.Reset();
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class instruccion_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start instruccion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:76:1: instruccion : ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr );
    public instruccion_return instruccion() // throws RecognitionException [1]
    {   
        instruccion_return retval = new instruccion_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        inst_decl_return inst_decl16 = null;

        inst_asig_return inst_asig17 = null;

        inst_if_return inst_if18 = null;

        inst_while_return inst_while19 = null;

        inst_return_return inst_return20 = null;

        inst_expr_return inst_expr21 = null;
        
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:76:13: ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr )
            int alt3 = 6;
            switch ( input.LA(1) ) 
            {
            case 37:
            case 38:
            case 39:
            case 40:
            case 41:
            	{
                alt3 = 1;
                }
                break;
            case IDENT:
            	{
                int LA3_2 = input.LA(2);
                
                if ( (LA3_2 == 32) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_2 == 25 || LA3_2 == 27 || (LA3_2 >= 42 && LA3_2 <= 53)) )
                {
                    alt3 = 6;
                }
                else 
                {
                    NoViableAltException nvae_d3s2 =
                        new NoViableAltException("76:1: instruccion : ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr );", 3, 2, input);
                
                    throw nvae_d3s2;
                }
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
            case LIT_ENTERO:
            case LIT_REAL:
            case LIT_CADENA:
            case LIT_LOGICO:
            case 25:
            case 50:
            case 51:
            case 54:
            	{
                alt3 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("76:1: instruccion : ( inst_decl | inst_asig | inst_if | inst_while | inst_return | inst_expr );", 3, 0, input);
            
            	    throw nvae_d3s0;
            }
            
            switch (alt3) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:76:15: inst_decl
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_decl_in_instruccion233);
                    	inst_decl16 = inst_decl();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_decl16.Tree);
                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:77:6: inst_asig
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_asig_in_instruccion240);
                    	inst_asig17 = inst_asig();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_asig17.Tree);
                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:78:6: inst_if
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_if_in_instruccion248);
                    	inst_if18 = inst_if();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_if18.Tree);
                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:79:6: inst_while
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_while_in_instruccion256);
                    	inst_while19 = inst_while();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_while19.Tree);
                    
                    }
                    break;
                case 5 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:80:6: inst_return
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_return_in_instruccion264);
                    	inst_return20 = inst_return();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_return20.Tree);
                    
                    }
                    break;
                case 6 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:81:6: inst_expr
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_inst_expr_in_instruccion272);
                    	inst_expr21 = inst_expr();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, inst_expr21.Tree);
                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class inst_expr_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:83:1: inst_expr : expresion ';' ;
    public inst_expr_return inst_expr() // throws RecognitionException [1]
    {   
        inst_expr_return retval = new inst_expr_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal23 = null;
        expresion_return expresion22 = null;
        
        
        FkvmAST char_literal23_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:83:11: ( expresion ';' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:83:13: expresion ';'
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expresion_in_inst_expr283);
            	expresion22 = expresion();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expresion22.Tree);
            	char_literal23 = (IToken)input.LT(1);
            	Match(input,27,FOLLOW_27_in_inst_expr285); 
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class inst_decl_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_decl
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:85:1: inst_decl : tipo IDENT ';' -> ^( DECLARACION tipo IDENT ) ;
    public inst_decl_return inst_decl() // throws RecognitionException [1]
    {   
        inst_decl_return retval = new inst_decl_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken IDENT25 = null;
        IToken char_literal26 = null;
        tipo_return tipo24 = null;
        
        
        FkvmAST IDENT25_tree=null;
        FkvmAST char_literal26_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_tipo = new RewriteRuleSubtreeStream(adaptor,"rule tipo");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:85:11: ( tipo IDENT ';' -> ^( DECLARACION tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:85:13: tipo IDENT ';'
            {
            	PushFollow(FOLLOW_tipo_in_inst_decl295);
            	tipo24 = tipo();
            	followingStackPointer_--;
            	
            	stream_tipo.Add(tipo24.Tree);
            	IDENT25 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_inst_decl297); 
            	stream_IDENT.Add(IDENT25);

            	char_literal26 = (IToken)input.LT(1);
            	Match(input,27,FOLLOW_27_in_inst_decl299); 
            	stream_27.Add(char_literal26);

            	
            	     if(!symtable.ContainsKey(IDENT25.Text))
            	     {
            	           symtable.Add(IDENT25.Text, new Symbol(input.ToString(tipo24.start,tipo24.stop), numVars++));
            	     }
            	     
            	
            	// AST REWRITE
            	// elements:          tipo, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 90:8: -> ^( DECLARACION tipo IDENT )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:90:11: ^( DECLARACION tipo IDENT )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(DECLARACION, "DECLARACION"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_tipo.Next());
            	    adaptor.AddChild(root_1, stream_IDENT.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class lista_decl_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start lista_decl
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:1: lista_decl : (ld+= decl ( ',' ld+= decl )* -> ^( LISTAPARAMETROS ( $ld)* ) | -> ^( LISTAPARAMETROS ) );
    public lista_decl_return lista_decl() // throws RecognitionException [1]
    {   
        lista_decl_return retval = new lista_decl_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal27 = null;
        IList list_ld = null;
        RuleReturnScope ld = null;
        FkvmAST char_literal27_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_decl = new RewriteRuleSubtreeStream(adaptor,"rule decl");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:12: (ld+= decl ( ',' ld+= decl )* -> ^( LISTAPARAMETROS ( $ld)* ) | -> ^( LISTAPARAMETROS ) )
            int alt5 = 2;
            int LA5_0 = input.LA(1);
            
            if ( ((LA5_0 >= 37 && LA5_0 <= 41)) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 26) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("92:1: lista_decl : (ld+= decl ( ',' ld+= decl )* -> ^( LISTAPARAMETROS ( $ld)* ) | -> ^( LISTAPARAMETROS ) );", 5, 0, input);
            
                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:14: ld+= decl ( ',' ld+= decl )*
                    {
                    	PushFollow(FOLLOW_decl_in_lista_decl326);
                    	ld = decl();
                    	followingStackPointer_--;
                    	
                    	stream_decl.Add(ld.Tree);
                    	if (list_ld == null) list_ld = new ArrayList();
                    	list_ld.Add(ld);

                    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:23: ( ',' ld+= decl )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);
                    	    
                    	    if ( (LA4_0 == 31) )
                    	    {
                    	        alt4 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:24: ',' ld+= decl
                    			    {
                    			    	char_literal27 = (IToken)input.LT(1);
                    			    	Match(input,31,FOLLOW_31_in_lista_decl329); 
                    			    	stream_31.Add(char_literal27);

                    			    	PushFollow(FOLLOW_decl_in_lista_decl333);
                    			    	ld = decl();
                    			    	followingStackPointer_--;
                    			    	
                    			    	stream_decl.Add(ld.Tree);
                    			    	if (list_ld == null) list_ld = new ArrayList();
                    			    	list_ld.Add(ld);

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);
                    	
                    	loop4:
                    		;	// Stops C# compiler whinging that label 'loop4' has no statements

                    	
                    	// AST REWRITE
                    	// elements:          ld
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  ld
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	RewriteRuleSubtreeStream stream_ld = new RewriteRuleSubtreeStream(adaptor, "token ld", list_ld);
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 92:39: -> ^( LISTAPARAMETROS ( $ld)* )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:42: ^( LISTAPARAMETROS ( $ld)* )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAPARAMETROS, "LISTAPARAMETROS"), root_1);
                    	    
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:92:60: ( $ld)*
                    	    while ( stream_ld.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, ((ParserRuleReturnScope)stream_ld.Next()).Tree);
                    	    
                    	    }
                    	    stream_ld.Reset();
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:93:14: 
                    {
                    	
                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 93:14: -> ^( LISTAPARAMETROS )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:93:17: ^( LISTAPARAMETROS )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAPARAMETROS, "LISTAPARAMETROS"), root_1);
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end lista_decl

    public class decl_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start decl
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:96:1: decl : tipo IDENT -> ^( DECLARACIONPARAM tipo IDENT ) ;
    public decl_return decl() // throws RecognitionException [1]
    {   
        decl_return retval = new decl_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken IDENT29 = null;
        tipo_return tipo28 = null;
        
        
        FkvmAST IDENT29_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleSubtreeStream stream_tipo = new RewriteRuleSubtreeStream(adaptor,"rule tipo");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:96:6: ( tipo IDENT -> ^( DECLARACIONPARAM tipo IDENT ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:96:8: tipo IDENT
            {
            	PushFollow(FOLLOW_tipo_in_decl385);
            	tipo28 = tipo();
            	followingStackPointer_--;
            	
            	stream_tipo.Add(tipo28.Tree);
            	IDENT29 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_decl387); 
            	stream_IDENT.Add(IDENT29);

            	
            	// AST REWRITE
            	// elements:          IDENT, tipo
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 96:19: -> ^( DECLARACIONPARAM tipo IDENT )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:96:22: ^( DECLARACIONPARAM tipo IDENT )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(DECLARACIONPARAM, "DECLARACIONPARAM"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_tipo.Next());
            	    adaptor.AddChild(root_1, stream_IDENT.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end decl

    public class inst_asig_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_asig
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:98:1: inst_asig : IDENT '=' expresion ';' -> ^( ASIGNACION IDENT expresion ) ;
    public inst_asig_return inst_asig() // throws RecognitionException [1]
    {   
        inst_asig_return retval = new inst_asig_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken IDENT30 = null;
        IToken char_literal31 = null;
        IToken char_literal33 = null;
        expresion_return expresion32 = null;
        
        
        FkvmAST IDENT30_tree=null;
        FkvmAST char_literal31_tree=null;
        FkvmAST char_literal33_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_expresion = new RewriteRuleSubtreeStream(adaptor,"rule expresion");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:98:11: ( IDENT '=' expresion ';' -> ^( ASIGNACION IDENT expresion ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:98:13: IDENT '=' expresion ';'
            {
            	IDENT30 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_inst_asig406); 
            	stream_IDENT.Add(IDENT30);

            	char_literal31 = (IToken)input.LT(1);
            	Match(input,32,FOLLOW_32_in_inst_asig408); 
            	stream_32.Add(char_literal31);

            	PushFollow(FOLLOW_expresion_in_inst_asig410);
            	expresion32 = expresion();
            	followingStackPointer_--;
            	
            	stream_expresion.Add(expresion32.Tree);
            	char_literal33 = (IToken)input.LT(1);
            	Match(input,27,FOLLOW_27_in_inst_asig412); 
            	stream_27.Add(char_literal33);

            	
            	// AST REWRITE
            	// elements:          IDENT, expresion
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 98:37: -> ^( ASIGNACION IDENT expresion )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:98:40: ^( ASIGNACION IDENT expresion )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(ASIGNACION, "ASIGNACION"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_IDENT.Next());
            	    adaptor.AddChild(root_1, stream_expresion.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class inst_if_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_if
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:100:1: inst_if : 'if' '(' expresion ')' '{' lista_instrucciones '}' else_otras ;
    public inst_if_return inst_if() // throws RecognitionException [1]
    {   
        inst_if_return retval = new inst_if_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        expresion_return expresion36 = null;

        lista_instrucciones_return lista_instrucciones39 = null;

        else_otras_return else_otras41 = null;
        
        
        FkvmAST string_literal34_tree=null;
        FkvmAST char_literal35_tree=null;
        FkvmAST char_literal37_tree=null;
        FkvmAST char_literal38_tree=null;
        FkvmAST char_literal40_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:100:9: ( 'if' '(' expresion ')' '{' lista_instrucciones '}' else_otras )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:100:11: 'if' '(' expresion ')' '{' lista_instrucciones '}' else_otras
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	string_literal34 = (IToken)input.LT(1);
            	Match(input,33,FOLLOW_33_in_inst_if430); 
            	string_literal34_tree = (FkvmAST)adaptor.Create(string_literal34);
            	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal34_tree, root_0);

            	char_literal35 = (IToken)input.LT(1);
            	Match(input,25,FOLLOW_25_in_inst_if433); 
            	PushFollow(FOLLOW_expresion_in_inst_if436);
            	expresion36 = expresion();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expresion36.Tree);
            	char_literal37 = (IToken)input.LT(1);
            	Match(input,26,FOLLOW_26_in_inst_if438); 
            	char_literal38 = (IToken)input.LT(1);
            	Match(input,29,FOLLOW_29_in_inst_if441); 
            	PushFollow(FOLLOW_lista_instrucciones_in_inst_if444);
            	lista_instrucciones39 = lista_instrucciones();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, lista_instrucciones39.Tree);
            	char_literal40 = (IToken)input.LT(1);
            	Match(input,30,FOLLOW_30_in_inst_if446); 
            	PushFollow(FOLLOW_else_otras_in_inst_if449);
            	else_otras41 = else_otras();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, else_otras41.Tree);
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class else_otras_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start else_otras
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:102:1: else_otras : ( 'else' '{' lista_instrucciones '}' | -> ^( LISTAINSTRUCCIONES ) );
    public else_otras_return else_otras() // throws RecognitionException [1]
    {   
        else_otras_return retval = new else_otras_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal42 = null;
        IToken char_literal43 = null;
        IToken char_literal45 = null;
        lista_instrucciones_return lista_instrucciones44 = null;
        
        
        FkvmAST string_literal42_tree=null;
        FkvmAST char_literal43_tree=null;
        FkvmAST char_literal45_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:102:12: ( 'else' '{' lista_instrucciones '}' | -> ^( LISTAINSTRUCCIONES ) )
            int alt6 = 2;
            int LA6_0 = input.LA(1);
            
            if ( (LA6_0 == 34) )
            {
                alt6 = 1;
            }
            else if ( ((LA6_0 >= IDENT && LA6_0 <= LIT_LOGICO) || LA6_0 == 25 || LA6_0 == 30 || LA6_0 == 33 || (LA6_0 >= 35 && LA6_0 <= 41) || (LA6_0 >= 50 && LA6_0 <= 51) || LA6_0 == 54) )
            {
                alt6 = 2;
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("102:1: else_otras : ( 'else' '{' lista_instrucciones '}' | -> ^( LISTAINSTRUCCIONES ) );", 6, 0, input);
            
                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:102:14: 'else' '{' lista_instrucciones '}'
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	string_literal42 = (IToken)input.LT(1);
                    	Match(input,34,FOLLOW_34_in_else_otras458); 
                    	char_literal43 = (IToken)input.LT(1);
                    	Match(input,29,FOLLOW_29_in_else_otras461); 
                    	PushFollow(FOLLOW_lista_instrucciones_in_else_otras464);
                    	lista_instrucciones44 = lista_instrucciones();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, lista_instrucciones44.Tree);
                    	char_literal45 = (IToken)input.LT(1);
                    	Match(input,30,FOLLOW_30_in_else_otras466); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:103:14: 
                    {
                    	
                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 103:14: -> ^( LISTAINSTRUCCIONES )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:103:17: ^( LISTAINSTRUCCIONES )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAINSTRUCCIONES, "LISTAINSTRUCCIONES"), root_1);
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end else_otras

    public class inst_while_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_while
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:105:1: inst_while : 'while' '(' expresion ')' '{' lista_instrucciones '}' ;
    public inst_while_return inst_while() // throws RecognitionException [1]
    {   
        inst_while_return retval = new inst_while_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        IToken char_literal52 = null;
        expresion_return expresion48 = null;

        lista_instrucciones_return lista_instrucciones51 = null;
        
        
        FkvmAST string_literal46_tree=null;
        FkvmAST char_literal47_tree=null;
        FkvmAST char_literal49_tree=null;
        FkvmAST char_literal50_tree=null;
        FkvmAST char_literal52_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:105:12: ( 'while' '(' expresion ')' '{' lista_instrucciones '}' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:105:14: 'while' '(' expresion ')' '{' lista_instrucciones '}'
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	string_literal46 = (IToken)input.LT(1);
            	Match(input,35,FOLLOW_35_in_inst_while495); 
            	string_literal46_tree = (FkvmAST)adaptor.Create(string_literal46);
            	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal46_tree, root_0);

            	char_literal47 = (IToken)input.LT(1);
            	Match(input,25,FOLLOW_25_in_inst_while498); 
            	PushFollow(FOLLOW_expresion_in_inst_while501);
            	expresion48 = expresion();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expresion48.Tree);
            	char_literal49 = (IToken)input.LT(1);
            	Match(input,26,FOLLOW_26_in_inst_while503); 
            	char_literal50 = (IToken)input.LT(1);
            	Match(input,29,FOLLOW_29_in_inst_while506); 
            	PushFollow(FOLLOW_lista_instrucciones_in_inst_while509);
            	lista_instrucciones51 = lista_instrucciones();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, lista_instrucciones51.Tree);
            	char_literal52 = (IToken)input.LT(1);
            	Match(input,30,FOLLOW_30_in_inst_while511); 
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class inst_return_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start inst_return
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:107:1: inst_return : 'return' expresion ';' ;
    public inst_return_return inst_return() // throws RecognitionException [1]
    {   
        inst_return_return retval = new inst_return_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal53 = null;
        IToken char_literal55 = null;
        expresion_return expresion54 = null;
        
        
        FkvmAST string_literal53_tree=null;
        FkvmAST char_literal55_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:107:13: ( 'return' expresion ';' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:107:15: 'return' expresion ';'
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	string_literal53 = (IToken)input.LT(1);
            	Match(input,36,FOLLOW_36_in_inst_return521); 
            	string_literal53_tree = (FkvmAST)adaptor.Create(string_literal53);
            	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal53_tree, root_0);

            	PushFollow(FOLLOW_expresion_in_inst_return524);
            	expresion54 = expresion();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expresion54.Tree);
            	char_literal55 = (IToken)input.LT(1);
            	Match(input,27,FOLLOW_27_in_inst_return526); 
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class tipo_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start tipo
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:109:1: tipo : ( 'int' | 'float' | 'string' | 'bool' | 'void' );
    public tipo_return tipo() // throws RecognitionException [1]
    {   
        tipo_return retval = new tipo_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken set56 = null;
        
        FkvmAST set56_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:109:6: ( 'int' | 'float' | 'string' | 'bool' | 'void' )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	set56 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 37 && input.LA(1) <= 41) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, adaptor.Create(set56));
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_tipo0);    throw mse;
            	}

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class literal_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start literal
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:111:1: literal : ( LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO );
    public literal_return literal() // throws RecognitionException [1]
    {   
        literal_return retval = new literal_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken set57 = null;
        
        FkvmAST set57_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:111:9: ( LIT_ENTERO | LIT_REAL | LIT_CADENA | LIT_LOGICO )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	set57 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= LIT_ENTERO && input.LA(1) <= LIT_LOGICO) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, adaptor.Create(set57));
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_literal0);    throw mse;
            	}

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class expresion_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expresion
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:116:1: expresion : expOr ;
    public expresion_return expresion() // throws RecognitionException [1]
    {   
        expresion_return retval = new expresion_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        expOr_return expOr58 = null;
        
        
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:116:11: ( expOr )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:116:13: expOr
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expOr_in_expresion598);
            	expOr58 = expOr();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expOr58.Tree);
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class expOr_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expOr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:118:1: expOr : expAnd ( '||' expAnd )* ;
    public expOr_return expOr() // throws RecognitionException [1]
    {   
        expOr_return retval = new expOr_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal60 = null;
        expAnd_return expAnd59 = null;

        expAnd_return expAnd61 = null;
        
        
        FkvmAST string_literal60_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:118:7: ( expAnd ( '||' expAnd )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:118:9: expAnd ( '||' expAnd )*
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expAnd_in_expOr607);
            	expAnd59 = expAnd();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expAnd59.Tree);
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:118:16: ( '||' expAnd )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == 42) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:118:17: '||' expAnd
            			    {
            			    	string_literal60 = (IToken)input.LT(1);
            			    	Match(input,42,FOLLOW_42_in_expOr610); 
            			    	string_literal60_tree = (FkvmAST)adaptor.Create(string_literal60);
            			    	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal60_tree, root_0);

            			    	PushFollow(FOLLOW_expAnd_in_expOr613);
            			    	expAnd61 = expAnd();
            			    	followingStackPointer_--;
            			    	
            			    	adaptor.AddChild(root_0, expAnd61.Tree);
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop7;
            	    }
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expOr

    public class expAnd_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expAnd
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:120:1: expAnd : expComp ( '&&' expComp )* ;
    public expAnd_return expAnd() // throws RecognitionException [1]
    {   
        expAnd_return retval = new expAnd_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal63 = null;
        expComp_return expComp62 = null;

        expComp_return expComp64 = null;
        
        
        FkvmAST string_literal63_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:120:8: ( expComp ( '&&' expComp )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:120:10: expComp ( '&&' expComp )*
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expComp_in_expAnd624);
            	expComp62 = expComp();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expComp62.Tree);
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:120:18: ( '&&' expComp )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == 43) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:120:19: '&&' expComp
            			    {
            			    	string_literal63 = (IToken)input.LT(1);
            			    	Match(input,43,FOLLOW_43_in_expAnd627); 
            			    	string_literal63_tree = (FkvmAST)adaptor.Create(string_literal63);
            			    	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal63_tree, root_0);

            			    	PushFollow(FOLLOW_expComp_in_expAnd630);
            			    	expComp64 = expComp();
            			    	followingStackPointer_--;
            			    	
            			    	adaptor.AddChild(root_0, expComp64.Tree);
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop8;
            	    }
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expAnd

    public class expComp_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expComp
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:122:1: expComp : expMasMenos ( ( '==' | '!=' | '>' | '<' | '>=' | '<=' ) expMasMenos )* ;
    public expComp_return expComp() // throws RecognitionException [1]
    {   
        expComp_return retval = new expComp_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken string_literal66 = null;
        IToken string_literal67 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        IToken string_literal70 = null;
        IToken string_literal71 = null;
        expMasMenos_return expMasMenos65 = null;

        expMasMenos_return expMasMenos72 = null;
        
        
        FkvmAST string_literal66_tree=null;
        FkvmAST string_literal67_tree=null;
        FkvmAST char_literal68_tree=null;
        FkvmAST char_literal69_tree=null;
        FkvmAST string_literal70_tree=null;
        FkvmAST string_literal71_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:122:9: ( expMasMenos ( ( '==' | '!=' | '>' | '<' | '>=' | '<=' ) expMasMenos )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:122:11: expMasMenos ( ( '==' | '!=' | '>' | '<' | '>=' | '<=' ) expMasMenos )*
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expMasMenos_in_expComp641);
            	expMasMenos65 = expMasMenos();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expMasMenos65.Tree);
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:122:23: ( ( '==' | '!=' | '>' | '<' | '>=' | '<=' ) expMasMenos )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);
            	    
            	    if ( ((LA10_0 >= 44 && LA10_0 <= 49)) )
            	    {
            	        alt10 = 1;
            	    }
            	    
            	
            	    switch (alt10) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:3: ( '==' | '!=' | '>' | '<' | '>=' | '<=' ) expMasMenos
            			    {
            			    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:3: ( '==' | '!=' | '>' | '<' | '>=' | '<=' )
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
            			    	case 46:
            			    		{
            			    	    alt9 = 3;
            			    	    }
            			    	    break;
            			    	case 47:
            			    		{
            			    	    alt9 = 4;
            			    	    }
            			    	    break;
            			    	case 48:
            			    		{
            			    	    alt9 = 5;
            			    	    }
            			    	    break;
            			    	case 49:
            			    		{
            			    	    alt9 = 6;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d9s0 =
            			    		        new NoViableAltException("123:3: ( '==' | '!=' | '>' | '<' | '>=' | '<=' )", 9, 0, input);
            			    	
            			    		    throw nvae_d9s0;
            			    	}
            			    	
            			    	switch (alt9) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:4: '=='
            			    	        {
            			    	        	string_literal66 = (IToken)input.LT(1);
            			    	        	Match(input,44,FOLLOW_44_in_expComp648); 
            			    	        	string_literal66_tree = (FkvmAST)adaptor.Create(string_literal66);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal66_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:10: '!='
            			    	        {
            			    	        	string_literal67 = (IToken)input.LT(1);
            			    	        	Match(input,45,FOLLOW_45_in_expComp651); 
            			    	        	string_literal67_tree = (FkvmAST)adaptor.Create(string_literal67);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal67_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:16: '>'
            			    	        {
            			    	        	char_literal68 = (IToken)input.LT(1);
            			    	        	Match(input,46,FOLLOW_46_in_expComp654); 
            			    	        	char_literal68_tree = (FkvmAST)adaptor.Create(char_literal68);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal68_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:21: '<'
            			    	        {
            			    	        	char_literal69 = (IToken)input.LT(1);
            			    	        	Match(input,47,FOLLOW_47_in_expComp657); 
            			    	        	char_literal69_tree = (FkvmAST)adaptor.Create(char_literal69);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal69_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:26: '>='
            			    	        {
            			    	        	string_literal70 = (IToken)input.LT(1);
            			    	        	Match(input,48,FOLLOW_48_in_expComp660); 
            			    	        	string_literal70_tree = (FkvmAST)adaptor.Create(string_literal70);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal70_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 6 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:123:32: '<='
            			    	        {
            			    	        	string_literal71 = (IToken)input.LT(1);
            			    	        	Match(input,49,FOLLOW_49_in_expComp663); 
            			    	        	string_literal71_tree = (FkvmAST)adaptor.Create(string_literal71);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(string_literal71_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	
            			    	}

            			    	PushFollow(FOLLOW_expMasMenos_in_expComp667);
            			    	expMasMenos72 = expMasMenos();
            			    	followingStackPointer_--;
            			    	
            			    	adaptor.AddChild(root_0, expMasMenos72.Tree);
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop10;
            	    }
            	} while (true);
            	
            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expComp

    public class expMasMenos_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expMasMenos
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:125:1: expMasMenos : expMultDiv ( ( '+' | '-' ) expMultDiv )* ;
    public expMasMenos_return expMasMenos() // throws RecognitionException [1]
    {   
        expMasMenos_return retval = new expMasMenos_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        expMultDiv_return expMultDiv73 = null;

        expMultDiv_return expMultDiv76 = null;
        
        
        FkvmAST char_literal74_tree=null;
        FkvmAST char_literal75_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:125:13: ( expMultDiv ( ( '+' | '-' ) expMultDiv )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:125:15: expMultDiv ( ( '+' | '-' ) expMultDiv )*
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expMultDiv_in_expMasMenos680);
            	expMultDiv73 = expMultDiv();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expMultDiv73.Tree);
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:125:26: ( ( '+' | '-' ) expMultDiv )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);
            	    
            	    if ( ((LA12_0 >= 50 && LA12_0 <= 51)) )
            	    {
            	        alt12 = 1;
            	    }
            	    
            	
            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:126:3: ( '+' | '-' ) expMultDiv
            			    {
            			    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:126:3: ( '+' | '-' )
            			    	int alt11 = 2;
            			    	int LA11_0 = input.LA(1);
            			    	
            			    	if ( (LA11_0 == 50) )
            			    	{
            			    	    alt11 = 1;
            			    	}
            			    	else if ( (LA11_0 == 51) )
            			    	{
            			    	    alt11 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d11s0 =
            			    	        new NoViableAltException("126:3: ( '+' | '-' )", 11, 0, input);
            			    	
            			    	    throw nvae_d11s0;
            			    	}
            			    	switch (alt11) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:126:4: '+'
            			    	        {
            			    	        	char_literal74 = (IToken)input.LT(1);
            			    	        	Match(input,50,FOLLOW_50_in_expMasMenos687); 
            			    	        	char_literal74_tree = (FkvmAST)adaptor.Create(char_literal74);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal74_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:126:9: '-'
            			    	        {
            			    	        	char_literal75 = (IToken)input.LT(1);
            			    	        	Match(input,51,FOLLOW_51_in_expMasMenos690); 
            			    	        	char_literal75_tree = (FkvmAST)adaptor.Create(char_literal75);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal75_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	
            			    	}

            			    	PushFollow(FOLLOW_expMultDiv_in_expMasMenos694);
            			    	expMultDiv76 = expMultDiv();
            			    	followingStackPointer_--;
            			    	
            			    	adaptor.AddChild(root_0, expMultDiv76.Tree);
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop12;
            	    }
            	} while (true);
            	
            	loop12:
            		;	// Stops C# compiler whinging that label 'loop12' has no statements

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expMasMenos

    public class expMultDiv_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expMultDiv
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:128:1: expMultDiv : expMenos ( ( '*' | '/' ) expMenos )* ;
    public expMultDiv_return expMultDiv() // throws RecognitionException [1]
    {   
        expMultDiv_return retval = new expMultDiv_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal78 = null;
        IToken char_literal79 = null;
        expMenos_return expMenos77 = null;

        expMenos_return expMenos80 = null;
        
        
        FkvmAST char_literal78_tree=null;
        FkvmAST char_literal79_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:128:12: ( expMenos ( ( '*' | '/' ) expMenos )* )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:128:14: expMenos ( ( '*' | '/' ) expMenos )*
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	PushFollow(FOLLOW_expMenos_in_expMultDiv707);
            	expMenos77 = expMenos();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, expMenos77.Tree);
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:128:23: ( ( '*' | '/' ) expMenos )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);
            	    
            	    if ( ((LA14_0 >= 52 && LA14_0 <= 53)) )
            	    {
            	        alt14 = 1;
            	    }
            	    
            	
            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:129:3: ( '*' | '/' ) expMenos
            			    {
            			    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:129:3: ( '*' | '/' )
            			    	int alt13 = 2;
            			    	int LA13_0 = input.LA(1);
            			    	
            			    	if ( (LA13_0 == 52) )
            			    	{
            			    	    alt13 = 1;
            			    	}
            			    	else if ( (LA13_0 == 53) )
            			    	{
            			    	    alt13 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d13s0 =
            			    	        new NoViableAltException("129:3: ( '*' | '/' )", 13, 0, input);
            			    	
            			    	    throw nvae_d13s0;
            			    	}
            			    	switch (alt13) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:129:4: '*'
            			    	        {
            			    	        	char_literal78 = (IToken)input.LT(1);
            			    	        	Match(input,52,FOLLOW_52_in_expMultDiv714); 
            			    	        	char_literal78_tree = (FkvmAST)adaptor.Create(char_literal78);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal78_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:129:9: '/'
            			    	        {
            			    	        	char_literal79 = (IToken)input.LT(1);
            			    	        	Match(input,53,FOLLOW_53_in_expMultDiv717); 
            			    	        	char_literal79_tree = (FkvmAST)adaptor.Create(char_literal79);
            			    	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal79_tree, root_0);

            			    	        
            			    	        }
            			    	        break;
            			    	
            			    	}

            			    	PushFollow(FOLLOW_expMenos_in_expMultDiv721);
            			    	expMenos80 = expMenos();
            			    	followingStackPointer_--;
            			    	
            			    	adaptor.AddChild(root_0, expMenos80.Tree);
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop14;
            	    }
            	} while (true);
            	
            	loop14:
            		;	// Stops C# compiler whinging that label 'loop14' has no statements

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expMultDiv

    public class expMenos_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expMenos
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:131:1: expMenos : ( '-' expNo -> ^( MENOSUNARIO expNo ) | ( '+' )? expNo -> expNo );
    public expMenos_return expMenos() // throws RecognitionException [1]
    {   
        expMenos_return retval = new expMenos_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        expNo_return expNo82 = null;

        expNo_return expNo84 = null;
        
        
        FkvmAST char_literal81_tree=null;
        FkvmAST char_literal83_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expNo = new RewriteRuleSubtreeStream(adaptor,"rule expNo");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:131:10: ( '-' expNo -> ^( MENOSUNARIO expNo ) | ( '+' )? expNo -> expNo )
            int alt16 = 2;
            int LA16_0 = input.LA(1);
            
            if ( (LA16_0 == 51) )
            {
                alt16 = 1;
            }
            else if ( ((LA16_0 >= IDENT && LA16_0 <= LIT_LOGICO) || LA16_0 == 25 || LA16_0 == 50 || LA16_0 == 54) )
            {
                alt16 = 2;
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("131:1: expMenos : ( '-' expNo -> ^( MENOSUNARIO expNo ) | ( '+' )? expNo -> expNo );", 16, 0, input);
            
                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:131:12: '-' expNo
                    {
                    	char_literal81 = (IToken)input.LT(1);
                    	Match(input,51,FOLLOW_51_in_expMenos732); 
                    	stream_51.Add(char_literal81);

                    	PushFollow(FOLLOW_expNo_in_expMenos734);
                    	expNo82 = expNo();
                    	followingStackPointer_--;
                    	
                    	stream_expNo.Add(expNo82.Tree);
                    	
                    	// AST REWRITE
                    	// elements:          expNo
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 131:22: -> ^( MENOSUNARIO expNo )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:131:25: ^( MENOSUNARIO expNo )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(MENOSUNARIO, "MENOSUNARIO"), root_1);
                    	    
                    	    adaptor.AddChild(root_1, stream_expNo.Next());
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:132:12: ( '+' )? expNo
                    {
                    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:132:12: ( '+' )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);
                    	
                    	if ( (LA15_0 == 50) )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:132:12: '+'
                    	        {
                    	        	char_literal83 = (IToken)input.LT(1);
                    	        	Match(input,50,FOLLOW_50_in_expMenos756); 
                    	        	stream_50.Add(char_literal83);

                    	        
                    	        }
                    	        break;
                    	
                    	}

                    	PushFollow(FOLLOW_expNo_in_expMenos759);
                    	expNo84 = expNo();
                    	followingStackPointer_--;
                    	
                    	stream_expNo.Add(expNo84.Tree);
                    	
                    	// AST REWRITE
                    	// elements:          expNo
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 132:23: -> expNo
                    	{
                    	    adaptor.AddChild(root_0, stream_expNo.Next());
                    	
                    	}
                    	

                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expMenos

    public class expNo_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start expNo
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:134:1: expNo : ( '!' )? acceso ;
    public expNo_return expNo() // throws RecognitionException [1]
    {   
        expNo_return retval = new expNo_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal85 = null;
        acceso_return acceso86 = null;
        
        
        FkvmAST char_literal85_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:134:7: ( ( '!' )? acceso )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:134:9: ( '!' )? acceso
            {
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            
            	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:134:9: ( '!' )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);
            	
            	if ( (LA17_0 == 54) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:134:10: '!'
            	        {
            	        	char_literal85 = (IToken)input.LT(1);
            	        	Match(input,54,FOLLOW_54_in_expNo772); 
            	        	char_literal85_tree = (FkvmAST)adaptor.Create(char_literal85);
            	        	root_0 = (FkvmAST)adaptor.BecomeRoot(char_literal85_tree, root_0);

            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_acceso_in_expNo777);
            	acceso86 = acceso();
            	followingStackPointer_--;
            	
            	adaptor.AddChild(root_0, acceso86.Tree);
            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end expNo

    public class acceso_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start acceso
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:136:1: acceso : ( IDENT | literal | llamada | '(' expresion ')' );
    public acceso_return acceso() // throws RecognitionException [1]
    {   
        acceso_return retval = new acceso_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken IDENT87 = null;
        IToken char_literal90 = null;
        IToken char_literal92 = null;
        literal_return literal88 = null;

        llamada_return llamada89 = null;

        expresion_return expresion91 = null;
        
        
        FkvmAST IDENT87_tree=null;
        FkvmAST char_literal90_tree=null;
        FkvmAST char_literal92_tree=null;
    
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:136:8: ( IDENT | literal | llamada | '(' expresion ')' )
            int alt18 = 4;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA18_1 = input.LA(2);
                
                if ( (LA18_1 == 25) )
                {
                    alt18 = 3;
                }
                else if ( ((LA18_1 >= 26 && LA18_1 <= 27) || LA18_1 == 31 || (LA18_1 >= 42 && LA18_1 <= 53)) )
                {
                    alt18 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("136:1: acceso : ( IDENT | literal | llamada | '(' expresion ')' );", 18, 1, input);
                
                    throw nvae_d18s1;
                }
                }
                break;
            case LIT_ENTERO:
            case LIT_REAL:
            case LIT_CADENA:
            case LIT_LOGICO:
            	{
                alt18 = 2;
                }
                break;
            case 25:
            	{
                alt18 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("136:1: acceso : ( IDENT | literal | llamada | '(' expresion ')' );", 18, 0, input);
            
            	    throw nvae_d18s0;
            }
            
            switch (alt18) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:136:10: IDENT
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	IDENT87 = (IToken)input.LT(1);
                    	Match(input,IDENT,FOLLOW_IDENT_in_acceso786); 
                    	IDENT87_tree = (FkvmAST)adaptor.Create(IDENT87);
                    	adaptor.AddChild(root_0, IDENT87_tree);

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:137:7: literal
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_literal_in_acceso794);
                    	literal88 = literal();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, literal88.Tree);
                    
                    }
                    break;
                case 3 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:138:7: llamada
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	PushFollow(FOLLOW_llamada_in_acceso802);
                    	llamada89 = llamada();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, llamada89.Tree);
                    
                    }
                    break;
                case 4 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:139:7: '(' expresion ')'
                    {
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    
                    	char_literal90 = (IToken)input.LT(1);
                    	Match(input,25,FOLLOW_25_in_acceso810); 
                    	PushFollow(FOLLOW_expresion_in_acceso813);
                    	expresion91 = expresion();
                    	followingStackPointer_--;
                    	
                    	adaptor.AddChild(root_0, expresion91.Tree);
                    	char_literal92 = (IToken)input.LT(1);
                    	Match(input,26,FOLLOW_26_in_acceso815); 
                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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
    // $ANTLR end acceso

    public class llamada_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start llamada
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:141:1: llamada : IDENT '(' lista_expr ')' -> ^( LLAMADA IDENT lista_expr ) ;
    public llamada_return llamada() // throws RecognitionException [1]
    {   
        llamada_return retval = new llamada_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken IDENT93 = null;
        IToken char_literal94 = null;
        IToken char_literal96 = null;
        lista_expr_return lista_expr95 = null;
        
        
        FkvmAST IDENT93_tree=null;
        FkvmAST char_literal94_tree=null;
        FkvmAST char_literal96_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_lista_expr = new RewriteRuleSubtreeStream(adaptor,"rule lista_expr");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:141:9: ( IDENT '(' lista_expr ')' -> ^( LLAMADA IDENT lista_expr ) )
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:141:11: IDENT '(' lista_expr ')'
            {
            	IDENT93 = (IToken)input.LT(1);
            	Match(input,IDENT,FOLLOW_IDENT_in_llamada825); 
            	stream_IDENT.Add(IDENT93);

            	char_literal94 = (IToken)input.LT(1);
            	Match(input,25,FOLLOW_25_in_llamada827); 
            	stream_25.Add(char_literal94);

            	PushFollow(FOLLOW_lista_expr_in_llamada829);
            	lista_expr95 = lista_expr();
            	followingStackPointer_--;
            	
            	stream_lista_expr.Add(lista_expr95.Tree);
            	char_literal96 = (IToken)input.LT(1);
            	Match(input,26,FOLLOW_26_in_llamada831); 
            	stream_26.Add(char_literal96);

            	
            	// AST REWRITE
            	// elements:          lista_expr, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
            	
            	root_0 = (FkvmAST)adaptor.GetNilNode();
            	// 141:36: -> ^( LLAMADA IDENT lista_expr )
            	{
            	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:141:39: ^( LLAMADA IDENT lista_expr )
            	    {
            	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
            	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LLAMADA, "LLAMADA"), root_1);
            	    
            	    adaptor.AddChild(root_1, stream_IDENT.Next());
            	    adaptor.AddChild(root_1, stream_lista_expr.Next());
            	    
            	    adaptor.AddChild(root_0, root_1);
            	    }
            	
            	}
            	

            
            }
    
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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

    public class lista_expr_return : ParserRuleReturnScope 
    {
        internal FkvmAST tree;
        override public object Tree
        {
        	get { return tree; }
        }
    };
    
    // $ANTLR start lista_expr
    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:1: lista_expr : (lista+= expresion ( ',' lista+= expresion )* -> ^( LISTAEXPRESIONES ( $lista)* ) | -> ^( LISTAEXPRESIONES ) );
    public lista_expr_return lista_expr() // throws RecognitionException [1]
    {   
        lista_expr_return retval = new lista_expr_return();
        retval.start = input.LT(1);
        
        FkvmAST root_0 = null;
    
        IToken char_literal97 = null;
        IList list_lista = null;
        RuleReturnScope lista = null;
        FkvmAST char_literal97_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_expresion = new RewriteRuleSubtreeStream(adaptor,"rule expresion");
        try 
    	{
            // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:12: (lista+= expresion ( ',' lista+= expresion )* -> ^( LISTAEXPRESIONES ( $lista)* ) | -> ^( LISTAEXPRESIONES ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);
            
            if ( ((LA20_0 >= IDENT && LA20_0 <= LIT_LOGICO) || LA20_0 == 25 || (LA20_0 >= 50 && LA20_0 <= 51) || LA20_0 == 54) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == 26) )
            {
                alt20 = 2;
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("143:1: lista_expr : (lista+= expresion ( ',' lista+= expresion )* -> ^( LISTAEXPRESIONES ( $lista)* ) | -> ^( LISTAEXPRESIONES ) );", 20, 0, input);
            
                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:14: lista+= expresion ( ',' lista+= expresion )*
                    {
                    	PushFollow(FOLLOW_expresion_in_lista_expr851);
                    	lista = expresion();
                    	followingStackPointer_--;
                    	
                    	stream_expresion.Add(lista.Tree);
                    	if (list_lista == null) list_lista = new ArrayList();
                    	list_lista.Add(lista);

                    	// D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:31: ( ',' lista+= expresion )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);
                    	    
                    	    if ( (LA19_0 == 31) )
                    	    {
                    	        alt19 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:32: ',' lista+= expresion
                    			    {
                    			    	char_literal97 = (IToken)input.LT(1);
                    			    	Match(input,31,FOLLOW_31_in_lista_expr854); 
                    			    	stream_31.Add(char_literal97);

                    			    	PushFollow(FOLLOW_expresion_in_lista_expr858);
                    			    	lista = expresion();
                    			    	followingStackPointer_--;
                    			    	
                    			    	stream_expresion.Add(lista.Tree);
                    			    	if (list_lista == null) list_lista = new ArrayList();
                    			    	list_lista.Add(lista);

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);
                    	
                    	loop19:
                    		;	// Stops C# compiler whinging that label 'loop19' has no statements

                    	
                    	// AST REWRITE
                    	// elements:          lista
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  lista
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	RewriteRuleSubtreeStream stream_lista = new RewriteRuleSubtreeStream(adaptor, "token lista", list_lista);
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 143:55: -> ^( LISTAEXPRESIONES ( $lista)* )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:58: ^( LISTAEXPRESIONES ( $lista)* )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAEXPRESIONES, "LISTAEXPRESIONES"), root_1);
                    	    
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:143:77: ( $lista)*
                    	    while ( stream_lista.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, ((ParserRuleReturnScope)stream_lista.Next()).Tree);
                    	    
                    	    }
                    	    stream_lista.Reset();
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
                case 2 :
                    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:144:15: 
                    {
                    	
                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	retval.tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));
                    	
                    	root_0 = (FkvmAST)adaptor.GetNilNode();
                    	// 144:15: -> ^( LISTAEXPRESIONES )
                    	{
                    	    // D:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FKVM.g:144:18: ^( LISTAEXPRESIONES )
                    	    {
                    	    FkvmAST root_1 = (FkvmAST)adaptor.GetNilNode();
                    	    root_1 = (FkvmAST)adaptor.BecomeRoot(adaptor.Create(LISTAEXPRESIONES, "LISTAEXPRESIONES"), root_1);
                    	    
                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	
                    	}
                    	

                    
                    }
                    break;
            
            }
            retval.stop = input.LT(-1);
            
            	retval.tree = (FkvmAST)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);
    
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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_declaraciones_api_in_programa110 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_principal_in_programa112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaracion_api_in_declaraciones_api134 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_declaracion_api155 = new BitSet(new ulong[]{0x000003E000000000UL});
    public static readonly BitSet FOLLOW_tipo_in_declaracion_api157 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_declaracion_api159 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_declaracion_api161 = new BitSet(new ulong[]{0x000003E004000000UL});
    public static readonly BitSet FOLLOW_lista_decl_in_declaracion_api163 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_declaracion_api165 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_declaracion_api167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_principal188 = new BitSet(new ulong[]{0x000003E000000000UL});
    public static readonly BitSet FOLLOW_tipo_in_principal191 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_principal193 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_principal195 = new BitSet(new ulong[]{0x004C03FA420F8000UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_principal198 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_principal200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instruccion_in_lista_instrucciones213 = new BitSet(new ulong[]{0x004C03FA020F8002UL});
    public static readonly BitSet FOLLOW_inst_decl_in_instruccion233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_asig_in_instruccion240 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_if_in_instruccion248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_while_in_instruccion256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_return_in_instruccion264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inst_expr_in_instruccion272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_expr283 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_inst_expr285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tipo_in_inst_decl295 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_decl297 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_inst_decl299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decl_in_lista_decl326 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_lista_decl329 = new BitSet(new ulong[]{0x000003E000000000UL});
    public static readonly BitSet FOLLOW_decl_in_lista_decl333 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_tipo_in_decl385 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_IDENT_in_decl387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_inst_asig406 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_inst_asig408 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_asig410 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_inst_asig412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_inst_if430 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_inst_if433 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_if436 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_inst_if438 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_inst_if441 = new BitSet(new ulong[]{0x004C03FA420F8000UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_if444 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_inst_if446 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_else_otras_in_inst_if449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_else_otras458 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_else_otras461 = new BitSet(new ulong[]{0x004C03FA420F8000UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_else_otras464 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_else_otras466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_inst_while495 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_inst_while498 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_while501 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_inst_while503 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_inst_while506 = new BitSet(new ulong[]{0x004C03FA420F8000UL});
    public static readonly BitSet FOLLOW_lista_instrucciones_in_inst_while509 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_inst_while511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_inst_return521 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_inst_return524 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_inst_return526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_tipo0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expOr_in_expresion598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expAnd_in_expOr607 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_expOr610 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expAnd_in_expOr613 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_expComp_in_expAnd624 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_expAnd627 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expComp_in_expAnd630 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_expMasMenos_in_expComp641 = new BitSet(new ulong[]{0x0003F00000000002UL});
    public static readonly BitSet FOLLOW_44_in_expComp648 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_45_in_expComp651 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_46_in_expComp654 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_47_in_expComp657 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_48_in_expComp660 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_49_in_expComp663 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expMasMenos_in_expComp667 = new BitSet(new ulong[]{0x0003F00000000002UL});
    public static readonly BitSet FOLLOW_expMultDiv_in_expMasMenos680 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_50_in_expMasMenos687 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_51_in_expMasMenos690 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expMultDiv_in_expMasMenos694 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_expMenos_in_expMultDiv707 = new BitSet(new ulong[]{0x0030000000000002UL});
    public static readonly BitSet FOLLOW_52_in_expMultDiv714 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_53_in_expMultDiv717 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expMenos_in_expMultDiv721 = new BitSet(new ulong[]{0x0030000000000002UL});
    public static readonly BitSet FOLLOW_51_in_expMenos732 = new BitSet(new ulong[]{0x00400000020F8000UL});
    public static readonly BitSet FOLLOW_expNo_in_expMenos734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_expMenos756 = new BitSet(new ulong[]{0x00400000020F8000UL});
    public static readonly BitSet FOLLOW_expNo_in_expMenos759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_expNo772 = new BitSet(new ulong[]{0x00000000020F8000UL});
    public static readonly BitSet FOLLOW_acceso_in_expNo777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_acceso786 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_acceso794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_llamada_in_acceso802 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_acceso810 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_acceso813 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_acceso815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_llamada825 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_llamada827 = new BitSet(new ulong[]{0x004C0000060F8000UL});
    public static readonly BitSet FOLLOW_lista_expr_in_llamada829 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_llamada831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expresion_in_lista_expr851 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_lista_expr854 = new BitSet(new ulong[]{0x004C0000020F8000UL});
    public static readonly BitSet FOLLOW_expresion_in_lista_expr858 = new BitSet(new ulong[]{0x0000000080000002UL});

}
