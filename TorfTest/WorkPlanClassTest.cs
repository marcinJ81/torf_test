using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using torf1.Enums;
using torf1.WorkPlanForRCP;

namespace TorfTest
{
    public class WorkPlanClassTest
    {
        public static object[] DivideCases =
        {
            new WorkPlan(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0)),
            new WorkPlan(2, new TimeSpan(14, 0, 0), new TimeSpan(22, 0, 0), new TimeSpan(8, 0, 0)),
            new WorkPlan(3, new TimeSpan(22, 0, 0), new TimeSpan(6, 0, 0), new TimeSpan(8, 0, 0))
        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldSetCorrectEmptyShifts()
        {
            WorkPlan workPlanTest = new WorkPlan();
            Assert.That((int)workPlanTest.ShiftType, Is.EqualTo((int)ShiftType.empty));
        }

        [TestCaseSource(nameof(DivideCases))]
        public void ShouldSetCorrectShift(WorkPlan workPlan)
        {
            if(workPlan.WP_id == 1 )
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.daily));
            if(workPlan.WP_id == 2)
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.afternoon));
            if(workPlan.WP_id == 3)
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.night));
        }

        [TestCaseSource(typeof(DivideCasesClass))]
        public void ShouldSetCorrectShiftIEnumerableTest(WorkPlan workPlan)
        {
            if (workPlan.WP_id == 1)
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.daily));
            if (workPlan.WP_id == 2)
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.afternoon));
            if (workPlan.WP_id == 3)
                Assert.That((int)workPlan.ShiftType, Is.EqualTo((int)ShiftType.night));
        }
    }

    public class DivideCasesClass : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new WorkPlan(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0));
            yield return new WorkPlan(2, new TimeSpan(14, 0, 0), new TimeSpan(22, 0, 0), new TimeSpan(8, 0, 0));
            yield return new WorkPlan(3, new TimeSpan(22, 0, 0), new TimeSpan(6, 0, 0), new TimeSpan(8, 0, 0));
        }
    }
}
