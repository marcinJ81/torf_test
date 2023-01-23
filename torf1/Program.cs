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
        public DateTime? WP_StartDate { get; set; }
        public DateTime? WP_EndData { get; set; }
        public Employee Employee { get; set; }
    }
    public class RCP
    {
        public int RCP_id { get; set; }
        public DateTime? RCP_StartDate { get; set; }
        public DateTime? RCP_EndDAta { get; set; }
        public TimeSpan RCP_Realization { get; set; }
        public bool RCP_DaysPayCounted { get; set; }
        public Employee Employee { get; set; }
    }

    public class Realization
    { 
        public bool CompletingTheDaysWork(DateTime startDate, DateTime endDate)
        {
            if(startDate.TimeOfDay >= endDate.TimeOfDay)
            {
                return false;
            }
            else
            {
                var workTime = endDate.TimeOfDay - startDate.TimeOfDay;
                TimeSpan eightHourDay = new TimeSpan(0, 8, 0, 0);
                if(workTime == eightHourDay)
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