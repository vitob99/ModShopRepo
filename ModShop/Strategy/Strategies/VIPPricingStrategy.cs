public class VIPPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    const int VIP_DISCOUNT = 7;

    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        decimal prezzoScontato = prezzo - (prezzo * VIP_DISCOUNT / 100);

        if (regione == "US")
        {
            // Se il prezzo base è in Euro, lo moltiplichiamo per il tasso per avere i Dollari
            return prezzoScontato * TASSO_US;
        }
        
        return prezzoScontato;
    }

    public string NomeStrategia()
    {
        return "Calcolo Prezzo VIP";
    }
}