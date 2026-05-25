namespace CSharp.lab4
{
    public partial class Form1 : Form
    {

        List<Drink> drinksList = new List<Drink>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то сок
                        this.drinksList.Add(new Juice());
                        break;
                    case 1: // если 1 то газировка
                        this.drinksList.Add(new Soda());
                        break;
                    case 2: // если 2 то алкоголь
                        this.drinksList.Add(new Alcohol());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }


        // функция выводит информацию о количестве напитков на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            // пройдемся по всему списку
            foreach (var drink in this.drinksList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (drink is Juice) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    juiceCount += 1;
                }
                else if (drink is Soda)
                {
                    sodaCount += 1;
                }
                else if (drink is Alcohol)
                {
                    alcoholCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Сок\tГазировка\tАлкоголь"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t\t{2}", juiceCount, sodaCount, alcoholCount);
        }
    }
}
