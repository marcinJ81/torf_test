using System.Security.Cryptography.X509Certificates;

namespace torf1
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }
    public class WorkPlan
    {
        public int WP_id { get; set; }
        public TimeSpan WP_StartTime { get; set; }
        public TimeSpan WP_EndTime { get; set; }
        public TimeSpan WP_ShiftLength { get; set; }
        public Employee Employee { get; set; }
    }
    public class RCP
    {
        public int RCP_id { get; set; }
        public TimeSpan RCP_StartRealTimeStart { get; set; }
        public TimeSpan RCP_EndRealTimeStart { get; set; }
        public TimeSpan RCP_RealizationTolerance { get; set; }    
        public bool RCP_DaysPayCounted { get; set; }
        public Employee Employee { get; set; }
    }

    public class Realization
    {
        private RCP RCP { get; set; }
        private WorkPlan WorkPlan { get; set; }
        private Employee Employee { get; set; }

        public Realization(RCP rCP, WorkPlan workPlan, Employee employee)
        {
            RCP = rCP;
            WorkPlan = workPlan;
            Employee = employee;
        }

        public void SetDaysPayCounted()
        {
            var result = CompletingTheDaysWork(DateTime.MinValue + RCP.RCP_StartRealTimeStart, DateTime.MinValue + RCP.RCP_EndRealTimeStart);
            if(result)
            {
                RCP.RCP_DaysPayCounted = result;
            }
            else
            {
                RCP.RCP_DaysPayCounted = result;
            }
        }

        public RCP GetRCPDay()
        {
            return RCP;
        }

        public bool CompletingTheDaysWork(DateTime startDate, DateTime endDate)
        {
            if(startDate.TimeOfDay >= endDate.TimeOfDay)
            {
                return false;
            }
            else
            {
                TimeSpan fifteenMinuteTolerance = new TimeSpan(0,15,0);
                var workTime = endDate.TimeOfDay - startDate.TimeOfDay;
                TimeSpan eightHourDay = new TimeSpan(0, 8, 0, 0);
                TimeSpan startShiftWitTolerence = new TimeSpan(6, 0, 0) - fifteenMinuteTolerance;
                TimeSpan endShiftWithTolerence = new TimeSpan(14, 0, 0) + fifteenMinuteTolerance;
                if ((workTime >= eightHourDay) 
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
            Console.WriteLine("Hello, World!");
        }
    }
}