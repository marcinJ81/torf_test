using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torf1.WorkingTtimeRegistrationSystem
{
    public class RCP
    {
        public int RCP_id { get; set; }
        public TimeSpan RCP_StartRealTimeStart { get; set; }
        public TimeSpan RCP_EndRealTimeStart { get; set; }
        public TimeSpan RCP_RealizationTolerance { get; set; }
        public bool RCP_DaysPayCounted { get; set; }
    }
}
