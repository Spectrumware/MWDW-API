using System;
using System.Collections.Generic;

namespace EFDAL;

public partial class TblJobMasterMc
{
    public string CompanyCode { get; set; } = null!;

    public string JobNumber { get; set; } = null!;

    public string MasterJob { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string JobDescription { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Superintendent { get; set; } = null!;

    public string Estimator { get; set; } = null!;

    public string CertifiedFlag { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public decimal TotalUnits { get; set; }

    public string UnitOfMeasure { get; set; } = null!;

    public DateTime? CompleteDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EstCompleteDate { get; set; }

    public DateTime? EstStartDate { get; set; }

    public decimal PayrollOhPercent { get; set; }

    public string OhPhase { get; set; } = null!;

    public string OhCostType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string IndexVariable { get; set; } = null!;

    public string IndexVariable2 { get; set; } = null!;

    public string BurdenFlag { get; set; } = null!;

    public decimal BurdenPercent { get; set; }

    public string BurdenPhase { get; set; } = null!;

    public string BurdenCostType { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public decimal EnteredProjectedCost { get; set; }

    public decimal OriginalContract { get; set; }

    public string SalesTaxCode { get; set; } = null!;

    public string JobSitePhone { get; set; } = null!;

    public decimal EnteredPercentComplete { get; set; }

    public string TaxableFlag { get; set; } = null!;

    public decimal WageRateLevel { get; set; }

    public string WorkCompCode { get; set; } = null!;

    public string PriceMethodCode { get; set; } = null!;

    public decimal PreTcBurdenPercent { get; set; }

    public string PhaseDisplayCode { get; set; } = null!;

    public decimal MajorGroupStart { get; set; }

    public decimal MajorGroupEnd { get; set; }

    public decimal MinorGroupStart { get; set; }

    public decimal MinorGroupEnd { get; set; }

    public string FaxPhone { get; set; } = null!;

    public string PrOhTypeCode { get; set; } = null!;

    public decimal PrOhAmount { get; set; }

    public string JobOhBatchCode { get; set; } = null!;

    public string WageCodeIndicator { get; set; } = null!;

    public string WorkStateTaxCode { get; set; } = null!;

    public string WorkCountyTaxCode { get; set; } = null!;

    public string WorkLocalTaxCode { get; set; } = null!;

    public string PayGroup { get; set; } = null!;

    public string ProjectManager { get; set; } = null!;

    public string EarnedCalcType { get; set; } = null!;

    public decimal UnderBilled { get; set; }

    public decimal CostMarkupPercent { get; set; }

    public string TaxClassCode { get; set; } = null!;

    public string AutoOtFlag { get; set; } = null!;

    public decimal OtOverHrs { get; set; }

    public decimal DtOverHrs { get; set; }

    public string PeriodFlag { get; set; } = null!;

    public string RoutingCode1 { get; set; } = null!;

    public string RoutingCode2 { get; set; } = null!;

    public decimal RoutingLimit { get; set; }

    public string StandardPhaseCategory { get; set; } = null!;

    public string TrackPrevailingWage { get; set; } = null!;

    public string TrackDavisBacon { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public DateTime? ProjectedCompleteDate { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime? CreateDate { get; set; }

    public string WoSite { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public string CertifiedProjectId { get; set; } = null!;

    public string CertifiedWeekType { get; set; } = null!;

    public string LockRevenueEntry { get; set; } = null!;

    public int Id { get; set; }
}
