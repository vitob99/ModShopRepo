#region DECORATORI GADGET
public class FunkoPop : Prodotto
{
    public FunkoPop(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Funko Pop! Iron Man";
    }
}
public class Portachiavi : Prodotto
{
    public Portachiavi(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Portachiavi Zelda (Triforza)";
    }
}
public class Tazza : Prodotto
{
    public Tazza(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Tazza Termica Pac-Man";
    }
}
public class Poster : Prodotto
{
    public Poster(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Poster Arrotolato One Piece";
    }
}
public class ActionFigure : Prodotto
{
    public ActionFigure(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Action Figure Goku SSJ";
    }
}
#endregion

#region DECORATORI FUMETTO
public class SpiderManBlue : Prodotto
{
    public SpiderManBlue(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Spider-Man: Blue";
    }
}

public class Superman : Prodotto
{
    public Superman(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Superman (Ed. Deluxe)";
    }
}

public class JusticeLeague : Prodotto
{
    public JusticeLeague(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Justice League Vol. 1";
    }
}

public class Batman : Prodotto
{
    public Batman(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Batman: Il Ritorno del Cavaliere Oscuro";
    }
}

public class Flash : Prodotto
{
    public Flash(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Flash Vol. 100";
    }
}

#endregion

#region DECORATORI OGGETTI DIGITALI
public class WallpaperArtistico : Prodotto
{
    public WallpaperArtistico(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Wallpaper Collezione Artistica";
    }
}
public class ColonnaSonora : Prodotto
{
    public ColonnaSonora(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Colonna Sonora Originale";
    }
}
public class Artbook : Prodotto
{
    public Artbook(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Artbook Digitale (PDF)";
    }
}
public class Skin : Prodotto
{
    public Skin(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Skin Esclusiva 'Pixel Hero'";
    }
}
public class AbbonamentoPremium : Prodotto
{
    public AbbonamentoPremium(ICatalogo oggetto) : base(oggetto) {}

    public override string Descrizione()
    {
        return base.Descrizione() + "Abbonamento Premium 1 Mese";
    }
}
#endregion