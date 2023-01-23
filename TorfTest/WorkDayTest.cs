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

        [Test]
        public void WorkdayNotCountedBadReflection()
        {
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0, 0);
            DateTime endDate = new DateTime(2023, 01, 23, 12, 0, 0);

            bool result = realiztion.CompletingTheDaysWork(endDate, startDate);

            Assert.IsFalse(result);
        }
    }
}