using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutionsDb.Core
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }

        //links
        public int ManagerId { get; set; }
        public Employee ManagerLink { get; set; }
        public int RegionId { get; set; }
        public Region RegionLink { get; set; }
        
        public ICollection<SkillInventory> SkillInventories { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Project
    {
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public DateTime DateSigned { get; set; }
        public DateTime EstimatedDateStart { get; set; }
        public DateTime EstimatedDateEnd { get; set; }
        public float EstimatedBudget { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }


        //links
        public int ManagerId { get; set; }
        public Employee ManagerLink { get; set; }
        public int CustomerId { get; set; }
        public Customer CustomerLink { get; set; }

        public ICollection<ProjectCost> ProjectCosts{ get; set; }
        public ICollection<ProjectSchedule> ProjectSchedules { get; set; }
        
    }
    public class ProjectSchedule
    {
        public int ProjectScheduleId { get; set; }
        public string Description { get; set; }
        public DateTime DateMade { get; set; }

        //links
        public int ProjectId { get; set; }
        public Project ProjectLink { get; set; }

        public ICollection<GcsTask> GcsTasks { get; set; }

    }
    public class GcsTask
    {
        public int GcsTaskId { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        //links
        public int ProjectScheduleId { get; set; }
        public ProjectSchedule ProjectScheduleLink { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<TaskSkill> TaskSkills { get; set; }
    }
    public class Skill
    {
        public int SkillId { get; set; }
        public string Description { get; set; }
        public float PayRate { get; set; }

        //links
        public ICollection<SkillInventory> SkillInventories { get; set; }
        public ICollection<TaskSkill> TaskSkills { get; set; }
    }
    public class Customer   
    {
        public int CustinerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }

        //links
        public int RegionId { get; set; }
        public Region RegionLink { get; set; }

        public ICollection<Bill> Bills { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
    public class Assignment 
    {
        public int ProjectId { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }

        //links
        public int EmployeeId { get; set; }
        public Employee EmplpoyeeLink { get; set; }
        public int GcsTaskId { get; set; }
        public GcsTask GcsTaskLink { get; set; }

        public ICollection<WorkLog> WorkLogs { get; set; }
    }
    public class WorkLog    
    {
        public int WorkLogId { get; set; }
        public int HoursWorked { get; set; }
        public DateTime WeekEnding { get; set; }

        //links
        public int AssignmentId { get; set; }
        public Assignment AssignmentLink { get; set; }
        public int BillId { get; set; }
        public Bill BillLink { get; set; }

    }
    public class Region 
    {
        public int RegionId { get; set; }
        public string Name { get; set; }

        //links
        public ICollection<Bill> Bills { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
    public class TaskSkill  
    {
        public int TaskSkillId { get; set; }
        public int Quantity { get; set; }

        //links
        public int GcsTaskId { get; set; }
        public GcsTask GcsTaskLink { get; set; }
        public int SkillId { get; set; }
        public Skill SkillLink { get; set; }
    }
    public class SkillInventory  
    {
        public int SkillInventoryId { get; set; }
        public DateTime DateEarned { get; set; }

        public int SkillId { get; set; }    
        public Skill SkillLink { get; set; }
        public int EmployeeId { get; set; }
        public Employee EmployeeLink { get; set; }
    }
    public class Bill  
    {
        public int BillId { get; set; }
        public DateTime DateSent { get; set; }

        //links
        public int CustomerId { get; set; }
        public Customer CustomerLink { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
    public class ProjectCost
    {
        public int ProjectCostId { get; set; }
        public float TotalCost { get; set; }
        public DateTime DateEnding { get; set; }

        //links
        public int ProjectId { get; set; }
        public Project ProjectLink { get; set; }
    }
}
