using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarvanPlan.Models
{
    public class PlanEntities
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int Ay { get; set; }
        public double Plan { get; set; }
        public double NetSatish { get; set; }
        public double PlanFaiz { get; set; }
    }
}
