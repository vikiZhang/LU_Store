using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_V1.Controller;
using Microsoft.Practices.Unity;
using WebForm_V1.Model;
using WebForm_V1.Interface;
namespace WebForm_V1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUnityContainer container = Global.container;
           
            //container.RegisterType<MainController>();
            //container.RegisterType<IEmployee, Employee>();

            MainController obj = container.Resolve<MainController>("main");
            obj.printEmployeeDetails();

        //    MainController obj = new MainController(new Employee());
        //    obj.printEmployeeDetails();
        }
    }
}