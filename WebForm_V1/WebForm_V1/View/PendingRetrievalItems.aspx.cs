using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;

namespace WebForm_V1.View
{
    public partial class PendingRetrievalItems : System.Web.UI.Page
    {
        ProcessRetrievalFormController processcontrol = new ProcessRetrievalFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            PendingRetrievalItemsView.DataSource = processcontrol.getRequisitionInfr();
            PendingRetrievalItemsView.DataBind();
        }

        protected void Processbtn_Click(object sender, EventArgs e)
        {
            processcontrol.setRequisitionStatus();
        }

      
    }
}