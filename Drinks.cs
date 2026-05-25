using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.lab4
{

    public class Drink
    {
        public double Volume = 0.0; // объем напитка
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъём: {0} мл", this.Volume);
            return str;
        }
    }


    // сок
    public enum FruitType { Apple, Orange, Grape, Mandarin, Watermelon }

    public class Juice : Drink
    {
        public FruitType UsedFruit = FruitType.Apple;  // используемый фрукт
        public bool HasPulp = true;         // наличие мякоти

        public override String GetInfo()
        {
            var str = "Я сок";
            str += base.GetInfo();
            return str;
        }
    }

    // газировка
    public enum SodaType { Cola, Lemonade, Tonic, Sprite, Fanta }

    public class Soda : Drink
    {
        public SodaType Type = SodaType.Cola;     // вид газировки
        public int BubblesCount = 1000;     // количество пузыриков

        public override String GetInfo()
        {
            var str = "Я газировка";
            str += base.GetInfo();
            return str;
        }
    }

    // алкоголь
    public enum AlcoholType { Beer, Wine, Vodka, Cognac, Whiskey, Rum }

    public class Alcohol : Drink
    {
        public double Strength = 40.0;     // крепость (в процентах)
        public AlcoholType Type = AlcoholType.Vodka;   // тип алкоголя

        public override String GetInfo()
        {
            var str = "Я алкоголь";
            str += base.GetInfo();
            return str;
        }
    }
}