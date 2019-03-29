using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolucionEstrategia;
using System.Collections.Generic;

namespace SolucionTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void testDecrementQuality()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(19, item.Quality);
        }

        [TestMethod]
        public void testDecrementX2Quality()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(18, item.Quality);
        }
        [TestMethod]
        public void testDecrementNonNegativeQuality()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 20, Quality = 0 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(0, item.Quality);
        }
        [TestMethod]
        public void testIncrementQuality()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(1, item.Quality);
        }
        [TestMethod]
        public void testIncrementQualityNoMoreThan50()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(50, item.Quality);
        }
        [TestMethod]
        public void testIncrementLegendary()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(80, item.Quality);
        }
        [TestMethod]
        public void testIncrementBackstage()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(21, item.Quality);
        }
        [TestMethod]
        public void testIncrementBackstage2()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(23, item.Quality);
        }
        [TestMethod]
        public void testIncrementBackstage3()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Backstage passes to a TAFKAL", SellIn = 10, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(22, item.Quality);
        }
        [TestMethod]
        public void testIncrementBackstage4()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(23, item.Quality);
        }
        [TestMethod]
        public void testIncrementBackstage5()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(0, item.Quality);
        }
        [TestMethod]
        public void testDecrementConjured()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 4, Quality = 6 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(4, item.Quality);
        }
        [TestMethod]
        public void testDecrementConjuredNonNegative()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 0 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(0, item.Quality);
        }
        [TestMethod]
        public void testDecrementX2Conjured()
        {
            IList<Item> Items = new List<Item>();
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 8 };
            Items.Add(item);

            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(6, item.Quality);
        }
    }

}
