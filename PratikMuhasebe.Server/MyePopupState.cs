using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyePopupState
{
    public byte PopupType { get; set; }

    public int PopupUsrno { get; set; }

    public string PopupMessageChar { get; set; } = null!;

    public short PopupMessageId { get; set; }

    public string? PopupAnswerChar { get; set; }

    public short? PopupAnswerId { get; set; }

    public string? PopupAnswerChar2 { get; set; }

    public short? PopupAnswerId2 { get; set; }

    public string? PopupPeriodType { get; set; }

    public short? PopupPeriodCount { get; set; }

    public short? PopupRepeatMax { get; set; }

    public DateTime? PopupStartDate { get; set; }

    public DateTime? PopupEndDate { get; set; }

    public short? PopupRepeatCount { get; set; }

    public DateTime? PopupLastShowDate { get; set; }

    public bool PopupActive { get; set; }
}
