public sealed class AppContext
{
    private static readonly Lazy<AppContext> _instance = new (() => new AppContext());
    private List<IObserver> observers = new List<IObserver>();
    public static string? regione;
    public IStrategyPagamento? strategy;
    private ICatalogo? catalogo;

    public static AppContext Instance => _instance.Value;

    private AppContext() { }

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
            o.AggiornamentoCambioStrategia(strategy!);
        }
    }

    private void NotifyDecorazione(string tipo)
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCambioDecorazione(catalogo!, tipo);
        }
    }

    private void NotifyCheckout()
    {
        foreach (var o in observers)
        {
            o.AggiornamentoCheckout(catalogo!);
        }
    }

    // STRATEGY
    public void SetStrategia(IStrategyPagamento s)
    {
        strategy = s;
        NotifyStrategia();
    }

    public decimal CalcolaPrezzo(decimal prezzo)
    {
        if (strategy == null)
            throw new Exception("Strategia non impostata");

        return strategy.CalcolaPrezzo(prezzo, regione!);
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