public class Email : IObserver
{
    public void AggiornamentoCambioDecorazione(string tipo) // + ICatalogo p o IProdotto
    {
        switch (tipo)
        {
            case "aggiunto":
                Console.WriteLine($"");
                break;
            case "rimosso":
                Console.WriteLine($"");
                break;
        }
    }

    public void AggiornamentoCambioStrategia(IStrategyPagamento s) 
    {
        Console.WriteLine($"[EMAIL] - Strategia aggiornata => '{s.NomeStrategia()}'");
    }

    public void AggiornamentoCheckout() //ICatalogo p o IProdotto
    {
        throw new NotImplementedException();
    }
}

