using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication1
{
public partial class WebForm1 : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
if (!Page.IsPostBack)
{
string[] str = new string[] { "Select", "Redme", "samsung", "vivo", "oppo" };
for (int i = 0; i < str.Length; i++)
{
DropDownList1.Items.Add(str[i]);
}
}
}



protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{
string str = DropDownList1.Text;
Image1.ImageUrl = "~/Pics/" + str + ".jfif";
}



protected void Button1_Click(object sender, EventArgs e)
{
TextBox1.Text = DropDownList1.SelectedIndex.ToString();
if (DropDownList1.Text == "Red me")
{
TextBox1.Text = "Rs. 20,000";
}
else if (DropDownList1.Text == "samsung")
{
TextBox1.Text = "Rs. 30,000";
}
else if (DropDownList1.Text == "vivo")
{
TextBox1.Text = "Rs.35,000";
}
else if (DropDownList1.Text == "oppo")
{
TextBox1.Text = "Rs. 40,000";
}
else
{
TextBox1.Text = " ";
}
}
}
}