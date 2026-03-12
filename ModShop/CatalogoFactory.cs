public static class CatalogoFactory
{
    public static ICatalogo CreaOggetto(string tipo)
    {
        switch (tipo.ToUpper())
        {
            case "GADGET":
                return new Gadget();
            case "DIGITALE":
                return new Digitale();
            case "FUMETTO":
                return new Fumetto();
            default:
                throw new Exception("Prodotto base non presente nel Catalogo");
        }
    }
}