using System;
using System.Collections.Generic;

namespace EFDAL;

public partial class TblEmployeeMaster1Mc
{
    public string CompanyCode { get; set; } = null!;

    public string EmployeeCode { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string AlphaSort { get; set; } = null!;

    public string StreetAddress { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string SocialSecurity { get; set; } = null!;

    public DateTime? EmployeeDateList1 { get; set; }

    public DateTime? EmployeeDateList2 { get; set; }

    public DateTime? EmployeeDateList3 { get; set; }

    public DateTime? EmployeeDateList4 { get; set; }

    public DateTime? EmployeeDateList5 { get; set; }

    public DateTime? EmployeeDateList6 { get; set; }

    public DateTime? EmployeeDateList7 { get; set; }

    public string Sex { get; set; } = null!;

    public string Race { get; set; } = null!;

    public string MaritalStatus { get; set; } = null!;

    public string CasualFlag { get; set; } = null!;

    public string PayFrequencyFlag { get; set; } = null!;

    public string PayType { get; set; } = null!;

    public string LastPayType { get; set; } = null!;

    public string SpouseName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string SupervisorCode { get; set; } = null!;

    public string TaxControlFlagList1 { get; set; } = null!;

    public string TaxControlFlagList2 { get; set; } = null!;

    public string TaxControlFlagList3 { get; set; } = null!;

    public string TaxControlFlagList4 { get; set; } = null!;

    public string TaxControlFlagList5 { get; set; } = null!;

    public string TaxControlFlagList6 { get; set; } = null!;

    public string TaxControlFlagList7 { get; set; } = null!;

    public string TaxControlFlagList8 { get; set; } = null!;

    public string TaxControlFlagList9 { get; set; } = null!;

    public string TaxControlFlagList10 { get; set; } = null!;

    public string TaxControlFlagList11 { get; set; } = null!;

    public string FilingStatusList1 { get; set; } = null!;

    public string FilingStatusList2 { get; set; } = null!;

    public string FilingStatusList3 { get; set; } = null!;

    public string FilingStatusList4 { get; set; } = null!;

    public string FilingStatusList5 { get; set; } = null!;

    public string TaxTableCodesList1 { get; set; } = null!;

    public string TaxTableCodesList2 { get; set; } = null!;

    public string TaxTableCodesList3 { get; set; } = null!;

    public string TaxTableCodesList4 { get; set; } = null!;

    public string TaxTableCodesList5 { get; set; } = null!;

    public decimal NumberOfExemptionsList1 { get; set; }

    public decimal NumberOfExemptionsList2 { get; set; }

    public decimal NumberOfExemptionsList3 { get; set; }

    public decimal NumberOfExemptionsList4 { get; set; }

    public decimal NumberOfExemptionsList5 { get; set; }

    public decimal TaxAddList1 { get; set; }

    public decimal TaxAddList2 { get; set; }

    public decimal TaxAddList3 { get; set; }

    public decimal TaxAddList4 { get; set; }

    public decimal TaxAddList5 { get; set; }

    public string TaxAmountControlList1 { get; set; } = null!;

    public string TaxAmountControlList2 { get; set; } = null!;

    public string TaxAmountControlList3 { get; set; } = null!;

    public string TaxAmountControlList4 { get; set; } = null!;

    public string TaxAmountControlList5 { get; set; } = null!;

    public string DeleteFlag { get; set; } = null!;

    public string EmploymentStatus { get; set; } = null!;

    public decimal MinimumEarnings { get; set; }

    public decimal NumberOfDependents { get; set; }

    public string WorkerCompCode { get; set; } = null!;

    public string BankAccountNumber { get; set; } = null!;

    public string DriverLicense { get; set; } = null!;

    public decimal LastPayRate { get; set; }

    public decimal HourlyRate { get; set; }

    public decimal SalaryAmount { get; set; }

    public decimal AnnualPayRate { get; set; }

    public decimal SpecialPayRate { get; set; }

    public decimal SpecialPayAmount { get; set; }

    public decimal MealAllowanceRate { get; set; }

    public string DepartmentCode { get; set; } = null!;

    public string SelectedFlag { get; set; } = null!;

    public decimal MonthsToNextReview { get; set; }

    public string EmergencyContact { get; set; } = null!;

    public string EmergencyPhone { get; set; } = null!;

    public string EmergencyRelationship { get; set; } = null!;

    public decimal NotUsed1 { get; set; }

    public decimal NotUsed2 { get; set; }

    public decimal NotUsed3 { get; set; }

    public decimal HoursList1 { get; set; }

    public decimal HoursList2 { get; set; }

    public decimal HoursList3 { get; set; }

    public decimal StandardWorkHours { get; set; }

    public string UnionCode { get; set; } = null!;

    public decimal TotalHours { get; set; }

    public string CheckType { get; set; } = null!;

    public decimal ManualCheckNumber { get; set; }

    public decimal OtHours { get; set; }

    public string DomicileAddress { get; set; } = null!;

    public string DomicileCity { get; set; } = null!;

    public string DomicileState { get; set; } = null!;

    public string DomicileZipCode { get; set; } = null!;

    public string PayRateCode { get; set; } = null!;

    public string EmployeeWorkClass { get; set; } = null!;

    public string AbaNumber { get; set; } = null!;

    public string BankAccountType { get; set; } = null!;

    public string WageClass { get; set; } = null!;

    public string CertifiedFlag { get; set; } = null!;

    public string BillingCode { get; set; } = null!;

    public string I9Flag { get; set; } = null!;

    public DateTime? I9ExpireDate { get; set; }

    public string EeoClassCode { get; set; } = null!;

    public string StopTaxFlagList1 { get; set; } = null!;

    public string StopTaxFlagList2 { get; set; } = null!;

    public string StopTaxFlagList3 { get; set; } = null!;

    public string StopTaxFlagList4 { get; set; } = null!;

    public string AutoDepositFlag { get; set; } = null!;

    public decimal BurdenPercent { get; set; }

    public decimal PrevailWageFringeRate { get; set; }

    public decimal PayRatePercent { get; set; }

    public string AbaNumber2 { get; set; } = null!;

    public string AbaNumber3 { get; set; } = null!;

    public string AbaNumber4 { get; set; } = null!;

    public string AbaNumber5 { get; set; } = null!;

    public string BankAccountType2 { get; set; } = null!;

    public string BankAccountType3 { get; set; } = null!;

    public string BankAccountType4 { get; set; } = null!;

    public string BankAccountType5 { get; set; } = null!;

    public string BankAccountNumber2 { get; set; } = null!;

    public string BankAccountNumber3 { get; set; } = null!;

    public string BankAccountNumber4 { get; set; } = null!;

    public string BankAccountNumber5 { get; set; } = null!;

    public string AutoDepositFlag2 { get; set; } = null!;

    public string AutoDepositFlag3 { get; set; } = null!;

    public string AutoDepositFlag4 { get; set; } = null!;

    public string AutoDepositFlag5 { get; set; } = null!;

    public string AutoDepositAllocation { get; set; } = null!;

    public decimal AutoDepositRate1 { get; set; }

    public decimal AutoDepositRate2 { get; set; }

    public decimal AutoDepositRate3 { get; set; }

    public decimal AutoDepositRate4 { get; set; }

    public decimal AutoDepositRate5 { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Occupation { get; set; } = null!;

    public string Trade { get; set; } = null!;

    public string StreetAddress2 { get; set; } = null!;

    public string DomicileAddress2 { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public string Comments { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public string EmpForeign { get; set; } = null!;

    public string PermWorkComp { get; set; } = null!;

    public int ContactId { get; set; }

    public string PermanentUnemploymentState { get; set; } = null!;

    public int WrkMobileId { get; set; }

    public int WrkExtId { get; set; }

    public byte[]? EncryptedSocialSecurity { get; set; }

    public byte[]? EncryptedDriverLicense { get; set; }

    public byte[]? EncryptedBankAccountNumber { get; set; }

    public byte[]? EncryptedBankAccountNumber2 { get; set; }

    public byte[]? EncryptedBankAccountNumber3 { get; set; }

    public byte[]? EncryptedBankAccountNumber4 { get; set; }

    public byte[]? EncryptedBankAccountNumber5 { get; set; }

    public int Id { get; set; }
}
