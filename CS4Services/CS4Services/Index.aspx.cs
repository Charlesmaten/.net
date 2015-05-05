using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CS4Services.ArcherService;

namespace CS4Services
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalcService.CalcService myCalcService = new CalcService.CalcService();
            ArcherService.ArcherService myArcherService = new ArcherService.ArcherService();

            ArcherService.Answer a = new Answer();
            ArcherService.NameTable nt = new NameTable();
            ArcherService.PrizesTable pt = new PrizesTable();
            ClientName cn;
            ClientPrizes cp;

            object[] sortedList = myCalcService.GetSorted("3","4","5");

            ListBox1.Items.Add("5 + 4 + 3 = " + myCalcService.TotalPoints(3,4,5));
            ListBox1.Items.Add("The average of 5, 4 and 3 is " + myCalcService.AveragePoints(3,4,5));
            ListBox1.Items.Add("Sorted list: " + sortedList.GetValue(0) + ", " + sortedList.GetValue(1) + ", " + sortedList.GetValue(2));

           


            
            

        }
    }
}