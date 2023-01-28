using torf1;
using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;

namespace TorfTest
{
    public class Tests
    {
        Realization realization = new Realization(
          new RCP() 
          {
            RCP_id = 1,
            RCP_DaysPayCounted = false,
            RCP_EndRealTimeStart = new TimeSpan(14,5,0),
            RCP_StartRealTimeStart = new TimeSpan(5,55,0),
            RCP_RealizationTolerance = new TimeSpan(0,15,0)
          }
        , new WorkPlan(1, new TimeSpan(6,0,0), new TimeSpan(14,0,0), new TimeSpan(8,0,0)));
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void CompletDayWork()
        {
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0,0);
            DateTime endDate = new DateTime(2023, 01, 23, 14, 0,0);

            bool result = realization.CompletingTheDaysWork(startDate, endDate);
            Assert.IsTrue(result);
        }

        [Test]
        public void DayWorkNotCompleted()
        {
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0, 0);
            DateTime endDate = new DateTime(2023, 01, 23, 12, 0, 0);

            bool result = realization.CompletingTheDaysWork(startDate, endDate);
            Assert.IsFalse(result);
        }

        [TestCase("2023-01-23 5:40:0", "2023-01-23 14:0:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:16:0")]
        [TestCase("2023-01-23 6:15:0", "2023-01-23 13:59:0")]
        public void WorkdayNotCountedBadReflection(DateTime startDate, DateTime endDate)
        {
            bool result = realization.CompletingTheDaysWork(startDate,endDate);

            Assert.IsFalse(result);
        }


        [TestCase("2023-01-23 5:45:0", "2023-01-23 14:0:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:15:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:00:0")]
        public void WorkdayCounted(DateTime startDate, DateTime endDate)
        {
            bool result = realization.CompletingTheDaysWork(startDate, endDate);

            Assert.IsTrue(result);
        }

        [Test]
        public void WorkdayCounted()
        {
            realization.SetDaysPayCounted();
            Assert.IsTrue(realization.GetRCPDay().RCP_DaysPayCounted);
        }
    }
}