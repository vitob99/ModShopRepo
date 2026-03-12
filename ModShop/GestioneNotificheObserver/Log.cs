public class Log : IObserver
{
    public void AggiornamentoCambioDecorazione(ICatalogo c, string tipo) // + ICatalogo p o IProdotto
    {
        switch (tipo)
        {
            case "aggiunto":
                Console.WriteLine($"[LOG] - {DateTime.Now} => Modifica aggiunta...");
                break;
            case "rimosso":
                Console.WriteLine($"[LOG] - {DateTime.Now} => Modifica rimossa...");
                break;
        }
    }

    public void AggiornamentoCambioStrategia(IStrategyPagamento s)   
    {
        Console.WriteLine($"[LOG] - {DateTime.Now} - Strategia aggiornata => '{s.NomeStrategia()}'");
    }

    public void AggiornamentoCheckout(ICatalogo c) //ICatalogo p o IProdotto
    {
        Console.WriteLine($"[LOG] - {DateTime.Now} - Checkout => Erogato il checkout");
    }
}