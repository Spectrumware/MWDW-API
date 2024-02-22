using System;
using System.Collections.Generic;

namespace EFDAL;

public partial class TblCustomerMasterMc
{
    public string CompanyCode { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AlphaSort { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Contact1 { get; set; } = null!;

    public string Contact2 { get; set; } = null!;

    public string Contact3 { get; set; } = null!;

    public string TermsCode { get; set; } = null!;

    public string SalesTaxCode { get; set; } = null!;

    public string ResaleNumber { get; set; } = null!;

    public DateTime? ResaleExpDate { get; set; }

    public string Salesperson { get; set; } = null!;

    public decimal BilledMtd { get; set; }

    public decimal BilledYtd { get; set; }

    public decimal BilledLastYear { get; set; }

    public decimal RetentionBilled { get; set; }

    public decimal RetentionBalance { get; set; }

    public decimal PaidMtd { get; set; }

    public decimal PaidYtd { get; set; }

    public decimal PaidLastYear { get; set; }

    public decimal RetentionPaid { get; set; }

    public decimal BalanceMtd { get; set; }

    public decimal BalanceYtd { get; set; }

    public decimal BalanceLastYear { get; set; }

    public decimal DiscountMtd { get; set; }

    public decimal DiscountYtd { get; set; }

    public decimal DiscountLastYear { get; set; }

    public decimal RetentionDiscount { get; set; }

    public string StatementFlag { get; set; } = null!;

    public decimal FinanceCharge { get; set; }

    public DateTime? DateLastBilled { get; set; }

    public DateTime? DateLastPaid { get; set; }

    public DateTime? DateCreated { get; set; }

    public decimal Balance { get; set; }

    public string FaxPhone { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public decimal PriceLevelLabor { get; set; }

    public decimal PriceLevelMaterial { get; set; }

    public string TaxableFlag { get; set; } = null!;

    public decimal StandardRetentionPercent { get; set; }

    public string FinanceChargeTranCode { get; set; } = null!;

    public decimal CurrentOrderBalance { get; set; }

    public string WoWarningMessage { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string AllCostCenters { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string MarkupCode { get; set; } = null!;

    public int AddressId { get; set; }

    public int PhoneId { get; set; }

    public int FaxId { get; set; }

    public int PrimaryContact { get; set; }

    public string WebSite { get; set; } = null!;

    public int Id { get; set; }
}
