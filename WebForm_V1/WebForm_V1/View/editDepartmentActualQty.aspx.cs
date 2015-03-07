using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;

namespace WebForm_V1.View
{
    public partial class editDepartmentActualQty : System.Web.UI.Page
    {
        ProcessRetrievalFormController processControl = new ProcessRetrievalFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            disbursementListView.DataSource = processControl.getList(//use session to pass the itemcode from previous page);
                disbursementListView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            processControl.
        }
    }
}