public class StandardPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        // Convertiamo se necessario
        return (regione == "US") ? prezzo * TASSO_US : prezzo;
    }

    public string NomeStrategia() => "Calcolo prezzo (Standard)";
}