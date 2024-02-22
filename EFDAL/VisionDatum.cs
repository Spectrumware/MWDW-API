using System;
using System.Collections.Generic;

namespace EFDAL;

public partial class VisionDatum
{
    public string? CompanyCode { get; set; }

    public string? JobNumber { get; set; }

    public string? JobDescription { get; set; }

    public string? MasterJobNumber { get; set; }

    public string? PhaseDescription { get; set; }

    public string? PhaseCode { get; set; }

    public string? CostType { get; set; }

    public string? CostTypeDescription { get; set; }

    public string? ProjectManager { get; set; }

    public string? Division { get; set; }

    public string? Customer { get; set; }

    public string? StatusCode { get; set; }

    public bool? PaymentComplete { get; set; }

    public decimal? Week1 { get; set; }

    public decimal? Week2 { get; set; }

    public decimal? Week3 { get; set; }

    public decimal? Week4 { get; set; }

    public decimal? Week5 { get; set; }

    public decimal? Week6 { get; set; }

    public decimal? Week7 { get; set; }

    public decimal? Week8 { get; set; }

    public decimal? Week1UnApprovedAp { get; set; }

    public decimal? Week2UnApprovedAp { get; set; }

    public decimal? Week3UnApprovedAp { get; set; }

    public decimal? Week4UnApprovedAp { get; set; }

    public decimal? Week5UnApprovedAp { get; set; }

    public decimal? Week6UnApprovedAp { get; set; }

    public decimal? Week7UnApprovedAp { get; set; }

    public decimal? Week8UnApprovedAp { get; set; }

    public decimal? Month1 { get; set; }

    public decimal? Month2 { get; set; }

    public decimal? Month3 { get; set; }

    public decimal? Month4 { get; set; }

    public decimal? Month1UnApprovedAp { get; set; }

    public decimal? Month2UnApprovedAp { get; set; }

    public decimal? Month3UnApprovedAp { get; set; }

    public decimal? Month4UnApprovedAp { get; set; }

    public decimal? Jtdcost { get; set; }

    public decimal? UnApprovedApcost { get; set; }

    public decimal? EstCost { get; set; }

    public decimal? AdjContract { get; set; }

    public decimal? EstBalance { get; set; }

    public decimal? CostPercentComplete { get; set; }

    public decimal? Jtdquantity { get; set; }

    public decimal? EstQuantity { get; set; }

    public decimal? EstBalanceQuantity { get; set; }

    public decimal? QtyPercentComplete { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? ProjectedLabor { get; set; }

    public decimal? LaborGainLoss { get; set; }

    public int? SortOrder { get; set; }
}
