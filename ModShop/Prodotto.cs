public abstract class Prodotto : ICatalogo //classe astratta del docoratore che implementa l'interfaccia di ICatalogo
{
    protected ICatalogo _oggetto; //riferimento del componente base tenuto degli oggetti reali che implementano l'interfaccia ICatalogo

    protected Prodotto(ICatalogo oggetto)
    {
        _oggetto = oggetto;
    }

    //implementazione del metodo virtual della classe astratta decoratore, chiama la funzione decora per decorare l'oggetto base in base al tipo ricevuto
    public virtual string Descrizione()
    {
        return _oggetto.Descrizione();
    }
}

