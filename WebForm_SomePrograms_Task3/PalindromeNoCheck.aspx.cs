using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SomePrograms_Task3
{
    public partial class PalindromeNoCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int rev = 0;
            int n = num;
            int rem;
            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            if (num == rev)
                Label1.Text = num + " is a Palindrome Number";
            else
                Label1.Text = num + " is not a Palindrome Number";
        }
    }
}