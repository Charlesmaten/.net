using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using CS4Services.ArcherService;

namespace CS4Services
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalcService.CalcService myCalcService = new CalcService.CalcService();          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CalcService.CalcService myCalcService = new CalcService.CalcService();

            string[] txtNums = {TextBoxNumber1.Text, TextBoxNumber2.Text, TextBoxNumber3.Text};
            StringBuilder sb = new StringBuilder();
            foreach (string s in txtNums)
            {
                int tmp;
                if (int.TryParse(s, out tmp))
                    sb.Append(s + ";");
                else
                {
                    //Handle exception;
                    break;
                }
            }
            string totalStr = sb.ToString();
            totalStr = totalStr.Remove(totalStr.Length - 1);

            TextBoxTotalShow.Text = myCalcService.TotalPoints(totalStr);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CalcService.CalcService myCalcService = new CalcService.CalcService();

            string[] txtNums = {TextBoxNumber1.Text, TextBoxNumber2.Text, TextBoxNumber3.Text};
            StringBuilder sb = new StringBuilder();
            foreach (string s in txtNums)
            {
                int tmp;
                if (int.TryParse(s, out tmp))
                    sb.Append(s + ";");
                else               
                {
                    //Handle exception;
                    break;
                }
            }
            string totalStr = sb.ToString();
            totalStr = totalStr.Remove(totalStr.Length - 1);
            TextBoxTotalShow.Text = myCalcService.AveragePoints(totalStr);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CalcService.CalcService myCalcService = new CalcService.CalcService();

            string a = TextBoxNumber1.Text;
            string b = TextBoxNumber2.Text;
            string c = TextBoxNumber3.Text;

            string[] sortedList = myCalcService.GetSorted(a, b, c);
            StringBuilder sb = new StringBuilder();
            foreach (string s in sortedList)
            {
                sb.Append(s + ",");
            }
            string sortedStr = sb.ToString();
            sortedStr = sortedStr.Remove(sortedStr.Length - 1);
            TextBoxTotalShow.Text = sortedStr; 

        }

        protected void TextBoxNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonName_Click(object sender, EventArgs e)
        {

            Answer a = new Answer();
            NameData nt = new NameData();
            PrizesData pt = new PrizesData();
            ArcherService.ArcherService myArcherService = new ArcherService.ArcherService();
            ClientName cn;
            ClientPrizes cp;

            a = myArcherService.FindName(TextBox1.Text);
            cp = new ClientPrizes(a.PrizesData);
            cn = new ClientName(a.NameData, cp);
      
            ListBox1.Items.Add(cn.ToString());



        }         
    }
}