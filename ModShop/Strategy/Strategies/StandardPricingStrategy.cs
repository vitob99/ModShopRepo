public class StandardPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        // Se US, convertiamo il prezzo base. Se EU, rimane invariato.
        return (regione == "US") ? prezzo * TASSO_US : prezzo;
    }

    public string NomeStrategia() => "Calcolo Prezzo Standard";
}