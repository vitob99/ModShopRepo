public class Gadget : ICatalogo
{
    //public required string Produttore;
    //public bool isLimited;

    public string Descrizione()
    {
        return "Gadget";
    }
}

public class Digitale : ICatalogo
{
    //public required string Produttore;
    //public bool isLimited;

    public string Descrizione()
    {
        return "Oggetto Digitale";
    }
}

public class Fumetto : ICatalogo
{
    //public required string Produttore;
    //public bool isLimited;

    public string Descrizione()
    {
        return "Fumetto";
    }
}