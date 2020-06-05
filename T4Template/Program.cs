using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Template
{
    class Program
    {
        //Def:Mixure of text blocks and control logic
        //<html><body>
        // The date and time now is: <#= DateTime.Now #>
        //</body></html>

        static void Main(string[] args)
        {
            //<#@ output extension=".cs" #>
            //<#@ assembly name="System.Xml" #>
            //<#
            //System.Xml.XmlDocument configurationData = ...; // Read a data file here.
            //#>
            //namespace Fabrikam.<#= configurationData.SelectSingleNode("jobName").Value #>
            //{
            // More code here.

            //1. run-time templates
            //string webResponseText = new MyTemplate().TransformText();
            //2.Design-time template
            //<#@ output extension=".cs" #>
            //<#@ assembly name="System.Xml" #>
            //<#
            // System.Xml.XmlDocument configurationData = ...; // Read a data file here.
            //#>
            //namespace Fabrikam.<#= configurationData.SelectSingleNode("jobName").Value #>
            //{
            //  // More code here.
            //}
               
    }
}

