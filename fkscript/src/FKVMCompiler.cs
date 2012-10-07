using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr.StringTemplate;

namespace FKVM
{
    class FKTreeAdaptor : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            return new FkvmAST(payload);
        }
    }

    public class FKVMCompiler
    {
        private ITreeAdaptor adaptor = new FKTreeAdaptor();
        public bool compilacionOK = false;

        public delegate void ReportarError(string error);
        public ReportarError re;

        public FKVMCompiler() { 
        }

        public void addReportarError(ReportarError re)
        {
            this.re = re;
        }

        public void compilarString(string strEntrada, string pathSalida)
        {
            ANTLRStringStream input = new ANTLRStringStream(strEntrada);

            compilacion(input, pathSalida);
        }

        public void compilarFichero(string pathEntrada, string pathSalida)
        {
            ANTLRFileStream input = new ANTLRFileStream(pathEntrada);

            compilacion(input, pathSalida);
        }

        private void compilacion(ICharStream input, string pathSalida)
        {
            compilacionOK = false;

            //Plantillas
            //TextReader groupFileR = new StreamReader("C:\\Proyectos\\ProyectosVS\\FKVM\\FKVM\\src\\antlr\\FkvmIL.stg");
            TextReader groupFileR = new StreamReader(
                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("FKVM.src.antlr.FkvmIL.stg"));
            StringTemplateGroup templates = new StringTemplateGroup(groupFileR);
            groupFileR.Close();

            //Análisis Léxico-Sintáctico
            Console.WriteLine("Análisis léxico-sintáctico...");
            //ANTLRFileStream input = new ANTLRFileStream(pathEntrada);  
            FKVMLexer lexer = new FKVMLexer(input);

            CommonTokenStream tokens = new CommonTokenStream(lexer);
            FKVMParser parser = new FKVMParser(tokens);
            parser.TreeAdaptor = adaptor;
            parser.reportarError = re;
            FKVMParser.programa_return result = parser.programa();

            //Si no hay errores léxicos ni sintácticos ==> Análisis Semántico
            if (lexer.numErrors + parser.numErrors == 0)
            {
                //Analisis Semántico
                Console.WriteLine("Análisis semántico...");
                CommonTree t = ((CommonTree)result.Tree);
                //Console.WriteLine(t.ToStringTree() + "\n\n"); //
                CommonTreeNodeStream nodes2 = new CommonTreeNodeStream(t);
                nodes2.TokenStream = tokens;
                FKVMSem walker2 = new FKVMSem(nodes2);
                walker2.reportarError = re;
                walker2.programa(parser.symtable);

                //Si no hay errores en el análisis semántico ==> Generación de código
                if (walker2.numErrors == 0)
                {
                    //Generación de Código
                    Console.WriteLine("Generación de código...");
                    CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
                    nodes.TokenStream = tokens;
                    FKVMGen walker = new FKVMGen(nodes);
                    walker.TemplateLib = templates;
                    FKVMGen.programa_return r2 = walker.programa(parser.numVars);

                    //Presentación de resultados
                    StringTemplate output = (StringTemplate)r2.Template;
                    //Console.WriteLine(output.ToString());

                    StreamWriter pw = new StreamWriter(pathSalida);
                    pw.WriteLine(output.ToString());
                    pw.Flush();
                    pw.Close();

                    compilacionOK = true;
                }
            }
        }
    }
}
