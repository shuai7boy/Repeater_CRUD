using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Repeater实现增删改查
{
    public partial class Test : System.Web.UI.Page
    {
        //Page_Load这个事件 无论首次加载 还是点击按钮 都会执行 所有一定注意加IsPostBack进行判断
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 this.TextBox1.Text = "world";
             }
        }
           

        protected void Button1_Click(object sender, EventArgs e)
        {
            string rec=TextBox1.Text;
        }
    }
}