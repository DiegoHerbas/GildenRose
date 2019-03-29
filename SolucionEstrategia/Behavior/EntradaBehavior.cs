namespace SolucionEstrategia
{
    public class EntradaBehavior : IUpdateBehavior
    {

        //El item “Backstage passes", como el “Aged Brie", incrementa su Quality 
        //a medida que se acerca a su valor de sellIn: el Quality se duplica cuando hay 10 días o menos,
        //    se triplica cuando hay 5 días o menos, y se anula cuando se pasó la fecha de venta.
        public void UpdateQuality(Item item)
        {
            if (item.SellIn == 0) { item.Quality = 0; return; }

            if (item.SellIn > 10) item.Quality = item.Quality + 1;
            else if (item.SellIn > 5) item.Quality = item.Quality + 2;
            else item.Quality = item.Quality + 3;





        }
    }
}
