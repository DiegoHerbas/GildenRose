using System.Collections.Generic;

namespace SolucionEstrategia
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                ITipoItem estrategia = getEstrategiaItem(item);
                estrategia.Actualizar(item);
                item.SellIn = item.SellIn > 0 ? item.SellIn - 1 : 0;
            }
        }

        private ITipoItem getEstrategiaItem(Item item)
        {
            if (item.Name.Contains("Aged Brie"))
                return new TipoItem(new IncrementQualityBehavior());
            if (item.Name.Contains("Conjured"))
                return new TipoItem(new DecrementTwiceBehavior());
            if (item.Name.Contains("Sulfuras"))
                return new TipoItem(new LegendaryBehavior());
            if (item.Name.Contains("Backstage passes"))
                return new TipoItem(new EntradaBehavior());
            return new TipoItem(new DecrementQualityBehavior());
        }
    }




}
