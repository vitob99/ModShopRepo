class PromoPricingStrategy : IStrategyPagamento
{
    public decimal CalcolaPrezzo(decimal prezzo, string valuta, int iva, int sconto)
    {
        throw new NotImplementedException();
    }

    public string NomeStrategia()
    {
        return "Calcolo Prezzo Promo";
    }
}