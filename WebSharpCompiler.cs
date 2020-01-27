using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Web;

namespace WebSharpCompilerBusiness
{
    public class WebSharpCompiler
    {
        //1 public object Compile(string p)
        //{
        //    List<string> messages = new List<string>();
        //    if (string.IsNullOrEmpty(p))
        //    {
        //        messages.Add("program text cannot be null or empty");
        //    }
        //    return messages;
        //}


        //2 public List<string> Compile(string programText)
        //{
        //    List<string> messages = new List<string>();
        //    if (String.IsNullOrEmpty(programText))
        //    {
        //        messages.Add("program text cannot be null or                        empty");
        //    }
        //    CompilerResults compilerResults = ProcessCompilation(programText);
        //    foreach (CompilerError error in compilerResults.Errors)
        //    {
        //        messages.Add(String.Format("Line {0} Error No:{1} -       {2}", error.Line, error.ErrorNumber, error.ErrorText));
        //    }

        //    return messages;
        //}

        //private CompilerResults ProcessCompilation(string programText)
        //{
        //    throw new NotImplementedException();
        //}



        //public object Compile(string p)
        //{
        //    List<string> messages = new List<string>();
        //    if (string.IsNullOrEmpty(p))
        //    {
        //        messages.Add("program text cannot be null or empty");
        //    }
        //    messages.Add("program contains 1 error");
        //    return messages;
        //}



        public List<string> Compile(string programText)
        {
            List<string> messages = new List<string>();
            if (String.IsNullOrEmpty(programText))
            {
                messages.Add("program text cannot be null or empty");
            }
            else if (String.IsNullOrWhiteSpace(programText))
            {
                messages.Add("Exception: indentation error");
            }
            else if ())
            {

            }
            CompilerResults compilerResults = ProcessCompilation(programText);
            foreach (CompilerError error in compilerResults.Errors)
            {
                messages.Add(String.Format("Line {0} Error No:{1} -  {2}", error.Line, error.ErrorNumber, error.ErrorText));
            }

            return messages;
        }

        public CompilerResults ProcessCompilation(string programText)
        {
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            System.Collections.Specialized.StringCollection assemblies = new System.Collections.Specialized.StringCollection();
            return codeDomProvider.CompileAssemblyFromSource(parameters, programText);
        }
    }
}

    



