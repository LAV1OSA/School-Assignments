using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using GlobalComputerSolutionsDb.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobalComputerSolutionsDb.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> d)
        {
            d.ToTable("Employee");

            d.Property(c => c.FirstName).HasMaxLength(100);
            d.Property(c => c.MiddleName).HasMaxLength(100);
            d.Property(c => c.LastName).HasMaxLength(100);
            d.Property(c => c.Telephone).HasMaxLength(50);

            var employees = GenerateData();

            d.HasData(employees);
        }

        public List<Employee> GenerateData()
        {
            var list = new List<Employee>();

            var faker = new Faker();

            for (int i = 1; i <= 1000; i++)
            {
                var employee = new Employee();
                employee.FirstName = faker.Name.FullName();
                employee.MiddleName = faker.Name.LastName();
                employee.LastName = faker.Name.LastName();
                employee.ManagerId = faker.Random.Number(1, 200);
                employee.Telephone = faker.Phone.PhoneNumber();
                employee.RegionId = faker.Random.Number(1, 6);

                list.Add(employee);
            }

            return list;
        }
    }
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> d)
        {
            d.ToTable("Project");

            d.Property(c => c.Description).HasMaxLength(200);


            var projects = GenerateData();

            d.HasData(projects);
        }

        public List<Project> GenerateData()
        {
            var list = new List<Project>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var project = new Project();
                project.Description = faker.Random.Words(3);
                project.ManagerId = (i % 1000) + 1;
                project.CustomerId = (i % 1000) + 1 + (int)Math.Floor(i/1000f);
                project.DateSigned = faker.Date.Past();
                project.EstimatedDateStart = faker.Date.Past(5);
                project.EstimatedDateEnd = project.EstimatedDateStart.AddDays(faker.Random.Number(100,1000));
                project.EstimatedBudget = (float)faker.Finance.Amount(1000000, 100000000);
                project.DateStart = project.EstimatedDateStart.AddDays(faker.Random.Number(0, 30));
                project.DateEnd = project.EstimatedDateEnd.AddDays(faker.Random.Number(0, 100));

                list.Add(project);
            }

            return list;
        }
    }
    public class GcsTaskConfiguration : IEntityTypeConfiguration<GcsTask>
    {
        public void Configure(EntityTypeBuilder<GcsTask> d)
        {
            d.ToTable("GcsTask");

            d.Property(c => c.Description).HasMaxLength(200);

            var gcsTasks = GenerateData();

            d.HasData(gcsTasks);

        }

        public List<GcsTask> GenerateData()
        {
            var list = new List<GcsTask>();

            var faker = new Faker();

            for (int i = 1; i <= 1000; i++)
            {
                var gcsTask = new GcsTask();
                gcsTask.Description = faker.Random.Words(3);
                gcsTask.ProjectScheduleId = faker.Random.Number(1, 3000);
                gcsTask.DateStart = faker.Date.Past(5);
                gcsTask.DateEnd = gcsTask.DateStart.AddDays(faker.Random.Number(5, 10));
                list.Add(gcsTask);
            }

            return list;
        }

    }
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> d)
        {
            d.ToTable("Skill");

            d.Property(c => c.Description).HasMaxLength(200);

            var skills = GenerateData();

            d.HasData(skills);
        }

        public List<Skill> GenerateData()
        {
            var list = new List<Skill>();

            var faker = new Faker();

            for (int i = 1; i <= 1000; i++)
            {
                var skill = new Skill();
                skill.Description = faker.Random.Words(3);
                skill.PayRate = (float)faker.Finance.Amount(500);
                list.Add(skill);
            }

            return list;
        }
    }
    public class ProjectScheduleConfiguration : IEntityTypeConfiguration<ProjectSchedule>
    {
        public void Configure(EntityTypeBuilder<ProjectSchedule> d)
        {
            d.ToTable("ProjectSchedule");

            var projectSchedules = GenerateData();

            d.HasData(projectSchedules);
        }
        public List<ProjectSchedule> GenerateData()
        {
            var list = new List<ProjectSchedule>();

            var faker = new Faker();

            for (int i = 1; i <= 1000; i++)
            {
                var projectSchedule = new ProjectSchedule();
                projectSchedule.ProjectId = (i % 1000) + 1;
                //projectSchedule.ManagerId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                projectSchedule.Description = faker.Random.Words(3);
                list.Add(projectSchedule);
            }

            return list;
        }
    }
    public class ProjectCostConfiguration : IEntityTypeConfiguration<ProjectCost>
    {
        public void Configure(EntityTypeBuilder<ProjectCost> d)
        {
            d.ToTable("ProjectCost");

            var projectSchedules = GenerateData();

            d.HasData(projectSchedules);
        }
        public List<ProjectCost> GenerateData()
        {
            var list = new List<ProjectCost>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var projectCost = new ProjectCost();
                projectCost.ProjectId = faker.Random.Number(1, 3000);
                //projectSchedule.ManagerId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                projectCost.DateEnding = faker.Date.Past(5);
                list.Add(projectCost);
            }

            return list;
        }
    }
    public class SkillInventoryConfiguration : IEntityTypeConfiguration<SkillInventory>
    {
        public void Configure(EntityTypeBuilder<SkillInventory> d)
        {
            d.ToTable("SkillInventory"); 
            
            var skillInventories = GenerateData();

            d.HasData(skillInventories);

        }

        public List<SkillInventory> GenerateData()
        {
            var list = new List<SkillInventory>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var skillInventory = new SkillInventory();
                skillInventory.EmployeeId = (i % 1000) + 1;
                skillInventory.SkillId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                skillInventory.DateEarned = faker.Date.Past(20);
                list.Add(skillInventory);
            }

            return list;
        }
    }
    public class TaskSkillConfiguration : IEntityTypeConfiguration<TaskSkill>
    {
        public void Configure(EntityTypeBuilder<TaskSkill> d)
        {
            d.ToTable("TaskSkill");

            var taskSkills = GenerateData();

            d.HasData(taskSkills);
        }
        public List<TaskSkill> GenerateData()
        {
            var list = new List<TaskSkill>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var taskSkill = new TaskSkill();
                taskSkill.GcsTaskId = (i % 1000) + 1;
                taskSkill.SkillId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                taskSkill.Quantity = faker.Random.Number(1,5);
                list.Add(taskSkill);
            }

            return list;
        }

    }
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> d)
        {
            d.ToTable("Assignment");

            var assignments = GenerateData();

            d.HasData(assignments);
        }

        public List<Assignment> GenerateData()
        {
            var list = new List<Assignment>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var assignment = new Assignment();
                assignment.GcsTaskId = (i % 1000) + 1;
                assignment.EmployeeId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                assignment.DateStarted = faker.Date.Past(5);
                if (assignment.DateStarted != null) assignment.DateEnded = faker.Date.Soon(10,assignment.DateStarted);
                list.Add(assignment);
            }

            return list;
        }

    }
    public class WorkLogConfiguration : IEntityTypeConfiguration<WorkLog>
    {
        public void Configure(EntityTypeBuilder<WorkLog> d)
        {
            d.ToTable("WorkLog");

            d.HasIndex(c => new { c.WeekEnding, c.AssignmentId }).IsUnique();

            var workLogs = GenerateData();

            d.HasData(workLogs);
        }
        public List<WorkLog> GenerateData()
        {
            var list = new List<WorkLog>();

            var faker = new Faker();

            for (int i = 1; i <= 3000; i++)
            {
                var workLog = new WorkLog();
                workLog.AssignmentId = (i % 1000) + 1;
                workLog.BillId = (i % 1000) + 1 + (int)Math.Floor(i / 1000f);
                workLog.HoursWorked = faker.Random.Number(0, 24);
                workLog.WeekEnding = faker.Date.Past(5);
                if (workLog.WeekEnding.DayOfWeek == DayOfWeek.Friday)
                {
                    workLog.WeekEnding = workLog.WeekEnding.AddDays(faker.Random.Number(0, 5));
                }
                else
                {
                    workLog.WeekEnding = workLog.WeekEnding.AddDays(workLog.WeekEnding.DayOfWeek - DayOfWeek.Friday);
                }
                list.Add(workLog);
            }

            return list;
        }

    }
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> d)
        {
            d.ToTable("Bill");

            //var skillInventories = GenerateData();

            //d.HasData(skillInventories);

        }
    }
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> d)
        {
            d.ToTable("Customer");

            d.Property(c => c.FirstName).HasMaxLength(100);
            d.Property(c => c.MiddleName).HasMaxLength(100);
            d.Property(c => c.LastName).HasMaxLength(100);
            d.Property(c => c.Telephone).HasMaxLength(50);

            //var skillInventories = GenerateData();

            //d.HasData(skillInventories);

        }
    }
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> d)
        {
            d.ToTable("Region");

            d.Property(c => c.Name).HasMaxLength(100);

            //var skillInventories = GenerateData();

            //d.HasData(skillInventories);

        }
    }
}
