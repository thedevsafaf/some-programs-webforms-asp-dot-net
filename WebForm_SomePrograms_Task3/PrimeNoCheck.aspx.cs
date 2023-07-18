using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SomePrograms_Task3
{
    public partial class PrimeNoCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int factor_count = 0;
            for(int i = 1; i <= num;  i++) 
            {
                if(num % i == 0)
                {
                    factor_count++;
                }
            }
            if (factor_count == 2) 
            {
                Label1.Text = num+" is a prime number since it has only two factors, 1 and " + num;
            }
            else
            {
                Label1.Text = num+" is not a Prime number.";
            }
        }
    }
}