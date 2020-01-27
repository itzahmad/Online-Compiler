using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSharpCompilerBusiness;
using WebSharpCompiler;
using WebSharpCompilerTest;

namespace WebSharpCompiler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }





        protected void btnCompile_Click(object sender, EventArgs e)
        {
            lstCompilerOutput.Items.Clear();
            WebSharpCompilerBusiness.WebSharpCompiler compiler = new
            WebSharpCompilerBusiness.WebSharpCompiler();
            List<string> compilerErrors = compiler.Compile(txtCode.Text);
            //if (String.IsNullOrEmpty(txtCode.Text))
            //{
            //    lstCompilerOutput.Items.Add("program text cannot be null or empty");
            //}

            if (compilerErrors.Count == 0)
            {
                
                lstCompilerOutput.Items.Add("No Errors");
            }

            foreach (string error in compilerErrors)
            {
                lstCompilerOutput.Items.Add(error);
                Console.WriteLine();
            }
        }

        //protected void btnCompile_Click(object sender, EventArgs e)
        //{
        //    Compile(ToString());
        //    List<string> Compile(string programText)
        //    {
        //        List<string> messages = new List<string>();
        //        if (String.IsNullOrEmpty(programText))
        //        {
        //            messages.Add("program text cannot be null or empty");
        //        }
        //        CompilerResults compilerResults = ProcessCompilation(programText);
        //        foreach (CompilerError error in compilerResults.Errors)
        //        {
        //            messages.Add(String.Format("Line {0} Error No:{1} -  {2}", error.Line, error.ErrorNumber, error.ErrorText));
        //        }

        //        return messages;
        //    }

        //}


        protected void btnClear_Click(object sender, EventArgs e)
        {

            btnClear.Enabled = true;
            txtCode.Text = string.Empty;
            txtCode.Text = string.Empty;

        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
           
        }


       
        public CompilerResults ProcessCompilation(string programText)
        {
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            System.Collections.Specialized.StringCollection assemblies = new System.Collections.Specialized.StringCollection();
            return codeDomProvider.CompileAssemblyFromSource(parameters, programText);
        }

        protected void lstCompilerOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}