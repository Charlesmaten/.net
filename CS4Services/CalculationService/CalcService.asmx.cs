using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace CalculationService
{
    /// <summary>
    /// Summary description for CalcService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {   
        [WebMethod]
        public string TotalPoints(string a)
        {
            string[] nums = a.Split(';');
            int total = 0;
            foreach (string s in nums)
            {
                int tmp = int.Parse(s);
                total += tmp;
            }
            return Convert.ToString(total);
        }
        
        [WebMethod]
        public string AveragePoints(string a)
        {
            string[] nums = a.Split(';');
            int total = 0;
            foreach (string s in nums)
            {
                int tmp = int.Parse(s);
                total += tmp;
            }
            int total1 = total/3;
            return Convert.ToString(total1);

        }
     
        
        [WebMethod]
        public List<string> GetSorted(string a, string b, string c)     
        {
            var sortedList = new List<string> {a, b, c};
            sortedList.Sort();
            return sortedList;
        }
         



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
