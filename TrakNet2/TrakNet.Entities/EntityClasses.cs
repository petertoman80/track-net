using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakNet.Entities
{
    // Activities
    public class Activity
    {
        //[Key]
        public int ActivityId { get; set; } // activityID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        public string Comment { get; set; } // comment
        [Required]
        public bool Visible { get; set; } // visible
        [Required]
        public bool Filter { get; set; } // filter
        [Required]
        public bool Trash { get; set; } // trash

        public Activity()
        {
            Visible = true;
            Filter = false;
            Trash = false;
        }
    }

    // Activities
    //internal class ActivityConfigurations : EntityTypeConfigurations<Activity>
    //{
    //    public ActivityConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".Activities");
    //        HasKey(x => x.ActivityId);

    //        Property(x => x.ActivityId).HasColumnName("activityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(255);
    //        Property(x => x.Comment).HasColumnName("comment").IsRequired();
    //        Property(x => x.Visible).HasColumnName("visible").IsRequired();
    //        Property(x => x.Filter).HasColumnName("filter").IsRequired();
    //        Property(x => x.Trash).HasColumnName("trash").IsRequired();
    //    }
    //}

    // Configurations
    public class Configurations
    {
        [Key, MaxLength(300)]
        public string Option { get; set; } // option (Primary key)
        [Required, MaxLength(300)]
        public string Value { get; set; } // value
    }

    // Configurations
    //internal class ConfigurationsConfigurations : EntityTypeConfigurations<Configurations>
    //{
    //    public ConfigurationsConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".Configurations");
    //        HasKey(x => x.Option);

    //        Property(x => x.Option).HasColumnName("option").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        Property(x => x.Value).HasColumnName("value").IsRequired().HasMaxLength(255);
    //    }
    //}

    // Customers
    public class Customer
    {
        public int CustomerId { get; set; } // customerID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        public string Password { get; set; } // password
        [Required, MaxLength(60)]
        public string Secure { get; set; } // secure
        [Required, MaxLength(500)]
        public string Comment { get; set; } // comment
        [Required]
        public bool Visible { get; set; } // visible
        [Required]
        public bool Filter { get; set; } // filter
        [Required, MaxLength(300)]
        public string Company { get; set; } // company
        [Required, MaxLength(300)]
        public string Vat { get; set; } // vat
        [Required, MaxLength(300)]
        public string Contact { get; set; } // contact
        [Required, MaxLength(300)]
        public string Street { get; set; } // street
        [Required, MaxLength(50)]
        public string Zipcode { get; set; } // zipcode
        [Required, MaxLength(300)]
        public string City { get; set; } // city
        [Required, MaxLength(100)]
        public string Phone { get; set; } // phone
        [Required, MaxLength(100)]
        public string Fax { get; set; } // fax
        [Required, MaxLength(100)]
        public string Mobile { get; set; } // mobile
        [Required, MaxLength(100)]
        public string Mail { get; set; } // mail
        [Required, MaxLength(300)]
        public string Homepage { get; set; } // homepage
        [Required, MaxLength(50)]
        public string Timezone { get; set; } // timezone
        public bool Trash { get; set; } // trash

        public Customer()
        {
            Password = "NULL";
            Secure = "N'0'";
            Visible = true;
            Filter = false;
            Trash = false;
        }
    }

    //// Customers
    //internal class CustomerConfigurations : EntityTypeConfigurations<Customer>
    //{
    //    public CustomerConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".Customers");
    //        HasKey(x => x.CustomerId);

    //        Property(x => x.CustomerId).HasColumnName("customerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(255);
    //        Property(x => x.Password).HasColumnName("password").IsOptional().HasMaxLength(255);
    //        Property(x => x.Secure).HasColumnName("secure").IsRequired().HasMaxLength(60);
    //        Property(x => x.Comment).HasColumnName("comment").IsRequired();
    //        Property(x => x.Visible).HasColumnName("visible").IsRequired();
    //        Property(x => x.Filter).HasColumnName("filter").IsRequired();
    //        Property(x => x.Company).HasColumnName("company").IsRequired().HasMaxLength(255);
    //        Property(x => x.Vat).HasColumnName("vat").IsRequired().HasMaxLength(255);
    //        Property(x => x.Contact).HasColumnName("contact").IsRequired().HasMaxLength(255);
    //        Property(x => x.Street).HasColumnName("street").IsRequired().HasMaxLength(255);
    //        Property(x => x.Zipcode).HasColumnName("zipcode").IsRequired().HasMaxLength(255);
    //        Property(x => x.City).HasColumnName("city").IsRequired().HasMaxLength(255);
    //        Property(x => x.Phone).HasColumnName("phone").IsRequired().HasMaxLength(255);
    //        Property(x => x.Fax).HasColumnName("fax").IsRequired().HasMaxLength(255);
    //        Property(x => x.Mobile).HasColumnName("mobile").IsRequired().HasMaxLength(255);
    //        Property(x => x.Mail).HasColumnName("mail").IsRequired().HasMaxLength(255);
    //        Property(x => x.Homepage).HasColumnName("homepage").IsRequired().HasMaxLength(255);
    //        Property(x => x.Timezone).HasColumnName("timezone").IsRequired().HasMaxLength(255);
    //        Property(x => x.Trash).HasColumnName("trash").IsRequired();
    //    }
    //}

    // expenses
    public class Expense
    {
        public int ExpenseId { get; set; } // expenseID (Primary key)
        [Required]
        public int Timestamp { get; set; } // timestamp
        //[ForeignKey("UserId")]
        [Column("UserId")]
        public User User { get; set; } // userID
        //[ForeignKey("ProjectId")]
        [Column("ProjectId")]
        public Project Project { get; set; } // projectID
        [Required]
        public string Designation { get; set; } // designation
        [Required]
        public string Comment { get; set; } // comment
        [Required]
        public short CommentType { get; set; } // commentType
        [Required]
        public bool Refundable { get; set; } // refundable
        public bool Cleared { get; set; } // cleared
        [Required]
        public decimal Multiplier { get; set; } // multiplier
        [Required]
        public decimal Value { get; set; } // value

        public Expense()
        {
            Timestamp = 0;
            CommentType = 0;
            Refundable = false;
            Cleared = false;
            Multiplier = 1.00m;
            Value = 0.00m;
        }
    }

    // expenses
    public class ExpenseConfigurations : EntityTypeConfiguration<Expense>
    {
        public ExpenseConfigurations(string schema = "dbo")
        {
            //ToTable(schema + ".expenses");
            //HasKey(x => x.ExpenseId);
            //Property(x => x.ExpenseId).HasColumnName("expenseID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(x => x.Timestamp).HasColumnName("timestamp").IsRequired();
            //Property(x => x.UserId).HasColumnName("userID").IsRequired();
            //Property(x => x.ProjectId).HasColumnName("projectID").IsRequired();
            //Property(x => x.Designation).HasColumnName("designation").IsRequired();
            //Property(x => x.Comment).HasColumnName("comment").IsRequired();
            //Property(x => x.CommentType).HasColumnName("commentType").IsRequired();
            //Property(x => x.Refundable).HasColumnName("refundable").IsRequired();
            //Property(x => x.Cleared).HasColumnName("cleared").IsRequired();
            Property(x => x.Multiplier).HasColumnName("Multiplier").IsRequired().HasPrecision(10, 2);
            Property(x => x.Value).HasColumnName("Value").IsRequired().HasPrecision(10, 2);
        }
    }

    // GlobalRoles
    public class GlobalRole
    {
        public int GlobalRoleId { get; set; } // GlobalRoleID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        public bool DebExtAccess { get; set; } // deb_ext-access
        public bool AdminPanelExtensionAccess { get; set; } // adminPanel_extension-access
        public bool BudgetAccess { get; set; } // ki_budget-access
        public bool ExpensesAccess { get; set; } // ki_expenses-access
        public bool ExportAccess { get; set; } // ki_export-access
        public bool InvoiceAccess { get; set; } // ki_invoice-access
        public bool TimesheetAccess { get; set; } // ki_timesheet-access
        public bool DemoExtAccess { get; set; } // demo_ext-access
        public bool CoreCustomerOtherGroupAdd { get; set; } // core-customer-otherGroup-add
        public bool CoreCustomerOtherGroupEdit { get; set; } // core-customer-otherGroup-edit
        public bool CoreCustomerOtherGroupDelete { get; set; } // core-customer-otherGroup-delete
        public bool CoreCustomerOtherGroupAssign { get; set; } // core-customer-otherGroup-assign
        public bool CoreCustomerOtherGroupUnassign { get; set; } // core-customer-otherGroup-unassign
        public bool CoreProjectOtherGroupAdd { get; set; } // core-project-otherGroup-add
        public bool CoreProjectOtherGroupEdit { get; set; } // core-project-otherGroup-edit
        public bool CoreProjectOtherGroupDelete { get; set; } // core-project-otherGroup-delete
        public bool CoreProjectOtherGroupAssign { get; set; } // core-project-otherGroup-assign
        public bool CoreProjectOtherGroupUnassign { get; set; } // core-project-otherGroup-unassign
        public bool CoreActivityOtherGroupAdd { get; set; } // core-activity-otherGroup-add
        public bool CoreActivityOtherGroupEdit { get; set; } // core-activity-otherGroup-edit
        public bool CoreActivityOtherGroupDelete { get; set; } // core-activity-otherGroup-delete
        public bool CoreActivityOtherGroupAssign { get; set; } // core-activity-otherGroup-assign
        public bool CoreActivityOtherGroupUnassign { get; set; } // core-activity-otherGroup-unassign
        public bool CoreUserOtherGroupAdd { get; set; } // core-user-otherGroup-add
        public bool CoreUserOtherGroupEdit { get; set; } // core-user-otherGroup-edit
        public bool CoreUserOtherGroupDelete { get; set; } // core-user-otherGroup-delete
        public bool CoreUserOtherGroupAssign { get; set; } // core-user-otherGroup-assign
        public bool CoreUserOtherGroupUnassign { get; set; } // core-user-otherGroup-unassign
        public bool CoreStatusAdd { get; set; } // core-status-add
        public bool CoreStatusEdit { get; set; } // core-status-edit
        public bool CoreStatusDelete { get; set; } // core-status-delete
        public bool CoreGroupAdd { get; set; } // core-group-add
        public bool CoreGroupOtherGroupEdit { get; set; } // core-group-otherGroup-edit
        public bool CoreGroupOtherGroupDelete { get; set; } // core-group-otherGroup-delete
        public bool AdminPanelExtensionEditAdvanced { get; set; } // adminPanel_extension-editAdvanced
        public bool TimesheetsOwnEntryAdd { get; set; } // ki_timesheets-ownEntry-add
        public bool TimesheetsOtherEntryOtherGroupAdd { get; set; } // ki_timesheets-otherEntry-otherGroup-add
        public bool TimesheetsOwnEntryEdit { get; set; } // ki_timesheets-ownEntry-edit
        public bool TimesheetsOtherEntryOtherGroupEdit { get; set; } // ki_timesheets-otherEntry-otherGroup-edit
        public bool TimesheetsOwnEntryDelete { get; set; } // ki_timesheets-ownEntry-delete
        public bool TimesheetsOtherEntryOtherGroupDelete { get; set; } // ki_timesheets-otherEntry-otherGroup-delete
        public bool TimesheetsShowRates { get; set; } // ki_timesheets-showRates
        public bool TimesheetsEditRates { get; set; } // ki_timesheets-editRates
        public bool ExpensesOwnEntryAdd { get; set; } // ki_expenses-ownEntry-add
        public bool ExpensesOtherEntryOtherGroupAdd { get; set; } // ki_expenses-otherEntry-otherGroup-add
        public bool ExpensesOwnEntryEdit { get; set; } // ki_expenses-ownEntry-edit
        public bool ExpensesOtherEntryOtherGroupEdit { get; set; } // ki_expenses-otherEntry-otherGroup-edit
        public bool ExpensesOwnEntryDelete { get; set; } // ki_expenses-ownEntry-delete
        public bool ExpensesOtherEntryOtherGroupDelete { get; set; } // ki_expenses-otherEntry-otherGroup-delete
        public bool CoreCustomerOtherGroupView { get; set; } // core-customer-otherGroup-view
        public bool CoreProjectOtherGroupView { get; set; } // core-project-otherGroup-view
        public bool CoreActivityOtherGroupView { get; set; } // core-activity-otherGroup-view
        public bool CoreGroupOtherGroupView { get; set; } // core-group-otherGroup-view
        public bool CoreUserOtherGroupView { get; set; } // core-user-otherGroup-view

        public GlobalRole()
        {
            DebExtAccess = false;
            AdminPanelExtensionAccess = false;
            BudgetAccess = false;
            ExpensesAccess = false;
            ExportAccess = false;
            InvoiceAccess = false;
            TimesheetAccess = false;
            DemoExtAccess = false;
            CoreCustomerOtherGroupAdd = false;
            CoreCustomerOtherGroupEdit = false;
            CoreCustomerOtherGroupDelete = false;
            CoreCustomerOtherGroupAssign = false;
            CoreCustomerOtherGroupUnassign = false;
            CoreProjectOtherGroupAdd = false;
            CoreProjectOtherGroupEdit = false;
            CoreProjectOtherGroupDelete = false;
            CoreProjectOtherGroupAssign = false;
            CoreProjectOtherGroupUnassign = false;
            CoreActivityOtherGroupAdd = false;
            CoreActivityOtherGroupEdit = false;
            CoreActivityOtherGroupDelete = false;
            CoreActivityOtherGroupAssign = false;
            CoreActivityOtherGroupUnassign = false;
            CoreUserOtherGroupAdd = false;
            CoreUserOtherGroupEdit = false;
            CoreUserOtherGroupDelete = false;
            CoreUserOtherGroupAssign = false;
            CoreUserOtherGroupUnassign = false;
            CoreStatusAdd = false;
            CoreStatusEdit = false;
            CoreStatusDelete = false;
            CoreGroupAdd = false;
            CoreGroupOtherGroupEdit = false;
            CoreGroupOtherGroupDelete = false;
            AdminPanelExtensionEditAdvanced = false;
            TimesheetsOwnEntryAdd = false;
            TimesheetsOtherEntryOtherGroupAdd = false;
            TimesheetsOwnEntryEdit = false;
            TimesheetsOtherEntryOtherGroupEdit = false;
            TimesheetsOwnEntryDelete = false;
            TimesheetsOtherEntryOtherGroupDelete = false;
            TimesheetsShowRates = false;
            TimesheetsEditRates = false;
            ExpensesOwnEntryAdd = false;
            ExpensesOtherEntryOtherGroupAdd = false;
            ExpensesOwnEntryEdit = false;
            ExpensesOtherEntryOtherGroupEdit = false;
            ExpensesOwnEntryDelete = false;
            ExpensesOtherEntryOtherGroupDelete = false;
            CoreCustomerOtherGroupView = false;
            CoreProjectOtherGroupView = false;
            CoreActivityOtherGroupView = false;
            CoreGroupOtherGroupView = false;
            CoreUserOtherGroupView = false;
        }
    }

    // GlobalRoles
    //internal class GlobalRoleConfigurations : EntityTypeConfigurations<GlobalRole>
    //{
    //    public GlobalRoleConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".GlobalRoles");
    //        HasKey(x => x.GlobalRoleId);

    //        Property(x => x.GlobalRoleId).HasColumnName("GlobalRoleID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(255);
    //        Property(x => x.DebExtAccess).HasColumnName("deb_ext-access").IsOptional();
    //        Property(x => x.AdminPanelExtensionAccess).HasColumnName("adminPanel_extension-access").IsOptional();
    //        Property(x => x.BudgetAccess).HasColumnName("ki_budget-access").IsOptional();
    //        Property(x => x.ExpensesAccess).HasColumnName("ki_expenses-access").IsOptional();
    //        Property(x => x.ExportAccess).HasColumnName("ki_export-access").IsOptional();
    //        Property(x => x.InvoiceAccess).HasColumnName("ki_invoice-access").IsOptional();
    //        Property(x => x.TimesheetAccess).HasColumnName("ki_timesheet-access").IsOptional();
    //        Property(x => x.DemoExtAccess).HasColumnName("demo_ext-access").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupAdd).HasColumnName("core-customer-otherGroup-add").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupEdit).HasColumnName("core-customer-otherGroup-edit").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupDelete).HasColumnName("core-customer-otherGroup-delete").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupAssign).HasColumnName("core-customer-otherGroup-assign").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupUnassign).HasColumnName("core-customer-otherGroup-unassign").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupAdd).HasColumnName("core-project-otherGroup-add").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupEdit).HasColumnName("core-project-otherGroup-edit").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupDelete).HasColumnName("core-project-otherGroup-delete").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupAssign).HasColumnName("core-project-otherGroup-assign").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupUnassign).HasColumnName("core-project-otherGroup-unassign").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupAdd).HasColumnName("core-activity-otherGroup-add").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupEdit).HasColumnName("core-activity-otherGroup-edit").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupDelete).HasColumnName("core-activity-otherGroup-delete").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupAssign).HasColumnName("core-activity-otherGroup-assign").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupUnassign).HasColumnName("core-activity-otherGroup-unassign").IsOptional();
    //        Property(x => x.CoreUserOtherGroupAdd).HasColumnName("core-user-otherGroup-add").IsOptional();
    //        Property(x => x.CoreUserOtherGroupEdit).HasColumnName("core-user-otherGroup-edit").IsOptional();
    //        Property(x => x.CoreUserOtherGroupDelete).HasColumnName("core-user-otherGroup-delete").IsOptional();
    //        Property(x => x.CoreUserOtherGroupAssign).HasColumnName("core-user-otherGroup-assign").IsOptional();
    //        Property(x => x.CoreUserOtherGroupUnassign).HasColumnName("core-user-otherGroup-unassign").IsOptional();
    //        Property(x => x.CoreStatusAdd).HasColumnName("core-status-add").IsOptional();
    //        Property(x => x.CoreStatusEdit).HasColumnName("core-status-edit").IsOptional();
    //        Property(x => x.CoreStatusDelete).HasColumnName("core-status-delete").IsOptional();
    //        Property(x => x.CoreGroupAdd).HasColumnName("core-group-add").IsOptional();
    //        Property(x => x.CoreGroupOtherGroupEdit).HasColumnName("core-group-otherGroup-edit").IsOptional();
    //        Property(x => x.CoreGroupOtherGroupDelete).HasColumnName("core-group-otherGroup-delete").IsOptional();
    //        Property(x => x.AdminPanelExtensionEditAdvanced).HasColumnName("adminPanel_extension-editAdvanced").IsOptional();
    //        Property(x => x.TimesheetsOwnEntryAdd).HasColumnName("ki_timesheets-ownEntry-add").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOtherGroupAdd).HasColumnName("ki_timesheets-otherEntry-otherGroup-add").IsOptional();
    //        Property(x => x.TimesheetsOwnEntryEdit).HasColumnName("ki_timesheets-ownEntry-edit").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOtherGroupEdit).HasColumnName("ki_timesheets-otherEntry-otherGroup-edit").IsOptional();
    //        Property(x => x.TimesheetsOwnEntryDelete).HasColumnName("ki_timesheets-ownEntry-delete").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOtherGroupDelete).HasColumnName("ki_timesheets-otherEntry-otherGroup-delete").IsOptional();
    //        Property(x => x.TimesheetsShowRates).HasColumnName("ki_timesheets-showRates").IsOptional();
    //        Property(x => x.TimesheetsEditRates).HasColumnName("ki_timesheets-editRates").IsOptional();
    //        Property(x => x.ExpensesOwnEntryAdd).HasColumnName("ki_expenses-ownEntry-add").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOtherGroupAdd).HasColumnName("ki_expenses-otherEntry-otherGroup-add").IsOptional();
    //        Property(x => x.ExpensesOwnEntryEdit).HasColumnName("ki_expenses-ownEntry-edit").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOtherGroupEdit).HasColumnName("ki_expenses-otherEntry-otherGroup-edit").IsOptional();
    //        Property(x => x.ExpensesOwnEntryDelete).HasColumnName("ki_expenses-ownEntry-delete").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOtherGroupDelete).HasColumnName("ki_expenses-otherEntry-otherGroup-delete").IsOptional();
    //        Property(x => x.CoreCustomerOtherGroupView).HasColumnName("core-customer-otherGroup-view").IsOptional();
    //        Property(x => x.CoreProjectOtherGroupView).HasColumnName("core-project-otherGroup-view").IsOptional();
    //        Property(x => x.CoreActivityOtherGroupView).HasColumnName("core-activity-otherGroup-view").IsOptional();
    //        Property(x => x.CoreGroupOtherGroupView).HasColumnName("core-group-otherGroup-view").IsOptional();
    //        Property(x => x.CoreUserOtherGroupView).HasColumnName("core-user-otherGroup-view").IsOptional();
    //    }
    //}

    // groups
    public class Group
    {
        public int GroupId { get; set; } // groupID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        public bool Trash { get; set; } // trash
        public ICollection<User> Users { get; set; }
        public ICollection<MembershipRole> MembershipRoles { get; set; }

        public Group()
        {
            Trash = false;
        }
    }

    // groups
    //internal class GroupConfigurations : EntityTypeConfigurations<Group>
    //{
    //    public GroupConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".groups");
    //        HasKey(x => x.GroupId);

    //        Property(x => x.GroupId).HasColumnName("groupID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(160);
    //        Property(x => x.Trash).HasColumnName("trash").IsRequired();
    //    }
    //}

    //// groups_users
    //public class GroupsUsers
    //{
    //    public int GroupId { get; set; } // groupID (Primary key)
    //    public int UserId { get; set; } // userID (Primary key)
    //    public int MembershipRoleId { get; set; } // membershipRoleID
    //}

    // groups_users
    //internal class GroupsUsersConfigurations : EntityTypeConfigurations<GroupsUsers>
    //{
    //    public GroupsUsersConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".groups_users");
    //        HasKey(x => new { x.GroupId, x.UserId });

    //        Property(x => x.GroupId).HasColumnName("groupID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        Property(x => x.UserId).HasColumnName("userID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        Property(x => x.MembershipRoleId).HasColumnName("membershipRoleID").IsRequired();
    //    }
    //}

    // MembershipRoles
    public class MembershipRole
    {
        public int MembershipRoleId { get; set; } // membershipRoleID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        public bool CoreCustomerAdd { get; set; } // core-customer-add
        public bool CoreCustomerEdit { get; set; } // core-customer-edit
        public bool CoreCustomerDelete { get; set; } // core-customer-delete
        public bool CoreCustomerAssign { get; set; } // core-customer-assign
        public bool CoreCustomerUnassign { get; set; } // core-customer-unassign
        public bool CoreProjectAdd { get; set; } // core-project-add
        public bool CoreProjectEdit { get; set; } // core-project-edit
        public bool CoreProjectDelete { get; set; } // core-project-delete
        public bool CoreProjectAssign { get; set; } // core-project-assign
        public bool CoreProjectUnassign { get; set; } // core-project-unassign
        public bool CoreActivityAdd { get; set; } // core-activity-add
        public bool CoreActivityEdit { get; set; } // core-activity-edit
        public bool CoreActivityDelete { get; set; } // core-activity-delete
        public bool CoreActivityAssign { get; set; } // core-activity-assign
        public bool CoreActivityUnassign { get; set; } // core-activity-unassign
        public bool CoreUserAdd { get; set; } // core-user-add
        public bool CoreUserEdit { get; set; } // core-user-edit
        public bool CoreUserDelete { get; set; } // core-user-delete
        public bool CoreUserAssign { get; set; } // core-user-assign
        public bool CoreUserUnassign { get; set; } // core-user-unassign
        public bool CoreGroupEdit { get; set; } // core-group-edit
        public bool CoreGroupDelete { get; set; } // core-group-delete
        public bool TimesheetsOtherEntryOwnGroupAdd { get; set; } // ki_timesheets-otherEntry-ownGroup-add
        public bool TimesheetsOtherEntryOwnGroupEdit { get; set; } // ki_timesheets-otherEntry-ownGroup-edit
        public bool TimesheetsOtherEntryOwnGroupDelete { get; set; } // ki_timesheets-otherEntry-ownGroup-delete
        public bool ExpensesOtherEntryOwnGroupAdd { get; set; } // ki_expenses-otherEntry-ownGroup-add
        public bool ExpensesOtherEntryOwnGroupEdit { get; set; } // ki_expenses-otherEntry-ownGroup-edit
        public bool ExpensesOtherEntryOwnGroupDelete { get; set; } // ki_expenses-otherEntry-ownGroup-delete

        public MembershipRole()
        {
            CoreCustomerAdd = false;
            CoreCustomerEdit = false;
            CoreCustomerDelete = false;
            CoreCustomerAssign = false;
            CoreCustomerUnassign = false;
            CoreProjectAdd = false;
            CoreProjectEdit = false;
            CoreProjectDelete = false;
            CoreProjectAssign = false;
            CoreProjectUnassign = false;
            CoreActivityAdd = false;
            CoreActivityEdit = false;
            CoreActivityDelete = false;
            CoreActivityAssign = false;
            CoreActivityUnassign = false;
            CoreUserAdd = false;
            CoreUserEdit = false;
            CoreUserDelete = false;
            CoreUserAssign = false;
            CoreUserUnassign = false;
            CoreGroupEdit = false;
            CoreGroupDelete = false;
            TimesheetsOtherEntryOwnGroupAdd = false;
            TimesheetsOtherEntryOwnGroupEdit = false;
            TimesheetsOtherEntryOwnGroupDelete = false;
            ExpensesOtherEntryOwnGroupAdd = false;
            ExpensesOtherEntryOwnGroupEdit = false;
            ExpensesOtherEntryOwnGroupDelete = false;
        }
    }

    // MembershipRoles
    //internal class MembershiproleConfigurations : EntityTypeConfiguration<MembershipRole>
    //{
    //    public MembershiproleConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".MembershipRoles");
    //        HasKey(x => x.MembershipRoleId);

    //        Property(x => x.MembershipRoleId).HasColumnName("membershipRoleID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(255);
    //        Property(x => x.CoreCustomerAdd).HasColumnName("core-customer-add").IsOptional();
    //        Property(x => x.CoreCustomerEdit).HasColumnName("core-customer-edit").IsOptional();
    //        Property(x => x.CoreCustomerDelete).HasColumnName("core-customer-delete").IsOptional();
    //        Property(x => x.CoreCustomerAssign).HasColumnName("core-customer-assign").IsOptional();
    //        Property(x => x.CoreCustomerUnassign).HasColumnName("core-customer-unassign").IsOptional();
    //        Property(x => x.CoreProjectAdd).HasColumnName("core-project-add").IsOptional();
    //        Property(x => x.CoreProjectEdit).HasColumnName("core-project-edit").IsOptional();
    //        Property(x => x.CoreProjectDelete).HasColumnName("core-project-delete").IsOptional();
    //        Property(x => x.CoreProjectAssign).HasColumnName("core-project-assign").IsOptional();
    //        Property(x => x.CoreProjectUnassign).HasColumnName("core-project-unassign").IsOptional();
    //        Property(x => x.CoreActivityAdd).HasColumnName("core-activity-add").IsOptional();
    //        Property(x => x.CoreActivityEdit).HasColumnName("core-activity-edit").IsOptional();
    //        Property(x => x.CoreActivityDelete).HasColumnName("core-activity-delete").IsOptional();
    //        Property(x => x.CoreActivityAssign).HasColumnName("core-activity-assign").IsOptional();
    //        Property(x => x.CoreActivityUnassign).HasColumnName("core-activity-unassign").IsOptional();
    //        Property(x => x.CoreUserAdd).HasColumnName("core-user-add").IsOptional();
    //        Property(x => x.CoreUserEdit).HasColumnName("core-user-edit").IsOptional();
    //        Property(x => x.CoreUserDelete).HasColumnName("core-user-delete").IsOptional();
    //        Property(x => x.CoreUserAssign).HasColumnName("core-user-assign").IsOptional();
    //        Property(x => x.CoreUserUnassign).HasColumnName("core-user-unassign").IsOptional();
    //        Property(x => x.CoreGroupEdit).HasColumnName("core-group-edit").IsOptional();
    //        Property(x => x.CoreGroupDelete).HasColumnName("core-group-delete").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOwnGroupAdd).HasColumnName("ki_timesheets-otherEntry-ownGroup-add").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOwnGroupEdit).HasColumnName("ki_timesheets-otherEntry-ownGroup-edit").IsOptional();
    //        Property(x => x.TimesheetsOtherEntryOwnGroupDelete).HasColumnName("ki_timesheets-otherEntry-ownGroup-delete").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOwnGroupAdd).HasColumnName("ki_expenses-otherEntry-ownGroup-add").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOwnGroupEdit).HasColumnName("ki_expenses-otherEntry-ownGroup-edit").IsOptional();
    //        Property(x => x.ExpensesOtherEntryOwnGroupDelete).HasColumnName("ki_expenses-otherEntry-ownGroup-delete").IsOptional();
    //    }
    //}

    // preferences
    public class Preference
    {
        //public int PreferenceId
        [Key, Column(Order = 0)]
        public int UserId { get; set; } // userID (Primary key)
        [Key, Column(Order = 1)]
        public string Option { get; set; } // option (Primary key)
        [Required, MaxLength(300)]
        public string Value { get; set; } // value
    }

    // preferences
    //internal class PreferenceConfigurations : EntityTypeConfiguration<Preference>
    //{
    //    public PreferenceConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".preferences");
    //        HasKey(x => new { x.UserId, x.Option });

    //        Property(x => x.UserId).HasColumnName("userID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        Property(x => x.Option).HasColumnName("option").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        Property(x => x.Value).HasColumnName("value").IsRequired().HasMaxLength(255);
    //    }
    //}

    // projects
    public class Project
    {
        public int ProjectId { get; set; } // projectID (Primary key)
        //[ForeignKey("CustomerId")]
        [Column("CustomerId")]
        public Customer Customer { get; set; } // customerID
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        [Required, MaxLength(500)]
        public string Comment { get; set; } // comment
        public bool Visible { get; set; } // visible
        public bool Filter { get; set; } // filter
        public bool Trash { get; set; } // trash
        public decimal Budget { get; set; } // budget
        public decimal? Effort { get; set; } // effort
        public decimal? Approved { get; set; } // approved
        public bool Internal { get; set; } // internal

        public Project()
        {
            Visible = true;
            Filter = false;
            Trash = false;
            Budget = 0.00m;
            Internal = false;
        }
    }

    // projects
    public class ProjectConfigurations : EntityTypeConfiguration<Project>
    {
        public ProjectConfigurations(string schema = "dbo")
        {
            //ToTable(schema + ".projects");
            //HasKey(x => x.ProjectId);

            //Property(x => x.ProjectId).HasColumnName("projectID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(x => x.CustomerId).HasColumnName("customerID").IsRequired();
            //Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(255);
            //Property(x => x.Comment).HasColumnName("comment").IsRequired();
            //Property(x => x.Visible).HasColumnName("visible").IsRequired();
            //Property(x => x.Filter).HasColumnName("filter").IsRequired();
            //Property(x => x.Trash).HasColumnName("trash").IsRequired();
            Property(x => x.Budget).HasColumnName("Budget").IsRequired().HasPrecision(10, 2);
            Property(x => x.Effort).HasColumnName("Effort").IsOptional().HasPrecision(10, 2);
            Property(x => x.Approved).HasColumnName("Approved").IsOptional().HasPrecision(10, 2);
            Property(x => x.Internal).HasColumnName("Internal").IsRequired();
        }
    }

    // statuses
    public class Status
    {
        public int StatusId { get; set; } // statusID (Primary key)
        [Required, MaxLength(250)]
        public string StatusText { get; set; } // status
    }

    // statuses
    //internal class StatusConfigurations : EntityTypeConfiguration<Status>
    //{
    //    public StatusConfigurations(string schema = "dbo")
    //    {
    //        ToTable(schema + ".statuses");
    //        HasKey(x => x.StatusId);

    //        Property(x => x.StatusId).HasColumnName("statusID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Status_).HasColumnName("status").IsRequired().HasMaxLength(200);
    //    }
    //}

    // timesheet
    public class Timesheet
    {
        [Key]
        public int TimeEntryId { get; set; } // timeEntryID (Primary key)
        public int Start { get; set; } // start
        public int End { get; set; } // end
        public int Duration { get; set; } // duration
        //[ForeignKey("UserId")]
        [Column("UserId")]
        public User User { get; set; } // userID
        //[ForeignKey("ProjectId")]
        [Column("ProjectId")]
        public Project Project { get; set; } // projectID
        //[ForeignKey("ActivityId")]
        [Column("ActivityId")]
        public Activity Activity { get; set; } // activityID
        public string Description { get; set; } // description
        public string Comment { get; set; } // comment
        public short CommentType { get; set; } // commentType
        [Required]
        public bool Cleared { get; set; } // cleared
        [MaxLength(100)]
        public string Location { get; set; } // location
        public string TrackingNumber { get; set; } // trackingNumber
        public decimal Rate { get; set; } // rate
        public decimal FixedRate { get; set; } // fixedRate
        public decimal? Budget { get; set; } // budget
        public decimal? Approved { get; set; } // approved
        [Column("StatusId")]
        public Status Status { get; set; } // statusID
        public bool Billable { get; set; } // billable

        public Timesheet()
        {
            Start = 0;
            End = 0;
            Duration = 0;
            CommentType = 0;
            Cleared = false;
            Location = "NULL";
            TrackingNumber = "NULL";
            Rate = 0.00m;
            FixedRate = 0.00m;
        }
    }


    // timesheet
    public class TimesheetConfigurations : EntityTypeConfiguration<Timesheet>
    {
        public TimesheetConfigurations(string schema = "dbo")
        {
            //ToTable(schema + ".timesheet");
            //HasKey(x => x.TimeEntryId);

            //Property(x => x.TimeEntryId).HasColumnName("timeEntryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(x => x.Start).HasColumnName("start").IsRequired();
            //Property(x => x.End).HasColumnName("end").IsRequired();
            //Property(x => x.Duration).HasColumnName("duration").IsRequired();
            //Property(x => x.UserId).HasColumnName("userID").IsRequired();
            //Property(x => x.ProjectId).HasColumnName("projectID").IsRequired();
            //Property(x => x.ActivityId).HasColumnName("activityID").IsRequired();
            //Property(x => x.Description).HasColumnName("description").IsOptional();
            //Property(x => x.Comment).HasColumnName("comment").IsOptional();
            //Property(x => x.CommentType).HasColumnName("commentType").IsRequired();
            //Property(x => x.Cleared).HasColumnName("cleared").IsRequired();
            //Property(x => x.Location).HasColumnName("location").IsOptional().HasMaxLength(50);
            //Property(x => x.TrackingNumber).HasColumnName("trackingNumber").IsOptional().HasMaxLength(30);
            //Property(x => x.Rate).HasColumnName("rate").IsRequired().HasPrecision(10, 2);
            Property(x => x.FixedRate).HasColumnName("fixedRate").IsRequired().HasPrecision(10, 2);
            Property(x => x.Budget).HasColumnName("budget").IsOptional().HasPrecision(10, 2);
            Property(x => x.Approved).HasColumnName("approved").IsOptional().HasPrecision(10, 2);
            //Property(x => x.StatusId).HasColumnName("statusID").IsRequired();
            //Property(x => x.Billable).HasColumnName("billable").IsOptional();
        }
    }

    // users
    public class User
    {

        public int UserId { get; set; } // userID (Primary key)
        [Required, MaxLength(300)]
        public string Name { get; set; } // name
        [Required, MaxLength(300)]
        public string Alias { get; set; } // alias
        public short Trash { get; set; } // trash
        public short Active { get; set; } // active
        [Required, MaxLength(100)]
        public string Mail { get; set; } // mail
        [Required, MaxLength(100)]
        public string Password { get; set; } // password
        public int Ban { get; set; } // ban
        public int BanTime { get; set; } // banTime
        public string Secure { get; set; } // secure
        public Project LastProject { get; set; } // lastProject
        public Activity LastActivity { get; set; } // lastActivity
        public int LastRecord { get; set; } // lastRecord
        [Required, MaxLength(60)]
        public string TimeframeBegin { get; set; } // timeframeBegin
        [Required, MaxLength(60)]
        public string TimeframeEnd { get; set; } // timeframeEnd
        [MaxLength(30)]
        public string Apikey { get; set; } // apikey
        [Column("GlobalRoleId")]
        public GlobalRole GlobalRole { get; set; } // GlobalRoleID

        public User()
        {
            Alias = "NULL";
            Trash = 0;
            Active = 1;
            Mail = "N''";
            Password = "NULL";
            Ban = 0;
            BanTime = 0;
            Secure = "N'0'";
            //LastProject = 1;
            //LastActivity = 1;
            LastRecord = 0;
            TimeframeBegin = "N'0'";
            TimeframeEnd = "N'0'";
            Apikey = "NULL";
        }
    }


    // ************************************************************************
    // POCO Configurations
    // users
    //internal class UserConfigurations : EntityTypeConfiguration<User>
    //{
    //    public UserConfigurations(string schema = "dbo")
    //    {
    //        //ToTable(schema + ".users");
    //        //HasKey(x => x.UserId);

    //        Property(x => x.UserId).HasColumnName("userID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(160);
    //        Property(x => x.Alias).HasColumnName("alias").IsOptional().HasMaxLength(160);
    //        Property(x => x.Trash).HasColumnName("trash").IsRequired();
    //        Property(x => x.Active).HasColumnName("active").IsRequired();
    //        Property(x => x.Mail).HasColumnName("mail").IsRequired().HasMaxLength(160);
    //        Property(x => x.Password).HasColumnName("password").IsOptional().HasMaxLength(254);
    //        Property(x => x.Ban).HasColumnName("ban").IsRequired();
    //        Property(x => x.BanTime).HasColumnName("banTime").IsRequired();
    //        Property(x => x.Secure).HasColumnName("secure").IsRequired().HasMaxLength(60);
    //        Property(x => x.LastProject).HasColumnName("lastProject").IsRequired();
    //        Property(x => x.LastActivity).HasColumnName("lastActivity").IsRequired();
    //        Property(x => x.LastRecord).HasColumnName("lastRecord").IsRequired();
    //        Property(x => x.TimeframeBegin).HasColumnName("timeframeBegin").IsRequired().HasMaxLength(60);
    //        Property(x => x.TimeframeEnd).HasColumnName("timeframeEnd").IsRequired().HasMaxLength(60);
    //        Property(x => x.Apikey).HasColumnName("apikey").IsOptional().HasMaxLength(30);
    //        Property(x => x.GlobalRoleId).HasColumnName("globalRoleID").IsRequired();
    //    }
    //}

}
