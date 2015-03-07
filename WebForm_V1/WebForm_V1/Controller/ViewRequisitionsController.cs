using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForm_V1.EF;

namespace WebForm_V1.Controller
{
    public class ViewRequisitionsController
    {
        public List<requisition> getRequisitions(){
            //entities: requisition,requisition_detail, item;
            //get all requisitions 
            //expected type: requsition
            return null;
        }

        public List<requisition>getRequisitions(DateTime dt)
        {
            //entities:requisition,requisition_detail, item;
            //get requisitions for selected date
            //expected type: requsition
            return null;
        }

        public List<requisition>getOutStandingRequisitions()
        {
            //entities:requisition,requisition_detail, item;
            //get requisitions that item's 
            //expected type: requsition
            return null;
        }


    }
}