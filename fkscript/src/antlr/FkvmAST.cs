using Antlr.Runtime;
using Antlr.Runtime.Tree;

public class FkvmAST : Antlr.Runtime.Tree.CommonTree
{
	public Symbol symbol;
	public string expType = "";
    public string expSecType = "";

    public FkvmAST(IToken t) : base(t)
    {
	}
}

