public static class DecoratorFactory
{
    public static ICatalogo Decora(ICatalogo oggettoCorrente, int scelta)
    {
        string desc = oggettoCorrente.Descrizione();

        // Controlliamo se la descrizione inizia con la stringa della categoria
        if (desc.StartsWith("Gadget"))
        {
            return scelta switch
            {
                1 => new FunkoPop(oggettoCorrente),
                2 => new Portachiavi(oggettoCorrente),
                3 => new Tazza(oggettoCorrente),
                4 => new Poster(oggettoCorrente),
                5 => new ActionFigure(oggettoCorrente),
                _ => oggettoCorrente
            };
        }

        if (desc.StartsWith("Fumetto"))
        {
            return scelta switch
            {
                1 => new SpiderManBlue(oggettoCorrente),
                2 => new Superman(oggettoCorrente),
                3 => new JusticeLeague(oggettoCorrente),
                4 => new Batman(oggettoCorrente),
                5 => new Flash(oggettoCorrente),
                _ => oggettoCorrente
            };
        }

        if (desc.StartsWith("Oggetto Digitale"))
        {
            return scelta switch
            {
                1 => new WallpaperArtistico(oggettoCorrente),
                2 => new ColonnaSonora(oggettoCorrente),
                3 => new Artbook(oggettoCorrente),
                4 => new Skin(oggettoCorrente),
                5 => new AbbonamentoPremium(oggettoCorrente),
                _ => oggettoCorrente
            };
        }

        return oggettoCorrente;
    }
}