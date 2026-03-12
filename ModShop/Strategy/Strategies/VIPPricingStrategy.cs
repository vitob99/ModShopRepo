public class VIPPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    const int VIP_DISCOUNT = 7;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        if(regione == "US")
        {
            return prezzo - prezzo * VIP_DISCOUNT / 100 / TASSO_US;
        }
        return prezzo - (prezzo * VIP_DISCOUNT / 100);
    }

    public string NomeStrategia()
    {
        return "Calcolo Prezzo VIP";
    }
}