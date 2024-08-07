using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }

        public static bool SalaryPromotionCriteria(Employee emp)
        {
            return emp.Salary < 10000;
        }

        public static bool ExperiencePromotionCriteria(Employee emp)
        {
            return emp.Experience > 5;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}, Gender: {Gender}, Experience: {Experience}";
        }
    }

    public class EmployeePromotion
    {
        public List<Employee> PromoteEmployees(List<Employee> employees, Func<Employee, bool> promotionCriteria)
        {
            List<Employee> promotedEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (promotionCriteria(employee))
                {
                    promotedEmployees.Add(employee);
                }
            }
            return promotedEmployees;
        }
    }
}
