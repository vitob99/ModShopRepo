public class UI : IObserver
{
    public void AggiornamentoCambioDecorazione(ICatalogo c, string tipo) // + ICatalogo p o IProdotto
    {
        switch (tipo)
        {
            case "aggiunto":
                Console.WriteLine($"Aggiunta: {c.Descrizione()}");
                break;
            case "rimosso":
                Console.WriteLine($"Rimossa: {c.Descrizione()}");
                break;
        }
    }

    public void AggiornamentoCambioStrategia(IStrategyPagamento s)  
    {
        Console.WriteLine($"[UI] - Strategia aggiornata => '{s.NomeStrategia()}'");
    }

    public void AggiornamentoCheckout(ICatalogo c) 
    {
        Console.WriteLine($"[UI] - CHECKOUT => '{c.Descrizione()}'");
    }

}