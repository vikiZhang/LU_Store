using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_V1.Model
{
    public class Disbursement
    {
        private string item{get;set;}
        private string department{get;set;}
        private int qty { get; set; }
        private int actualQty { get; set; }
    }
}