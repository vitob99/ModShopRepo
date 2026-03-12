public class StandardPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        if(regione == "US")
        {
            return prezzo / TASSO_US;
        }
        return prezzo;
    }

    public string NomeStrategia()
    {
        return "Calcolo Prezzo Standard";
    }
}