using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDAL;

public partial class MwdwtempContext : DbContext
{
    public MwdwtempContext()
    {
    }

    public MwdwtempContext(DbContextOptions<MwdwtempContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCustomerMasterMc> TblCustomerMasterMcs { get; set; }

    public virtual DbSet<TblDepartmentCodeMc> TblDepartmentCodeMcs { get; set; }

    public virtual DbSet<TblEmployeeMaster1Mc> TblEmployeeMaster1Mcs { get; set; }

    public virtual DbSet<TblJobMasterMc> TblJobMasterMcs { get; set; }

    public virtual DbSet<VisionDatum> VisionData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCustomerMasterMc>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.CustomerCode });

            entity.ToTable("tblCustomerMasterMC");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Company_Code");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Customer_Code");
            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Address_2");
            entity.Property(e => e.AddressId).HasColumnName("Address_ID");
            entity.Property(e => e.AllCostCenters)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .HasColumnName("All_Cost_Centers");
            entity.Property(e => e.AlphaSort)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Alpha_Sort");
            entity.Property(e => e.Balance).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.BalanceLastYear)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Balance_Last_Year");
            entity.Property(e => e.BalanceMtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Balance_MTD");
            entity.Property(e => e.BalanceYtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Balance_YTD");
            entity.Property(e => e.BilledLastYear)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Billed_Last_Year");
            entity.Property(e => e.BilledMtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Billed_MTD");
            entity.Property(e => e.BilledYtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Billed_YTD");
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.Contact1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Contact_1");
            entity.Property(e => e.Contact2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Contact_2");
            entity.Property(e => e.Contact3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Contact_3");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Credit_Limit");
            entity.Property(e => e.CurrentOrderBalance)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Current_Order_Balance");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Customer_Email");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
            entity.Property(e => e.DateLastBilled)
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Billed");
            entity.Property(e => e.DateLastPaid)
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Paid");
            entity.Property(e => e.DiscountLastYear)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Discount_Last_Year");
            entity.Property(e => e.DiscountMtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Discount_MTD");
            entity.Property(e => e.DiscountYtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Discount_YTD");
            entity.Property(e => e.FaxId).HasColumnName("Fax_ID");
            entity.Property(e => e.FaxPhone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Fax_Phone");
            entity.Property(e => e.FinanceCharge)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Finance_Charge");
            entity.Property(e => e.FinanceChargeTranCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Finance_Charge_Tran_Code");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MarkupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Markup_Code");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.PaidLastYear)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Paid_Last_Year");
            entity.Property(e => e.PaidMtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Paid_MTD");
            entity.Property(e => e.PaidYtd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Paid_YTD");
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.PhoneId).HasColumnName("Phone_ID");
            entity.Property(e => e.PriceLevelLabor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Price_Level_Labor");
            entity.Property(e => e.PriceLevelMaterial)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Price_Level_Material");
            entity.Property(e => e.PrimaryContact).HasColumnName("Primary_Contact");
            entity.Property(e => e.ResaleExpDate)
                .HasColumnType("datetime")
                .HasColumnName("Resale_Exp_Date");
            entity.Property(e => e.ResaleNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Resale_Number");
            entity.Property(e => e.RetentionBalance)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Retention_Balance");
            entity.Property(e => e.RetentionBilled)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Retention_Billed");
            entity.Property(e => e.RetentionDiscount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Retention_Discount");
            entity.Property(e => e.RetentionPaid)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Retention_Paid");
            entity.Property(e => e.SalesTaxCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Sales_Tax_Code");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.StandardRetentionPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Standard_Retention_Percent");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.StatementFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Statement_Flag");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.TaxableFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Taxable_Flag");
            entity.Property(e => e.TermsCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Terms_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.WebSite)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Web_Site");
            entity.Property(e => e.WoWarningMessage)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("WO_Warning_Message");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Zip_Code");
        });

        modelBuilder.Entity<TblDepartmentCodeMc>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.Department });

            entity.ToTable("tblDepartmentCodeMC");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Company_Code");
            entity.Property(e => e.Department)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Cost_Center");
            entity.Property(e => e.DepartmentDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Department_Description");
        });

        modelBuilder.Entity<TblEmployeeMaster1Mc>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.EmployeeCode });

            entity.ToTable("tblEmployeeMaster1MC");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Company_Code");
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Employee_Code");
            entity.Property(e => e.AbaNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("ABA_Number");
            entity.Property(e => e.AbaNumber2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("ABA_Number_2");
            entity.Property(e => e.AbaNumber3)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("ABA_Number_3");
            entity.Property(e => e.AbaNumber4)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("ABA_Number_4");
            entity.Property(e => e.AbaNumber5)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("ABA_Number_5");
            entity.Property(e => e.Address)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.AlphaSort)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Alpha_Sort");
            entity.Property(e => e.AnnualPayRate)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Annual_Pay_Rate");
            entity.Property(e => e.AutoDepositAllocation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Allocation");
            entity.Property(e => e.AutoDepositFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Flag");
            entity.Property(e => e.AutoDepositFlag2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Flag_2");
            entity.Property(e => e.AutoDepositFlag3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Flag_3");
            entity.Property(e => e.AutoDepositFlag4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Flag_4");
            entity.Property(e => e.AutoDepositFlag5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Deposit_Flag_5");
            entity.Property(e => e.AutoDepositRate1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Auto_Deposit_Rate1");
            entity.Property(e => e.AutoDepositRate2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Auto_Deposit_Rate2");
            entity.Property(e => e.AutoDepositRate3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Auto_Deposit_Rate3");
            entity.Property(e => e.AutoDepositRate4)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Auto_Deposit_Rate4");
            entity.Property(e => e.AutoDepositRate5)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Auto_Deposit_Rate5");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Number");
            entity.Property(e => e.BankAccountNumber2)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Number_2");
            entity.Property(e => e.BankAccountNumber3)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Number_3");
            entity.Property(e => e.BankAccountNumber4)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Number_4");
            entity.Property(e => e.BankAccountNumber5)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Number_5");
            entity.Property(e => e.BankAccountType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Type");
            entity.Property(e => e.BankAccountType2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Type_2");
            entity.Property(e => e.BankAccountType3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Type_3");
            entity.Property(e => e.BankAccountType4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Type_4");
            entity.Property(e => e.BankAccountType5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Bank_Account_Type_5");
            entity.Property(e => e.BillingCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Billing_Code");
            entity.Property(e => e.BurdenPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Burden_Percent");
            entity.Property(e => e.CasualFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Casual_Flag");
            entity.Property(e => e.CertifiedFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Certified_Flag");
            entity.Property(e => e.CheckType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Check_Type");
            entity.Property(e => e.Comments)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.ContactId)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Contact_ID");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Cost_Center");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Delete_Flag");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Department_Code");
            entity.Property(e => e.DomicileAddress)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Domicile_Address");
            entity.Property(e => e.DomicileAddress2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Domicile_Address2");
            entity.Property(e => e.DomicileCity)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Domicile_City");
            entity.Property(e => e.DomicileState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Domicile_State");
            entity.Property(e => e.DomicileZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Domicile_Zip_Code");
            entity.Property(e => e.DriverLicense)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Driver_License");
            entity.Property(e => e.EeoClassCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("EEO_Class_Code");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective_Date");
            entity.Property(e => e.EmergencyContact)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Emergency_Contact");
            entity.Property(e => e.EmergencyPhone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Emergency_Phone");
            entity.Property(e => e.EmergencyRelationship)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Emergency_Relationship");
            entity.Property(e => e.EmpForeign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Emp_Foreign");
            entity.Property(e => e.EmployeeDateList1)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List1");
            entity.Property(e => e.EmployeeDateList2)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List2");
            entity.Property(e => e.EmployeeDateList3)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List3");
            entity.Property(e => e.EmployeeDateList4)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List4");
            entity.Property(e => e.EmployeeDateList5)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List5");
            entity.Property(e => e.EmployeeDateList6)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List6");
            entity.Property(e => e.EmployeeDateList7)
                .HasColumnType("datetime")
                .HasColumnName("Employee_Date_List7");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Employee_Name");
            entity.Property(e => e.EmployeeWorkClass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Employee_Work_Class");
            entity.Property(e => e.EmploymentStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Employment_Status");
            entity.Property(e => e.EncryptedBankAccountNumber)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Bank_Account_Number");
            entity.Property(e => e.EncryptedBankAccountNumber2)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Bank_Account_Number_2");
            entity.Property(e => e.EncryptedBankAccountNumber3)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Bank_Account_Number_3");
            entity.Property(e => e.EncryptedBankAccountNumber4)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Bank_Account_Number_4");
            entity.Property(e => e.EncryptedBankAccountNumber5)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Bank_Account_Number_5");
            entity.Property(e => e.EncryptedDriverLicense)
                .HasMaxLength(84)
                .HasColumnName("Encrypted_Driver_License");
            entity.Property(e => e.EncryptedSocialSecurity)
                .HasMaxLength(68)
                .HasColumnName("Encrypted_Social_Security");
            entity.Property(e => e.FilingStatusList1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Filing_Status_List1");
            entity.Property(e => e.FilingStatusList2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Filing_Status_List2");
            entity.Property(e => e.FilingStatusList3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Filing_Status_List3");
            entity.Property(e => e.FilingStatusList4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Filing_Status_List4");
            entity.Property(e => e.FilingStatusList5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Filing_Status_List5");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("First_Name");
            entity.Property(e => e.HourlyRate)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("Hourly_Rate");
            entity.Property(e => e.HoursList1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Hours_List1");
            entity.Property(e => e.HoursList2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Hours_List2");
            entity.Property(e => e.HoursList3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Hours_List3");
            entity.Property(e => e.I9ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("I9_Expire_Date");
            entity.Property(e => e.I9Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("I9_Flag");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Last_Name");
            entity.Property(e => e.LastPayRate)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Last_Pay_Rate");
            entity.Property(e => e.LastPayType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Last_Pay_Type");
            entity.Property(e => e.ManualCheckNumber)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Manual_Check_Number");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Marital_Status");
            entity.Property(e => e.MealAllowanceRate)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Meal_Allowance_Rate");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MinimumEarnings)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Minimum_Earnings");
            entity.Property(e => e.MonthsToNextReview)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Months_To_Next_Review");
            entity.Property(e => e.NotUsed1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Not_Used1");
            entity.Property(e => e.NotUsed2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Not_Used2");
            entity.Property(e => e.NotUsed3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Not_Used3");
            entity.Property(e => e.NumberOfDependents)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Dependents");
            entity.Property(e => e.NumberOfExemptionsList1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Exemptions_List1");
            entity.Property(e => e.NumberOfExemptionsList2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Exemptions_List2");
            entity.Property(e => e.NumberOfExemptionsList3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Exemptions_List3");
            entity.Property(e => e.NumberOfExemptionsList4)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Exemptions_List4");
            entity.Property(e => e.NumberOfExemptionsList5)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Number_Of_Exemptions_List5");
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.OtHours)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("OT_Hours");
            entity.Property(e => e.PayFrequencyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Pay_Frequency_Flag");
            entity.Property(e => e.PayRateCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Pay_Rate_Code");
            entity.Property(e => e.PayRatePercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Pay_Rate_Percent");
            entity.Property(e => e.PayType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Pay_Type");
            entity.Property(e => e.PermWorkComp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Perm_Work_Comp");
            entity.Property(e => e.PermanentUnemploymentState)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Permanent_Unemployment_State");
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.PrevailWageFringeRate)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Prevail_Wage_Fringe_Rate");
            entity.Property(e => e.Race)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.SalaryAmount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Salary_Amount");
            entity.Property(e => e.SelectedFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Selected_Flag");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.SocialSecurity)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Social_Security");
            entity.Property(e => e.SpecialPayAmount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Special_Pay_Amount");
            entity.Property(e => e.SpecialPayRate)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Special_Pay_Rate");
            entity.Property(e => e.SpouseName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Spouse_Name");
            entity.Property(e => e.StandardWorkHours)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Standard_Work_Hours");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.StopTaxFlagList1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Stop_Tax_Flag_List1");
            entity.Property(e => e.StopTaxFlagList2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Stop_Tax_Flag_List2");
            entity.Property(e => e.StopTaxFlagList3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Stop_Tax_Flag_List3");
            entity.Property(e => e.StopTaxFlagList4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Stop_Tax_Flag_List4");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Street_Address");
            entity.Property(e => e.StreetAddress2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Street_Address2");
            entity.Property(e => e.SupervisorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Supervisor_Code");
            entity.Property(e => e.TaxAddList1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Tax_Add_List1");
            entity.Property(e => e.TaxAddList2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Tax_Add_List2");
            entity.Property(e => e.TaxAddList3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Tax_Add_List3");
            entity.Property(e => e.TaxAddList4)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Tax_Add_List4");
            entity.Property(e => e.TaxAddList5)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Tax_Add_List5");
            entity.Property(e => e.TaxAmountControlList1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Amount_Control_List1");
            entity.Property(e => e.TaxAmountControlList2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Amount_Control_List2");
            entity.Property(e => e.TaxAmountControlList3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Amount_Control_List3");
            entity.Property(e => e.TaxAmountControlList4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Amount_Control_List4");
            entity.Property(e => e.TaxAmountControlList5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Amount_Control_List5");
            entity.Property(e => e.TaxControlFlagList1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List1");
            entity.Property(e => e.TaxControlFlagList10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List10");
            entity.Property(e => e.TaxControlFlagList11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List11");
            entity.Property(e => e.TaxControlFlagList2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List2");
            entity.Property(e => e.TaxControlFlagList3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List3");
            entity.Property(e => e.TaxControlFlagList4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List4");
            entity.Property(e => e.TaxControlFlagList5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List5");
            entity.Property(e => e.TaxControlFlagList6)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List6");
            entity.Property(e => e.TaxControlFlagList7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List7");
            entity.Property(e => e.TaxControlFlagList8)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List8");
            entity.Property(e => e.TaxControlFlagList9)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Control_Flag_List9");
            entity.Property(e => e.TaxTableCodesList1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Table_Codes_List1");
            entity.Property(e => e.TaxTableCodesList2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Table_Codes_List2");
            entity.Property(e => e.TaxTableCodesList3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Table_Codes_List3");
            entity.Property(e => e.TaxTableCodesList4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Table_Codes_List4");
            entity.Property(e => e.TaxTableCodesList5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Table_Codes_List5");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.TotalHours)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Total_Hours");
            entity.Property(e => e.Trade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.UnionCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Union_Code");
            entity.Property(e => e.WageClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Wage_Class");
            entity.Property(e => e.WorkerCompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Worker_Comp_Code");
            entity.Property(e => e.WrkExtId).HasColumnName("Wrk_Ext_ID");
            entity.Property(e => e.WrkMobileId).HasColumnName("Wrk_Mobile_ID");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Zip_Code");
        });

        modelBuilder.Entity<TblJobMasterMc>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.JobNumber }).HasName("PK_JC_JOB_MASTER_MC");

            entity.ToTable("tblJobMasterMC");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Company_Code");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Job_Number");
            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Address_2");
            entity.Property(e => e.AutoOtFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Auto_Ot_Flag");
            entity.Property(e => e.BurdenCostType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Burden_Cost_Type");
            entity.Property(e => e.BurdenFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Burden_Flag");
            entity.Property(e => e.BurdenPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Burden_Percent");
            entity.Property(e => e.BurdenPhase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Burden_Phase");
            entity.Property(e => e.CertifiedFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Certified_Flag");
            entity.Property(e => e.CertifiedProjectId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Certified_Project_ID");
            entity.Property(e => e.CertifiedWeekType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Certified_Week_Type");
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.Comment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.CompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("Complete_Date");
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Contract_Number");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Cost_Center");
            entity.Property(e => e.CostMarkupPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Cost_Markup_Percent");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Customer_Code");
            entity.Property(e => e.Division)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.DtOverHrs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Dt_Over_Hrs");
            entity.Property(e => e.EarnedCalcType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Earned_Calc_Type");
            entity.Property(e => e.EnteredPercentComplete)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Entered_Percent_Complete");
            entity.Property(e => e.EnteredProjectedCost)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Entered_Projected_Cost");
            entity.Property(e => e.EstCompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("Est_Complete_Date");
            entity.Property(e => e.EstStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Est_Start_Date");
            entity.Property(e => e.Estimator)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.FaxPhone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Fax_Phone");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IndexVariable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Index_Variable");
            entity.Property(e => e.IndexVariable2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Index_Variable_2");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Job_Description");
            entity.Property(e => e.JobOhBatchCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Job_Oh_Batch_Code");
            entity.Property(e => e.JobSitePhone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Job_Site_Phone");
            entity.Property(e => e.JobType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Job_Type");
            entity.Property(e => e.Latitude).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.LockRevenueEntry)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Lock_Revenue_Entry");
            entity.Property(e => e.Longitude).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.MajorGroupEnd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Major_Group_End");
            entity.Property(e => e.MajorGroupStart)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Major_Group_Start");
            entity.Property(e => e.MasterJob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Master_Job");
            entity.Property(e => e.MinorGroupEnd)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Minor_Group_End");
            entity.Property(e => e.MinorGroupStart)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Minor_Group_Start");
            entity.Property(e => e.OhCostType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("OH_Cost_Type");
            entity.Property(e => e.OhPhase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("OH_Phase");
            entity.Property(e => e.OriginalContract)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Original_Contract");
            entity.Property(e => e.OtOverHrs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Ot_Over_Hrs");
            entity.Property(e => e.PayGroup)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Pay_Group");
            entity.Property(e => e.PayrollOhPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Payroll_OH_Percent");
            entity.Property(e => e.PeriodFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Period_Flag");
            entity.Property(e => e.PhaseDisplayCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Phase_Display_Code");
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.PrOhAmount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("PR_OH_Amount");
            entity.Property(e => e.PrOhTypeCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("PR_OH_Type_Code");
            entity.Property(e => e.PreTcBurdenPercent)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Pre_TC_Burden_Percent");
            entity.Property(e => e.PriceMethodCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Price_Method_Code");
            entity.Property(e => e.ProjectManager)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Project_Manager");
            entity.Property(e => e.ProjectedCompleteDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("Projected_Complete_Date");
            entity.Property(e => e.RoutingCode1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Routing_Code1");
            entity.Property(e => e.RoutingCode2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Routing_Code2");
            entity.Property(e => e.RoutingLimit)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Routing_Limit");
            entity.Property(e => e.SalesTaxCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Sales_Tax_Code");
            entity.Property(e => e.StandardPhaseCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Standard_Phase_Category");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_Date");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Status_Code");
            entity.Property(e => e.Superintendent)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ");
            entity.Property(e => e.TaxClassCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Tax_Class_Code");
            entity.Property(e => e.TaxableFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Taxable_Flag");
            entity.Property(e => e.TotalUnits)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Total_Units");
            entity.Property(e => e.TrackDavisBacon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Track_Davis_Bacon");
            entity.Property(e => e.TrackPrevailingWage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Track_Prevailing_Wage");
            entity.Property(e => e.UnderBilled)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Under_Billed");
            entity.Property(e => e.UnitOfMeasure)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Unit_of_Measure");
            entity.Property(e => e.WageCodeIndicator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Wage_Code_Indicator");
            entity.Property(e => e.WageRateLevel)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Wage_Rate_Level");
            entity.Property(e => e.WoSite)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("WO_Site");
            entity.Property(e => e.WorkCompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Work_Comp_Code");
            entity.Property(e => e.WorkCountyTaxCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Work_County_Tax_Code");
            entity.Property(e => e.WorkLocalTaxCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Work_Local_Tax_Code");
            entity.Property(e => e.WorkStateTaxCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Work_State_Tax_Code");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(" ")
                .HasColumnName("Zip_Code");
        });

        modelBuilder.Entity<VisionDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AdjContract).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CostPercentComplete).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CostType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CostTypeDescription)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Customer)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Division)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EstBalance).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EstBalanceQuantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EstCost).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EstQuantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.JobNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Jtdcost)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("JTDCost");
            entity.Property(e => e.Jtdquantity)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("JTDQuantity");
            entity.Property(e => e.LaborGainLoss).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MasterJobNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Month1).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Month1UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Month1UnApprovedAP");
            entity.Property(e => e.Month2).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Month2UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Month2UnApprovedAP");
            entity.Property(e => e.Month3).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Month3UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Month3UnApprovedAP");
            entity.Property(e => e.Month4).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Month4UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Month4UnApprovedAP");
            entity.Property(e => e.PhaseCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhaseDescription)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProjectManager)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProjectedLabor).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.QtyPercentComplete).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UnApprovedApcost)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("UnApprovedAPCost");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week1).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week1UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week1UnApprovedAP");
            entity.Property(e => e.Week2).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week2UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week2UnApprovedAP");
            entity.Property(e => e.Week3).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week3UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week3UnApprovedAP");
            entity.Property(e => e.Week4).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week4UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week4UnApprovedAP");
            entity.Property(e => e.Week5).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week5UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week5UnApprovedAP");
            entity.Property(e => e.Week6).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week6UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week6UnApprovedAP");
            entity.Property(e => e.Week7).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week7UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week7UnApprovedAP");
            entity.Property(e => e.Week8).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Week8UnApprovedAp)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Week8UnApprovedAP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
