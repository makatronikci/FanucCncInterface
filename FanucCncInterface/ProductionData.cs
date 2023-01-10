using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCncInterface
{
    public class ProductionData
    {
        public int CycleH { get; set; }
        public int CycleM { get; set; }
        public int CycleS { get; set; }
        public int TotalCycleH { get; set; }
        public int TotalCycleM { get; set; }
        public int TotalCycleS { get; set; }
        public int PartCounter { get; set; }
        public bool CycleSignal { get; set; }
        public bool AlarmSignal { get; set; }
        public int Tool { get; set; }
        public int Program { get; set; }
    }
}
