public class Gadget : ICatalogo
{
    public string Descrizione() => "Gadget: ";
    public decimal GetPrezzo() => 0.00m; // Base del calcolo
}

public class Digitale : ICatalogo
{
    public string Descrizione() => "Oggetto Digitale: ";
    public decimal GetPrezzo() => 0.00m; // Base del calcolo
}

public class Fumetto : ICatalogo
{
    public string Descrizione() => "Fumetto: ";
    public decimal GetPrezzo() => 0.00m; // Base del calcolo
}