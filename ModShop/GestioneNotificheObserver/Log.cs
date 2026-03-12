public class Log : IObserver
{
    public void AggiornamentoCambioDecorazione(ICatalogo c, string tipo) // + ICatalogo p o IProdotto
    {
        switch (tipo)
        {
            case "aggiunto":
                Console.WriteLine($"[{DateTime.Now}] - Modifica aggiunta...");
                break;
            case "rimosso":
                Console.WriteLine($"[{DateTime.Now}] - Modifica rimossa...");
                break;
        }
    }

    public void AggiornamentoCambioStrategia(IStrategyPagamento s)   
    {
        Console.WriteLine($"[{DateTime.Now}] - Strategia aggiornata => '{s.NomeStrategia()}'");
    }

    public void AggiornamentoCheckout(ICatalogo c) //ICatalogo p o IProdotto
    {
        Console.WriteLine($"[{DateTime.Now}] - Erogato il checkout");
    }
}