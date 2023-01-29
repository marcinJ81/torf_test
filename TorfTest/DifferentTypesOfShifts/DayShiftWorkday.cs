using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;
using torf1;

namespace TorfTest.DifferentTypesOfShifts
{
    public class DayShiftWorkdayCounted : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new Realization
               (
                 new RCP(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 00, 0), new TimeSpan(0, 15, 0), false)
                 , new WorkPlan(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
               );
            yield return new Realization
              (
                new RCP(2, new TimeSpan(5, 45, 0), new TimeSpan(14, 15, 0), new TimeSpan(0, 15, 0), false)
                , new WorkPlan(2, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
              );
        }
    }
    public class DayShiftWorkdayNotCounted : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            yield return new Realization
            (
              new RCP(1, new TimeSpan(5, 44, 0), new TimeSpan(14, 00, 0), new TimeSpan(0, 15, 0), false)
              , new WorkPlan(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
            );
            yield return new Realization
              (
                new RCP(2, new TimeSpan(6, 0, 0), new TimeSpan(14, 19, 0), new TimeSpan(0, 15, 0), false)
                , new WorkPlan(2, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
              );
            yield return new Realization
              (
                new RCP(3, new TimeSpan(6, 0, 0), new TimeSpan(13, 59, 0), new TimeSpan(0, 15, 0), false)
                , new WorkPlan(3, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
              );
            yield return new Realization
              (
                new RCP(4, new TimeSpan(6, 1, 0), new TimeSpan(14, 0, 0), new TimeSpan(0, 15, 0), false)
                , new WorkPlan(4, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
              );
            yield return new Realization
              (
                new RCP(5, new TimeSpan(6, 1, 0), new TimeSpan(14, 40, 0), new TimeSpan(0, 15, 0), false)
                , new WorkPlan(5, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0))
              );
        }
    }
}
