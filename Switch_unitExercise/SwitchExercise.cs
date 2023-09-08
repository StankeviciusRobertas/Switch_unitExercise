namespace Switch_unitExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo amziu: ");
            int age = Convert.ToInt32((string)Console.ReadLine());

            Console.WriteLine(WhoAreYouByAge(age));

            Console.WriteLine("Iveskite menesio skaiciu: ");
            int month = Convert.ToInt32((string)Console.ReadLine());

            Console.WriteLine(monthByNumber(month));

        }
        public static string WhoAreYouByAge(int age)
        {
            string category = age switch
            {
                < 7 => "Vaikas",
                <= 18 => "Moksleivis",
                < 25 => "Studentas",
                < 65 => "Darbuotojas",
                >= 65 => "Pensininkas",
            };
            return category;
        }
        public static string monthByNumber(int month)
        {
            string monthInt = month switch
            {
                1 => "Sausis",
                2 => "Vasaris",
                3 => "Kovas",
                4 => "Balandis",
                5 => "Geguze",
                6 => "Birzelis",
                7 => "Liepa",
                8 => "Rugpjutis",
                9 => "Rugsejis",
                10 => "Spalis",
                11 => "Lapkritis",
                12 => "Gruodis",
                _ => "Tokio menesio neegzistuoja",
            };
            return monthInt;
        }
    }
}