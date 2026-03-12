public abstract class Prodotto : ICatalogo
{
    protected ICatalogo _oggetto;

    protected Prodotto(ICatalogo oggetto)
    {
        _oggetto = oggetto;
    }

    public virtual string Descrizione() => _oggetto.Descrizione();
    
    // Il decoratore base rimanda il prezzo all'oggetto interno
    public virtual decimal GetPrezzo() => _oggetto.GetPrezzo();
}