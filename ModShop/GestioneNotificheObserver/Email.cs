public class Email : IObserver
{
    public void AggiornamentoCambioDecorazione(ICatalogo c, string tipo) // + ICatalogo p o IProdotto
    {
        switch (tipo)
        {
            case "aggiunto":
                Console.WriteLine($"[EMAIL] Aggiunto {c.Descrizione()}");
                break;
            case "rimosso":
                Console.WriteLine($"[EMAIL] Rimosso {c.Descrizione()}");
                break;
        }
    }

    public void AggiornamentoCambioStrategia(IStrategyPagamento s) 
    {
        Console.WriteLine($"[EMAIL] - Strategia aggiornata => '{s.NomeStrategia()}'");
    }

    public void AggiornamentoCheckout(ICatalogo c) //ICatalogo p o IProdotto
    {
        Console.WriteLine($"[EMAIL] - Checkout => '{c.Descrizione()}'");
    }
}

