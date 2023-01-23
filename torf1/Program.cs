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
        public DateTime? WP_EndDAta { get; set; }
        public Employee Employee { get; set; }
    }
    public class RCP
    {
        public int RCP_id { get; set; }
        public DateTime? RCP_StartDate { get; set; }
        public DateTime? RCP_EndDAta { get; set; }
        public Employee Employee { get; set; }
    }

    public class Realization
    {
        public bool CompletingTheDaysWork(int empid, DateTime startDate, DateTime endDate)
        {
            return false;
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

        public bool CompletingTheDaysWork(DateTime startDate, DateTime endDate)
        {
            return false;
        }
    }
}