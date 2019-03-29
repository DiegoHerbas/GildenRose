namespace SolucionEstrategia
{
    public class LegendaryBehavior : IUpdateBehavior
    {
        int qualityOfLegendary = 80;
        public void UpdateQuality(Item item)
        {
            item.Quality = qualityOfLegendary;
        }
    }
}
