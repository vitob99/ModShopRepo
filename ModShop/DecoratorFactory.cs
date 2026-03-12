public static class DecoratorFactory
{
    public static ICatalogo Decora(ICatalogo oggettoBase, int scelta)
    {
        if (oggettoBase is Gadget)
        {
            return scelta switch
            {
                1 => new FunkoPop(oggettoBase),
                2 => new Portachiavi(oggettoBase),
                3 => new Tazza(oggettoBase),
                4 => new Poster(oggettoBase),
                5 => new ActionFigure(oggettoBase),
                _ => oggettoBase
            };
        }

        if (oggettoBase is Fumetto)
        {
            return scelta switch
            {
                1 => new SpiderManBlue(oggettoBase),
                2 => new Superman(oggettoBase),
                3 => new JusticeLeague(oggettoBase),
                4 => new Batman(oggettoBase),
                5 => new Flash(oggettoBase),
                _ => oggettoBase
            };
        }

        if (oggettoBase is Digitale)
        {
            return scelta switch
            {
                1 => new WallpaperArtistico(oggettoBase),
                2 => new ColonnaSonora(oggettoBase),
                3 => new Artbook(oggettoBase),
                4 => new Skin(oggettoBase),
                5 => new AbbonamentoPremium(oggettoBase),
                _ => oggettoBase
            };
        }

        return oggettoBase;
    }
}