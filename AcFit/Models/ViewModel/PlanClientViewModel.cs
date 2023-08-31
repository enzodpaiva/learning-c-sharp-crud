using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcFit.Models.ViewModel
{
    public class PlanClientViewModel
    {
        public Client Usuario { get; set; }
        public List<Plan> Planos { get; set; }
    }
}