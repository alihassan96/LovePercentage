using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.IO;

namespace LoveCalculator
{
    /// <summary>
    /// Summary description for LoveCalculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoveCalculator : System.Web.Services.WebService
    {


        [WebMethod]
        public string LoveCalculation(string Male, string Female)
        {
            
            return LoveCalculate(Male, Female);
        }
       
        private string LoveCalculate(string fname, string sname)
        {
            String f1 = fname.ToString();
            String m1 = sname.ToString();
            string ans;
            try
            {
                String Add = m1 + f1;
                int val = Add.GetHashCode();
                Random random = new Random(val);
                ans = (random.Next(100) + 1) + "%";
                return ans;
            }
            catch (Exception ex)
            {
              
                return "Read Error!!" + ex.ToString();
            }
        }
    }
}
