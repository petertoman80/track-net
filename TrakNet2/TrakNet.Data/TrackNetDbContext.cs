using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using TrakNet.Entities;

namespace TrakNet.Data
{
    public class TrackNetDbContext : DbContext //, ITrackNetDbContext
    {
        public DbSet<Activity> Activities { get; set; } // Activities
        public DbSet<Configurations> Configurations { get; set; } // Configurations
        public DbSet<Customer> Customers { get; set; } // Customers
        public DbSet<Expense> Expenses { get; set; } // expenses
        public DbSet<GlobalRole> GlobalRoles { get; set; } // globalroles
        public DbSet<Group> Groups { get; set; } // groups
        //public IDbSet<GroupsUsers> GroupsUsers { get; set; } // groups_users
        public DbSet<MembershipRole> MembershipRoles { get; set; } // MembershipRoles
        public DbSet<Preference> Preferences { get; set; } // preferences
        public DbSet<Project> Projects { get; set; } // projects
        public DbSet<Status> Statuses { get; set; } // statuses
        public DbSet<Timesheet> Timesheets { get; set; } // timesheet
        public DbSet<User> Users { get; set; } // users

        ///*
        static TrackNetDbContext()
        {
            Database.SetInitializer<TrackNetDbContext>(null);
            Database.SetInitializer<TrackNetDbContext>(new DropCreateDatabaseIfModelChanges<TrackNetDbContext>());
        }
        //*/
        public TrackNetDbContext()
            : base("Name=TrackNetDbContext")
        {
        }



        public TrackNetDbContext(string connectionString)
            : base(connectionString)
        {
        }

        ///*
        public TrackNetDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new ActivityConfigurations());
            //modelBuilder.Configurations.Add(new ConfigurationsConfigurations());
            //modelBuilder.Configurations.Add(new CustomerConfigurations());
            modelBuilder.Configurations.Add(new ExpenseConfigurations());
            //modelBuilder.Configurations.Add(new GlobalRoleConfigurations());
            //modelBuilder.Configurations.Add(new GroupConfigurations());
            //modelBuilder.Configurations.Add(new GroupsUsersConfigurations());
            //modelBuilder.Configurations.Add(new MembershiproleConfigurations());
            //modelBuilder.Configurations.Add(new PreferenceConfigurations());
            modelBuilder.Configurations.Add(new ProjectConfigurations());
            //modelBuilder.Configurations.Add(new StatusConfigurations());
            modelBuilder.Configurations.Add(new TimesheetConfigurations());
            //modelBuilder.Configurations.Add(new UserConfigurations());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            //modelBuilder.Configurations.Add(new ActivityConfigurations(schema));
            //modelBuilder.Configurations.Add(new ConfigurationsConfigurations(schema));
            //modelBuilder.Configurations.Add(new CustomerConfigurations(schema));
            modelBuilder.Configurations.Add(new ExpenseConfigurations(schema));
            //modelBuilder.Configurations.Add(new GlobalRoleConfigurations(schema));
            //modelBuilder.Configurations.Add(new GroupConfigurations(schema));
            //modelBuilder.Configurations.Add(new GroupsUsersConfigurations(schema));
            //modelBuilder.Configurations.Add(new MembershiproleConfigurations(schema));
            //modelBuilder.Configurations.Add(new PreferenceConfigurations(schema));
            modelBuilder.Configurations.Add(new ProjectConfigurations(schema));
            //modelBuilder.Configurations.Add(new StatusConfigurations(schema));
            modelBuilder.Configurations.Add(new TimesheetConfigurations(schema));
            //modelBuilder.Configurations.Add(new UserConfigurations(schema));
            return modelBuilder;
        }
        //*/
    }
}
