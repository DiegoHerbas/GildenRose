namespace SolucionEstrategia
{
    public class DecrementTwiceBehavior : IUpdateBehavior
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = item.Quality - 2;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
