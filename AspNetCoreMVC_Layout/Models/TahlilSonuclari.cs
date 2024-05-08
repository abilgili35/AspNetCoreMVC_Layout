using System;
using System.Collections.Generic;

namespace AspNetCoreMVC_Layout.Models;

public partial class TahlilSonuclari
{
    public int Id { get; set; }

    public DateTime TahlilZamani { get; set; }

    public string TahlilDosyaLinki { get; set; } = null!;

    public int HastalarId { get; set; }

    public virtual Hastalar Hastalar { get; set; } = null!;
}
