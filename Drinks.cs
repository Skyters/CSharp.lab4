using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.lab4
{

    public class Drink
    {
        public static Random rnd = new Random();

        public double Volume = 0.0; // объем напитка
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъём: {0} мл", this.Volume);
            return str;
        }
    }


    // сок
    public enum FruitType { Яблоко, Апельсин, Виноград, Мандарин, Арбуз }

    public class Juice : Drink
    {
        public FruitType UsedFruit = FruitType.Яблоко;  // используемый фрукт
        public bool HasPulp = true;         // наличие мякоти

        public override String GetInfo()
        {
            var str = "Я сок";
            str += base.GetInfo();
            str += String.Format("\nФрукт: {0}", this.UsedFruit);
            str += String.Format("\nНаличие мякоти: {0}", this.HasPulp);
            
            return str;
        }

        public static Juice Generate()
        {
            return new Juice
            {
                Volume = 75 + rnd.Next() % 1000, // объём от 75 до 1000 мл
                HasPulp = rnd.Next() % 2 == 0 // наличие мякоти true или false
            };
        }
    }

    // газировка
    public enum SodaType { Cola, Лимонад, Sprite, Fanta }

    public class Soda : Drink
    {
        public SodaType Type = SodaType.Cola;     // вид газировки
        public int BubblesCount = 1000;     // количество пузыриков

        public override String GetInfo()
        {
            var str = "Я газировка";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.Type);
            str += String.Format("\nКоличество пузыриков: {0}", this.BubblesCount);
            return str;
        }

        public static Soda Generate()
        {
            return new Soda
            {
                Volume = 75 + rnd.Next() % 200, // объём от 75 до 200 мл
                BubblesCount = 100 + rnd.Next() % 1000, // количество пузыриков
            };
        }
    }

    // алкоголь
    public enum AlcoholType { Пиво, Вино, Водка, Виски, Ром }

    public class Alcohol : Drink
    {
        public double Strength = 40.0;     // крепость (в процентах)
        public AlcoholType Type = AlcoholType.Водка;   // тип алкоголя

        public override String GetInfo()
        {
            var str = "Я алкоголь";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.Type);
            str += String.Format("\nкрепость: {0} %", this.Strength);
            return str;
        }

        public static Alcohol Generate()
        {
            return new Alcohol
            {
                Volume = 75 + rnd.Next() % 200, // объём от 75 до 200 мл
                Strength = 10 + rnd.Next() % 100, // крепость
            };
        }
    }
}