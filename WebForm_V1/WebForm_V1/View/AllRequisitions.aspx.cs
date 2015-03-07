using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;

namespace WebForm_V1.View
{
    public partial class AllRequisitions : System.Web.UI.Page
    {
        ViewRequisitionsController viewrecontrol = new ViewRequisitionsController();
        protected void Page_Load(object sender, EventArgs e)
        {
           allrequisitionsview.DataSource= viewrecontrol.getRequisitions();
           allrequisitionsview.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            requisitionDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        
       
    }
}