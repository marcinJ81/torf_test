using torf1;
namespace TorfTest
{
    public class Tests
    {
        Realization realiztion = new Realization();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CompletDayWork()
        {
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0,0);
            DateTime endDate = new DateTime(2023, 01, 23, 14, 0,0);

            bool result = realiztion.CompletingTheDaysWork(startDate, endDate);

            Assert.IsTrue(result);
        }

        [Test]
        public void DayWorkNotCompleted()
        {
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0, 0);
            DateTime endDate = new DateTime(2023, 01, 23, 12, 0, 0);

            bool result = realiztion.CompletingTheDaysWork(startDate, endDate);

            Assert.IsFalse(result);
        }

        [TestCase("2023-01-23 5:40:0", "2023-01-23 14:0:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:16:0")]
        [TestCase("2023-01-23 6:15:0", "2023-01-23 13:59:0")]
        public void WorkdayNotCountedBadReflection(DateTime startDate, DateTime endDate)
        {
            bool result = realiztion.CompletingTheDaysWork(startDate,endDate);

            Assert.IsFalse(result);
        }


        [TestCase("2023-01-23 5:45:0", "2023-01-23 14:0:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:15:0")]
        [TestCase("2023-01-23 6:00:0", "2023-01-23 14:00:0")]
        public void WorkdayCountedEntryToWorkBeforeTheStartOfTheShift(DateTime startDate, DateTime endDate)
        {
            bool result = realiztion.CompletingTheDaysWork(startDate, endDate);

            Assert.IsTrue(result);
        }
    }
}