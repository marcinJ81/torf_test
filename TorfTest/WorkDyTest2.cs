using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using torf1;
using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;

namespace TorfTest
{
    public class WorkDyTest2
    {
        Realization realizationSecondShift = new Realization(
          new RCP()
          {
              RCP_id = 1,
              RCP_DaysPayCounted = false,
              RCP_EndRealTimeStart = new TimeSpan(22, 5, 0),
              RCP_StartRealTimeStart = new TimeSpan(13, 55, 0),
              RCP_RealizationTolerance = new TimeSpan(0, 15, 0)
          }
        , new WorkPlan(1, new TimeSpan(14, 0, 0), new TimeSpan(22, 0, 0), new TimeSpan(8, 0, 0)));

        Realization realizationSecondShiftBad = new Realization(
          new RCP()
          {
              RCP_id = 1,
              RCP_DaysPayCounted = false,
              RCP_EndRealTimeStart = new TimeSpan(22, 0, 0),
              RCP_StartRealTimeStart = new TimeSpan(14, 15, 0),
              RCP_RealizationTolerance = new TimeSpan(0, 15, 0)
          }
        , new WorkPlan(1, new TimeSpan(14, 0, 0), new TimeSpan(22, 0, 0), new TimeSpan(8, 0, 0)));

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WorkdayCounted()
        {
            realizationSecondShift.SetDaysPayCounted();
            Assert.IsTrue(realizationSecondShift.GetRCPDay().RCP_DaysPayCounted);
        }

        [Test]
        public void WorkdayNotCounted()
        {
            realizationSecondShiftBad.SetDaysPayCounted();
            Assert.IsFalse(realizationSecondShiftBad.GetRCPDay().RCP_DaysPayCounted);
        }

    }
}
