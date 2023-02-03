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
            var result = CompletingTheDaysWork();
            RCP.RCP_DaysPayCounted = result;
        }

        public RCP GetRCPDay()
        {
            return RCP;
        }

        private bool CompletingTheDaysWork()
        {
            TimeSpan startShiftWitTolerence = WorkPlan.WP_StartTime - RCP.RCP_RealizationTolerance;
            TimeSpan endShiftWithTolerence = WorkPlan.WP_EndTime + RCP.RCP_RealizationTolerance;
            TimeSpan twentyFourHours = new TimeSpan(24, 0, 0);
         
            if (RCP.RCP_StartRealTimeStart >= RCP.RCP_EndRealTimeStart && WorkPlan.ShiftType == Enums.ShiftType.night)
            {

                var startTime = RCP.RCP_StartRealTimeStart;
                var endTime = RCP.RCP_EndRealTimeStart;
                endTime += twentyFourHours;
                var workTime = endTime - startTime;
                endShiftWithTolerence += twentyFourHours;

                if ((workTime >= WorkPlan.WP_ShiftLength)
                    && (startTime >= startShiftWitTolerence && endTime <= endShiftWithTolerence))
                {
                    return true;
                }
                return false;
            }
            else
            {
                var workTime = RCP.RCP_EndRealTimeStart - RCP.RCP_StartRealTimeStart;
                if ((workTime >= WorkPlan.WP_ShiftLength)
                    && (RCP.RCP_StartRealTimeStart >= startShiftWitTolerence && RCP.RCP_EndRealTimeStart <= endShiftWithTolerence))
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