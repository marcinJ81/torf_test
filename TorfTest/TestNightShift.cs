using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using torf1;
using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;
using TorfTest.DifferentTypesOfShifts;

namespace TorfTest
{
    public class TestShifts
    {
       
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(NightShiftWorkdayCounted))]
        public void WorkdayCountedNightShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsTrue(realization.GetRCPDay().RCP_DaysPayCounted);
        }

        [TestCaseSource(typeof(NightShiftWorkdayNotCounted))]
        public void WorkdayNotCountedNightShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsFalse(realization.GetRCPDay().RCP_DaysPayCounted);
        }

        [TestCaseSource(typeof(AfternoonShiftworkdayCounted))]
        public void WorkdayCountedAfternoonShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsTrue(realization.GetRCPDay().RCP_DaysPayCounted);
        }

        [TestCaseSource(typeof(AfternoonShiftworkdayNotCounted))]
        public void WorkdayNotCountedAfternoonShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsFalse(realization.GetRCPDay().RCP_DaysPayCounted);
        }

        [TestCaseSource(typeof(DayShiftWorkdayCounted))]
        public void WorkdayCountedDayShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsTrue(realization.GetRCPDay().RCP_DaysPayCounted);
        }

        [TestCaseSource(typeof(DayShiftWorkdayNotCounted))]
        public void WorkdayNotCountedDayShift(Realization realization)
        {
            realization.SetDaysPayCounted();
            Assert.IsFalse(realization.GetRCPDay().RCP_DaysPayCounted);
        }

    }
}
