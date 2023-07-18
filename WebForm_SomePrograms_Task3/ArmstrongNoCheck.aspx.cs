using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SomePrograms_Task3
{
    public partial class ArmstrongNoCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int sum = 0;
            int rem;
            int n = num;
            while (n > 0) 
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }
            if (num == sum)
                Label1.Text = num + " is an Armstrong Number.";
            else
                Label1.Text = num + " is not an Armstrong Number.";
        }
    }
}