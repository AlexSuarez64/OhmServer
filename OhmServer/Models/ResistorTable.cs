using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OhmServer.Models
{
    public class ResistorTable
    {
        public string RingName { get; set; }
        public string RingCode { get; set; }
        public string RingRAL { get; set; }
        public string SignificantFigures { get; set; }
        public double Multiplier { get; set; }
        public double Percent { get; set; }
    }
}

