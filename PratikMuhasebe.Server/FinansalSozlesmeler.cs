using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FinansalSozlesmeler
{
    public Guid FsGuid { get; set; }

    public short FsDbcno { get; set; }

    public int? FsSpecRecNo { get; set; }

    public bool? FsIptal { get; set; }

    public short? FsFileid { get; set; }

    public bool? FsHidden { get; set; }

    public bool? FsKilitli { get; set; }

    public bool? FsDegisti { get; set; }

    public int? FsChecksum { get; set; }

    public short? FsCreateUser { get; set; }

    public DateTime FsCreateDate { get; set; }

    public short? FsLastupUser { get; set; }

    public DateTime? FsLastupDate { get; set; }

    public string? FsSpecial1 { get; set; }

    public string? FsSpecial2 { get; set; }

    public string? FsSpecial3 { get; set; }

    public int? FsFirmano { get; set; }

    public int? FsSubeno { get; set; }

    public string? FsSozkodu { get; set; }

    public string? FsSozaciklama { get; set; }

    public string? FsSozcarikodu { get; set; }

    public string? FsKvertfingidkodu { get; set; }

    public string? FsUvertfingidkodu { get; set; }

    public string? FsFinasmangidkodu { get; set; }

    public string? FsKvfinkiraborckodu { get; set; }

    public string? FsUvfinkiraborckodu { get; set; }

    public short? FsTaksitSayisi { get; set; }

    public byte? FsDovizcinsi { get; set; }
}
