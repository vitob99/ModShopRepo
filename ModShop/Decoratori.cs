#region DECORATORI GADGET
public class FunkoPop : Prodotto
{
    public FunkoPop(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Funko Pop! Iron Man";
    public override decimal GetPrezzo() => base.GetPrezzo() + 12.90m;
}

public class Portachiavi : Prodotto
{
    public Portachiavi(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Portachiavi Zelda (Triforza)";
    public override decimal GetPrezzo() => base.GetPrezzo() + 6.50m;
}

public class Tazza : Prodotto
{
    public Tazza(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Tazza Termica Pac-Man";
    public override decimal GetPrezzo() => base.GetPrezzo() + 14.00m;
}

public class Poster : Prodotto
{
    public Poster(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Poster Arrotolato One Piece";
    public override decimal GetPrezzo() => base.GetPrezzo() + 9.90m;
}

public class ActionFigure : Prodotto
{
    public ActionFigure(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Action Figure Goku SSJ";
    public override decimal GetPrezzo() => base.GetPrezzo() + 45.00m;
}
#endregion

#region DECORATORI FUMETTO
public class SpiderManBlue : Prodotto
{
    public SpiderManBlue(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Spider-Man: Blue";
    public override decimal GetPrezzo() => base.GetPrezzo() + 15.00m;
}

public class Superman : Prodotto
{
    public Superman(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Superman (Ed. Deluxe)";
    public override decimal GetPrezzo() => base.GetPrezzo() + 35.00m;
}

public class JusticeLeague : Prodotto
{
    public JusticeLeague(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Justice League Vol. 1";
    public override decimal GetPrezzo() => base.GetPrezzo() + 5.00m;
}

public class Batman : Prodotto
{
    public Batman(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Batman: Il Ritorno del Cavaliere Oscuro";
    public override decimal GetPrezzo() => base.GetPrezzo() + 20.00m;
}

public class Flash : Prodotto
{
    public Flash(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Flash Vol. 100";
    public override decimal GetPrezzo() => base.GetPrezzo() + 4.30m;
}
#endregion

#region DECORATORI OGGETTI DIGITALI
public class WallpaperArtistico : Prodotto
{
    public WallpaperArtistico(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Wallpaper Collezione Artistica";
    public override decimal GetPrezzo() => base.GetPrezzo() + 1.99m;
}

public class ColonnaSonora : Prodotto
{
    public ColonnaSonora(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Colonna Sonora Originale";
    public override decimal GetPrezzo() => base.GetPrezzo() + 9.99m;
}

public class Artbook : Prodotto
{
    public Artbook(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Artbook Digitale (PDF)";
    public override decimal GetPrezzo() => base.GetPrezzo() + 12.50m;
}

public class Skin : Prodotto
{
    public Skin(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Skin Esclusiva 'Pixel Hero'";
    public override decimal GetPrezzo() => base.GetPrezzo() + 4.99m;
}

public class AbbonamentoPremium : Prodotto
{
    public AbbonamentoPremium(ICatalogo oggetto) : base(oggetto) {}
    public override string Descrizione() => base.Descrizione() + " + Abbonamento Premium 1 Mese";
    public override decimal GetPrezzo() => base.GetPrezzo() + 7.00m;
}
#endregion