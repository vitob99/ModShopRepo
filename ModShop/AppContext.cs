public sealed class AppContext
{
    private static AppContext _instance;

    private List<IObserver> observers = new List<IObserver>();

    private IStrategyPagamento strategy;
    private ICatalogo catalogo;

    private AppContext() { }

    public static AppContext GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AppContext();
        }

        return _instance;
    }

    // impostazione catalogo
    public void SetCatalogo(ICatalogo c)
    {
        catalogo = c;
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

    private void NotifyStrategia()
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCambioStrategia(strategy);
        }
    }

    private void NotifyDecorazione(string tipo)
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCambioDecorazione(catalogo, tipo);
        }
    }

    private void NotifyCheckout()
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCheckout(catalogo);
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