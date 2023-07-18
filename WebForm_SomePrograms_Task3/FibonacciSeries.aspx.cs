using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SomePrograms_Task3
{
    public partial class FibonacciSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int limit = Convert.ToInt32(TextBox1.Text);
            Label1.Text = "Fibonacci Series: "+n1+" "+n2+" ";
            for (int i = 2; i < limit; i++)
            {
                n3 = n1 + n2;
                Label1.Text = Label1.Text + (n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}