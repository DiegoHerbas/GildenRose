namespace SolucionEstrategia
{
    public class DecrementQualityBehavior : IUpdateBehavior
    {
        int ValorDecremento;
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                ValorDecremento = 1;
            }
            else
            {
                ValorDecremento = 2;
            }

            item.Quality = item.Quality - ValorDecremento;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
