using torf1;
using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;

namespace TorfTest
{
    public class Tests
    {
        Realization realization = new Realization(
          new RCP(1, new TimeSpan(14, 5, 0), new TimeSpan(5, 55, 0), new TimeSpan(0, 15, 0), false)
        , new WorkPlan(1, new TimeSpan(6, 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0)));
        [SetUp]
        public void Setup()
        {
        }

    }
}