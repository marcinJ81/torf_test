using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torf1.WorkingTtimeRegistrationSystem
{
    public class RCP
    {
        public int RCP_id { get; private set; }
        public TimeSpan RCP_StartRealTimeStart { get; private set; }
        public TimeSpan RCP_EndRealTimeStart { get; private set; }
        public TimeSpan RCP_RealizationTolerance { get; private set; }
        public bool RCP_DaysPayCounted { get; set; }

        public RCP(int rCP_id, TimeSpan rCP_StartRealTimeStart, TimeSpan rCP_EndRealTimeStart, TimeSpan rCP_RealizationTolerance, bool rCP_DaysPayCounted)
        {
            RCP_id = rCP_id;
            RCP_StartRealTimeStart = rCP_StartRealTimeStart;
            RCP_EndRealTimeStart = rCP_EndRealTimeStart;
            RCP_RealizationTolerance = rCP_RealizationTolerance;
            RCP_DaysPayCounted = rCP_DaysPayCounted;
        }
    }
}
