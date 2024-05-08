using System;
using System.Collections.Generic;

namespace AspNetCoreMVC_Layout.Models;

public partial class Hastalar
{
    public int Id { get; set; }

    public string HastaAd { get; set; } = null!;

    public string HastaSoyad { get; set; } = null!;

    public string Tckn { get; set; } = null!;

    public virtual ICollection<TahlilSonuclari> TahlilSonuclaris { get; set; } = new List<TahlilSonuclari>();
}
