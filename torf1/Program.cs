using torf1.WorkingTtimeRegistrationSystem;
using torf1.WorkPlanForRCP;
namespace torf1
{
    public class Realization
    {
        private RCP RCP { get; set; }
        private WorkPlan WorkPlan { get; set; }

        public Realization(RCP rCP, WorkPlan workPlan)
        {
            RCP = rCP;
            WorkPlan = workPlan;
        }

        public void SetDaysPayCounted()
        {
            var result = CompletingTheDaysWork(DateTime.MinValue + RCP.RCP_StartRealTimeStart, DateTime.MinValue + RCP.RCP_EndRealTimeStart);
            RCP.RCP_DaysPayCounted = result;
        }

        public RCP GetRCPDay()
        {
            return RCP;
        }

        public bool CompletingTheDaysWork(DateTime startDate, DateTime endDate)
        {
            if (startDate.TimeOfDay >= endDate.TimeOfDay)
            {
                return false;
            }
            else
            {
                var workTime = endDate.TimeOfDay - startDate.TimeOfDay;
                TimeSpan startShiftWitTolerence = WorkPlan.WP_StartTime - RCP.RCP_RealizationTolerance;
                TimeSpan endShiftWithTolerence = WorkPlan.WP_EndTime + RCP.RCP_RealizationTolerance;
                if ((workTime >= WorkPlan.WP_ShiftLength)
                    && (startDate.TimeOfDay >= startShiftWitTolerence && endDate.TimeOfDay <= endShiftWithTolerence))
                {
                    return true;
                }
                return false;
            }
        }
    }

    internal class Program
    {
        //Zakładam firmę będe wydobywał torf i sprzedawał
        //zatrudniam pierwszego pracownika
        //Stefan, będzie pracował 8 godzin dziennie od poniedziałku do piątku
        //Musze sprawdzać czy jest w pracy, żeby mu wypłate policzyć
        static void Main(string[] args)
        {

        }
    }
}