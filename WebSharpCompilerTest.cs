using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSharpCompilerBusiness;

namespace WebSharpCompilerTest
{
    //test class 1
    [TestClass]
    public class WebSharpCompilerTest
    {
        //test method 1
        [TestMethod]
        public void TestCompilerNotNull()
        {
            WebSharpCompilerBusiness.WebSharpCompiler compiler = new WebSharpCompilerBusiness.WebSharpCompiler();
            Assert.IsNotNull(compiler.Compile(""));
        }

        //text method 2

        [TestMethod]
        public void TestCompilerSingleError()
        {
            WebSharpCompilerBusiness.WebSharpCompiler compiler = new WebSharpCompilerBusiness.WebSharpCompiler();
            string programText = @"
          using **** System;
          namespace HelloWorld
          {
              class HelloWorldClass
              {
                  static void Main(string[] args)
                  {
                      Console.ReadLine();
                  }
              }
          }";
            List<string> compilerErrors = compiler.Compile(programText);
            Assert.AreEqual(compilerErrors.Count, 1);
        }


        //test method 3

        [TestMethod]

        public void TestCompilerFiveErrors()
        {
            WebSharpCompilerBusiness.WebSharpCompiler compiler = new WebSharpCompilerBusiness.WebSharpCompiler();

            string programText = @"

        using **** System;

        namespace HelloWorld

        {
            clas HelloWorldClass
            {
                static void Main(string[] args)

                {
                    Console.ReadLine();

                }

            }";
            List<string> compilerErrors = compiler.Compile(programText);

            Assert.AreEqual(compilerErrors.Count, 5);

        }

        //test method 4

        [TestMethod]

        public void TestCompilerSuccessfulCompilation()
        {
            WebSharpCompilerBusiness.WebSharpCompiler compiler = new WebSharpCompilerBusiness.WebSharpCompiler();
            string programText = @"

        using System;

        namespace HelloWorld

        {
            class HelloWorldClass
                    {
                 static void Main(string[] args)
                 {
                     Console.ReadLine();
                 }
             }

         }";
            List<string> compilerErrors = compiler.Compile((programText));
            Assert.AreEqual(compilerErrors.Count, 0);
        }
        ////test method 5
        //[TestMethod]
        //public void IndexoutOfRange()
        //{
        //    WebSharpCompilerBusiness.WebSharpCompiler compiler = new WebSharpCompilerBusiness.WebSharpCompiler();
        //    string programText = @"
        //using System;

        //namespace HelloWorld

        //{
        //    class HelloWorldClass
        //            {
        //         static void Main(string[] args)
        //         {
        //             int[] ar = {1, 2, 3, 4, 5}; 
          
        //             for (int i = 0; i <= ar.Length; i++)
        //             Console.WriteLine(ar[i]);
        //         }
        //     }

        // }";
        //    List<string> compilerErrors = compiler.Compile(programText);

        //    Assert.AreEqual(compilerErrors.Count, 1);

        //}
        ////test method 6
        //[TestMethod]
        

    }

}



