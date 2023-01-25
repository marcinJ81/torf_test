using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torf1.WorkPlanForRCP
{
    public class WorkPlan
    {
        public int WP_id { get; set; }
        public TimeSpan WP_StartTime { get; set; }
        public TimeSpan WP_EndTime { get; set; }
        public TimeSpan WP_ShiftLength { get; set; }
    }
}
