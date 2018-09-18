using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tools.WindowsInstallerXml;

namespace WixFileExistExtension
{
  public class WixFileExistExtension: WixExtension
  {
    private WixFileExistProcessor preprocessorExtension;
    public override PreprocessorExtension PreprocessorExtension
    {
      get
      {
        if (this.preprocessorExtension == null)
        {
          this.preprocessorExtension = new WixFileExistProcessor();
        }
        return this.preprocessorExtension;

      }
    }
  }

  public class WixFileExistProcessor: PreprocessorExtension
  {
    private static string[] prefixes = { "fs" };
    public override string[] Prefixes { get { return prefixes; } }

    public override string GetVariableValue(string prefix, string name)
    {
      string result = null;
      //// Based on the namespace and name, define the resulting string. 
      //switch (prefix)
      //{
      //  case "fs":
      //    switch (name)
      //    {
      //      case "variable":
      //        // This could be looked up from anywhere you can access from your code. 
      //        result = "replaced";
      //        break;
      //    }
      //    break;
      //}
      return result;
    }

    public override string EvaluateFunction(string prefix, string function, string[] args)
    {
      string result = null;
      switch (prefix)
      {
        case "fs":
          switch (function)
          {
            case "FileExist":
              if (0 < args.Length)
              {

                // Check to see if the file exists.
                FileInfo finfo = new FileInfo(args[0]);

                if (finfo.Exists)
                  result = "1"; // True
                else
                  result = "0"; // False String.Empty;

                // Debug
                //Console.WriteLine("File = " + args[0] + (finfo.Exists ? " do exist" : " do not exist"));
              }
              else
              {
                result = String.Empty;
              }
              break;
          }
          break;
      }
      return result;
    }

  }
}
