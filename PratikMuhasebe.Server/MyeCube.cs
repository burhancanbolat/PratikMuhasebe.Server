using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeCube
{
    public int CubeId { get; set; }

    public short? CubeCreateUser { get; set; }

    public DateTime? CubeCreateDate { get; set; }

    public short? CubeLastupUser { get; set; }

    public DateTime? CubeLastupDate { get; set; }

    public short? CubeLastrunUser { get; set; }

    public DateTime? CubeLastrunDate { get; set; }

    public int? CubeLastrunDuration { get; set; }

    public string? CubeName { get; set; }

    public byte? CubeGroup { get; set; }

    public string? CubeDesc { get; set; }

    public bool? CubeHidden { get; set; }

    public bool? CubeLocked { get; set; }

    public string? CubeFilename { get; set; }

    public byte? CubeDateType { get; set; }

    public DateTime? CubeFirstdate { get; set; }

    public DateTime? CubeLastdate { get; set; }

    public int? CubeDateN { get; set; }

    public string? CubeFirmastr { get; set; }

    public int? CubeMaliyil { get; set; }

    public byte? CubeAutorunpattern { get; set; }

    public int? CubeAutorunperiod { get; set; }

    public DateTime? CubeAutoruntime { get; set; }

    public int? CubeAutorunselection { get; set; }

    public string? CubeOtherDbs { get; set; }

    public string? CubeQuery { get; set; }
}
