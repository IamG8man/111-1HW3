using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
public partial class Test : System.Web.UI.Page f
string[] = s_Vegetable = new string[2] {"蔬菜","水果"};
    string[,] s_fruit = new string[2, 2]{{"A菜,“空心菜" },#{“番茄”,"火龍果}
protected void Page_Load(object sender, Eventargs e) {
        if { !IsPostBack} { }
        for (int i_ct = 0; i_ct < A Vegetable.Length; i_Ct++)

{
            ListItem s_v = new ListItem();
            s_V.Text = s_V.Value = s_Vegetable[i_ct];

            dd1_category.Items.Add(s_v);
        }
        mt_GenSecondList();
    }
}
        protected void mt_GenSecondList()
{ 
int i_ind = ddl_Category.SelectedIndex;
        dd1_Food.Items.clear();
for (int i_ct=0; i_ct<s_fruit.GetLength(1); i_ct++) { 
ListItem s_V = new ListItem();
        s_V.Text = s_V.Value = s_fruit[i_ind, i_ct];
        }
    }
}