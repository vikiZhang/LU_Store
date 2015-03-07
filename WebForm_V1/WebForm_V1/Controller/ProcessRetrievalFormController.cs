using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForm_V1.Model;

namespace WebForm_V1.Controller
{
    public class ProcessRetrievalFormController
    {
        public List<RetrievalItems> getRequisitionInfr() 
        {
            //business enetities: RetrievalItems
            //get all the items of requisitions(group by item)
            //expected type: RetrievalItems
            return null;
        }

        public void setRequisitionStatus() 
        {
            //entity:
        }

        public List<RetrievalItems> getProcessedItems() 
        {
            //
            //get all items that are processed(The same as 'getAllProcessedItems')
            //
            return null;
        }


       
        //override
        public List<RetrievalItems> getProcessedItems(DateTime dt)
        {
            //
            //get all items that are processed for selecting date
            //
            return null;
        }

        //ouveride
        public void setRequisitionStatus(RetrievalItems reitems) 
        { 
            //entities:
            //set requisition status collected and set actual qty;
            //expected type:
        }
        public List<Disbursement> getList(String item) 
        {
            //entity:requisition,requisition_detail, item ,department
            //when click "edit" of one item, it will come to another UI that shows the departments' qty and 
            // actualQty of the that item 
            return null;
        }

        


        public void creatDisbursementList(Disbursement disbursement)
        { 
            //entity:Disbursement 
            //click'confirm collected from store' then create it
        }

        
       

    }
}