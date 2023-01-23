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
            int employee_id = 1;
            DateTime startDate = new DateTime(2023, 01, 23, 6, 0);
            DateTime endDate = new DateTime(2023, 01, 23, 14, 0);

            realiztion.CompletingTheDaysWork(employee_id,)

            Assert.Pass();
        }
    }
}