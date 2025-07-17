namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar o editor de HTML :)\nVolte sempre!");
            Environment.Exit(0);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++) Console.Write("-");
            Console.Write("+");

            Console.Write("\n");
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");

            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++) Console.Write("-");
            Console.Write("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Edit.Show(); break;
                case 2: Open.HandleOpen(); break;
                case 3: Exit(); break;
                default: Show(); break;
            }
        }
    }
}