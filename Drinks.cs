using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.lab4
{

    public class Drink
    {
        public virtual String GetInfo()
        {
            return "Я напиток";
        }
    }




    // сок
    public enum FruitType { Apple, Orange, Grape, Mandarin, Watermelon }

    public class Juice : Drink
    {
        public double Volume = 0.0;        // объем напитка
        public FruitType UsedFruit = FruitType.Apple;  // используемый фрукт
        public bool HasPulp = true;         // наличие мякоти

        public override String GetInfo()
        {
            return "Я сок";
        }
    }

    // газировка
    public enum SodaType { Cola, Lemonade, Tonic, Sprite, Fanta }

    public class Soda : Drink
    {
        public double Volume = 0.0;        // объем напитка
        public SodaType Type = SodaType.Cola;     // вид газировки
        public int BubblesCount = 1000;     // количество пузыриков

        public override String GetInfo()
        {
            return "Я газировка";
        }
    }

    // алкоголь
    public enum AlcoholType { Beer, Wine, Vodka, Cognac, Whiskey, Rum }

    public class Alcohol : Drink
    {
        public double Volume = 0.0;        // объем напитка
        public double Strength = 40.0;     // крепость (в процентах)
        public AlcoholType Type = AlcoholType.Vodka;   // тип алкоголя

        public override String GetInfo()
        {
            return "Я алкоголь";
        }
    }
}