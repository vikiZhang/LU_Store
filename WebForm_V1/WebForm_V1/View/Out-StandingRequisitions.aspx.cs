using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;

namespace WebForm_V1.View
{
    public partial class Out_StandingRequisitions : System.Web.UI.Page
    {
        ViewRequisitionsController viewrecontrol = new ViewRequisitionsController();
        protected void Page_Load(object sender, EventArgs e)
        {
            outstandingrequisitionsview.DataSource = viewrecontrol.getOutStandingRequisitions();
            outstandingrequisitionsview.DataBind();
        }
    }
}