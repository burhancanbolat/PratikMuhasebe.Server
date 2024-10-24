using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeUserDataScheme
{
    public int TableId { get; set; }

    public string FieldName { get; set; } = null!;

    public int? FieldOrder { get; set; }

    public string? DisplayName { get; set; }

    public byte? FieldType { get; set; }

    public int? FieldLength { get; set; }

    public int? DecimalLength { get; set; }

    public byte? LookUpKind { get; set; }

    public int? LookUpTable { get; set; }

    public string? LookUpField { get; set; }

    public string? LookUpChoose { get; set; }

    public bool? LookUpMultiSelect { get; set; }

    public string? LookUpString { get; set; }

    public bool? LookUpF10mandatory { get; set; }

    public string? GroupName { get; set; }

    public bool? ApplyCriteria { get; set; }

    public byte? Cr1Field { get; set; }

    public byte? Cr1Operation { get; set; }

    public string? Cr1Value { get; set; }

    public byte? Cr1Link { get; set; }

    public byte? Cr2Field { get; set; }

    public byte? Cr2Operation { get; set; }

    public string? Cr2Value { get; set; }

    public byte? Cr2Link { get; set; }

    public byte? Cr3Field { get; set; }

    public byte? Cr3Operation { get; set; }

    public string? Cr3Value { get; set; }

    public byte? Cr3Link { get; set; }

    public int? RaporDesignId { get; set; }
}
