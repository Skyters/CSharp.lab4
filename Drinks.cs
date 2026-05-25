using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.lab4
{
    // сок
    public enum FruitType { Apple, Orange, Grape, Mandarin, Watermelon }

    public class Juice
    {
        public double Volume = 0.0;        // объем напитка
        public FruitType UsedFruit = FruitType.Apple;  // используемый фрукт
        public bool HasPulp = true;         // наличие мякоти
    }

    // газировка
    public enum SodaType { Cola, Lemonade, Tonic, Sprite, Fanta }

    public class Soda
    {
        public double Volume = 0.0;        // объем напитка
        public SodaType Type = SodaType.Cola;     // вид газировки
        public int BubblesCount = 1000;     // количество пузыриков
    }

    // алкоголь
    public enum AlcoholType { Beer, Wine, Vodka, Cognac, Whiskey, Rum }

    public class Alcohol
    {
        public double Volume = 0.0;        // объем напитка
        public double Strength = 40.0;     // крепость (в процентах)
        public AlcoholType Type = AlcoholType.Vodka;   // тип алкоголя
    }
}