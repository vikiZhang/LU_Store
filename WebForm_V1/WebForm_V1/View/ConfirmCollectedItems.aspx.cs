using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;

namespace WebForm_V1.View
{
    public partial class ConfirmCollectedItems : System.Web.UI.Page
    {
        ProcessRetrievalFormController processControl=new ProcessRetrievalFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            ProcessedDate.Text="All";
            ConfirmItemsView.DataSource = processControl.getRequisitionInfr();
            ConfirmItemsView.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            ProcessedDate.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }


        protected void printbtn_Click(object sender, EventArgs e)
        {

        }

        protected void Confirmbtn_Click(object sender, EventArgs e)
        {
            processControl.creatDisbursementList();
        }

        
    }
}