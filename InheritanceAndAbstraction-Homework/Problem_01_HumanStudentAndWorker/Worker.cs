using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_HumanStudentAndWorker
{
    public class Worker : Human
    {

        public Worker(string firstName,string lastName,double weekSalary,double workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double daySalary = this.WeekSalary / 5;
            double moneyPerHour = daySalary / this.WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return "Worker: "+base.ToString()+string.Format(" Daily salary - {0:F2} lv.",this.MoneyPerHour());
        }
    }
}
