public sealed class AppContext
{
    private static AppContext _instance;

    private List<IObserver> observers = new List<IObserver>();

    private IStrategyPagamento strategy;

    private AppContext() { }

    public static AppContext GetInstance()
    {
        if (_instance == null)
        {
            return _instance = new AppContext();
        }

        return _instance;
    }

    // GESTIONE OBSERVER
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyStrategia() //notifica che va richiamata dopo il cambio di strategia
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCambioStrategia(strategy);
        }
    }

    private void NotifyDecorazione(string tipo) //notifica che va richiamata dopo la funzione Decora()
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCambioDecorazione(tipo);
        }
    }

    private void NotifyCheckout() //notifica che va richiamata per il riepilogo dell'ordine
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCheckout();
        }
    }


    // STRATEGY
    public void SetStrategia(IStrategyPagamento s)
    {
        strategy = s;
        NotifyStrategia();
    }

    public decimal CalcolaPrezzo(decimal prezzo, string valuta, int iva, int sconto)
    {
        if (strategy == null)
            throw new Exception("Strategia non impostata");

        return strategy.CalcolaPrezzo(prezzo, valuta, iva, sconto);
    }


    // EVENTI EXTRA
    public void AggiuntaDecorazione()
    {
        NotifyDecorazione("aggiunto");
    }

    public void RimozioneDecorazione()
    {
        NotifyDecorazione("rimosso");
    }

    public void Checkout()
    {
        NotifyCheckout();
    }
}