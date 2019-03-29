namespace SolucionEstrategia
{
    public class IncrementQualityBehavior : IUpdateBehavior
    {
        int valorAumento = 1;
        public void UpdateQuality(Item item)
        {
            item.Quality = item.Quality + valorAumento;

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
