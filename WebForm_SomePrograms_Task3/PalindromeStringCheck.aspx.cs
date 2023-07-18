using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_SomePrograms_Task3
{
    public partial class PalindromeStringCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text;
            string reverse_string = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse_string = reverse_string + text[i];
            }
            if (text == reverse_string)
                Label1.Text = text + " is a Palindrome String!";
            else
                Label1.Text = text + " is not a Palindrome String!";
        }
    }
}