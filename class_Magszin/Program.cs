namespace class_Magszin
{
    class Shop
    {
        private string title;
        private string address;
        private string description;
        private string telephone;
        private string email;

        public void PreviouslySeen()
        {
            Console.WriteLine("Введите название магазина:");
            title = Console.ReadLine();

            Console.WriteLine("Введите адрес магазина:");
            address = Console.ReadLine();

            Console.WriteLine("Введите описание профиля магазина:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            telephone = Console.ReadLine();

            Console.WriteLine("Введите контактный e-mail:");
            email = Console.ReadLine();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Название магазина: " + title);
            Console.WriteLine("Адрес магазина: " + address);
            Console.WriteLine("Описание профиля магазина: " + description);
            Console.WriteLine("Контактный телефон: " + telephone);
            Console.WriteLine("Контактный e-mail: " + email);
        }

        public string GetName()
        {
            return title;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetPhone()
        {
            return telephone;
        }

        public string GetEmail()
        {
            return email;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop магазин = new Shop();

            магазин.PreviouslySeen();
            магазин.DisplayInfo();

            Console.ReadLine();
        }
    }
}
