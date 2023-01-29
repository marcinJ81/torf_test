using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using torf1.Enums;

namespace torf1.WorkPlanForRCP
{
    public class WorkPlan
    {
        public int WP_id {  get; private set; }
        public TimeSpan WP_StartTime { get; private set; }
        public TimeSpan WP_EndTime { get; private set; }
        public TimeSpan WP_ShiftLength { get; private set; }
        public ShiftType ShiftType 
        {
            get
            {
                if (WP_StartTime == new TimeSpan(6, 0, 0) && WP_EndTime == new TimeSpan(14, 0, 0))
                    return ShiftType.daily;
                if (WP_StartTime == new TimeSpan(14, 0, 0) && WP_EndTime == new TimeSpan(22, 0, 0))
                    return ShiftType.afternoon;
                if (WP_StartTime == new TimeSpan(22, 0, 0) && WP_EndTime == new TimeSpan(6, 0, 0))
                    return ShiftType.night;
                return ShiftType.empty;
            }
        }

        public WorkPlan() { }

        public WorkPlan(int wP_id, TimeSpan wP_StartTime, TimeSpan wP_EndTime, TimeSpan wP_ShiftLength)
        {
            WP_id = wP_id;
            WP_StartTime = wP_StartTime;
            WP_EndTime = wP_EndTime;
            WP_ShiftLength = wP_ShiftLength;
        }
    }
}
