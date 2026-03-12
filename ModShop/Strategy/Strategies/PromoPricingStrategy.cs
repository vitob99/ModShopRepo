public class PromoPricingStrategy : IStrategyPagamento
{
    const int PROMO_DISCOUNT = 5;
    const decimal TASSO_US = 1.0771m;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        if(regione == "US")
        {
            return prezzo - prezzo * PROMO_DISCOUNT / 100 / TASSO_US;
        }
        return prezzo - (prezzo * PROMO_DISCOUNT / 100);
    }
    public string NomeStrategia()
    {
        return "Calcolo Prezzo Promo";
    }
}