public sealed class AppContext
{
    private static readonly Lazy<AppContext> _instance = new (() => new AppContext());
    private List<IObserver> _listObs = [];
    public string _regione = string.Empty;
    private ICatalogo? _catalogo;
    public IStrategyPagamento? _strategy;

    public static AppContext Instance => _instance.Value;
    public string Regione { get => _regione; set => _regione = value; }
    public ICatalogo? Catalogo { get => _catalogo; set => _catalogo = value; }
    public IStrategyPagamento? Strategy { get => _strategy; set => _strategy = value; }

    private AppContext() { }

    public void SetCatalogo(ICatalogo c) => _catalogo = c;
    public void Attach(IObserver observer) => _listObs.Add(observer);
    public void Detach(IObserver observer) =>  _listObs.Remove(observer);
    
    private void NotifyStrategia()
    {
        foreach (var o in _listObs)
        {
            o.AggiornamentoCambioStrategia(_strategy!);
        }
    }
    
    private void NotifyDecorazione(string tipo)
    {
        foreach (var o in _listObs)
        {
            o.AggiornamentoCambioDecorazione(_catalogo!, tipo);
        }
    }

    private void NotifyCheckout()
    {
        foreach (var o in _listObs)
        {
            o.AggiornamentoCheckout(_catalogo!);
        }
    }

    // Metodo per settare lo Strategy
    public void SetStrategia(IStrategyPagamento s)
    {
        _strategy = s;
        NotifyStrategia();
    }

    public decimal CalcolaPrezzo(decimal prezzo)
    {
        if (_strategy == null)
            throw new Exception("Strategia non impostata");

        return _strategy.CalcolaPrezzo(prezzo, _regione!);
    }

    // Eventi extra
    public void AggiuntaDecorazione() => NotifyDecorazione("aggiunto");
    public void RimozioneDecorazione() => NotifyDecorazione("rimosso");

    public void Checkout(ICatalogo oggetto)
    {
        _catalogo = oggetto;
        NotifyCheckout();
    }

    // Seeding lista osservatori
    public void SeedListObs()
    {
        Attach(new Email());
        Attach(new Log());
        Attach(new UI());
    }
}