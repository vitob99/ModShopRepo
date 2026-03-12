public static class DecoratorFactory
{
    public static ICatalogo Decora(ICatalogo oggettoBase, int scelta)
    {
        if (oggettoBase is Gadget)
        {
            switch (scelta)
            {
                case 1: return new FunkoPop(oggettoBase);
                case 2: return new Portachiavi(oggettoBase);
                case 3: return new Tazza(oggettoBase);
                case 4: return new Poster(oggettoBase);
                case 5: return new ActionFigure(oggettoBase);
            }
        }

        if (oggettoBase is Fumetto)
        {
            switch (scelta)
            {
                case 1: return new SpiderManBlue(oggettoBase);
                case 2: return new Superman(oggettoBase);
                case 3: return new JusticeLeague(oggettoBase);
                case 4: return new Batman(oggettoBase);
                case 5: return new Flash(oggettoBase);
            }
        }

        if (oggettoBase is Digitale)
        {
            switch (scelta)
            {
                case 1: return new WallpaperArtistico(oggettoBase);
                case 2: return new ColonnaSonora(oggettoBase);
                case 3: return new Artbook(oggettoBase);
                case 4: return new Skin(oggettoBase);
                case 5: return new AbbonamentoPremium(oggettoBase);
            }
        }

        return oggettoBase;
    }
}