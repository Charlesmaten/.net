using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        /*
        The service should receive results from a shooting as a string with a sequence of numbers. 
	    The service should be able to return the total and average points.
	    The service should also be able to return a string with the numbers sorted
        */


        [WebMethod]
        public int TotalPoints(int a, int b, int c)
        {
            return a + b + c;
        }

        [WebMethod]
        public int AveragePoints(int a, int b, int c)
        {
            return TotalPoints(a,b,c)/3;
        }

        [WebMethod]
        public List<string> GetSorted(string a, string b, string c)
        //public string Sorted()
        {
            var sortedList = new List<string> {a, b, c};
            sortedList.Sort();
            return sortedList;




            //ArrayList sortedList = new ArrayList {a, b, c};
            //sortedList.Sort();
            //return sortedList;

        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
