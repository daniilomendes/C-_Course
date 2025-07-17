namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("3 - Informações");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("-------------------------");
            short selectedOption = short.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1: Open(); break;
                case 2: Create(); break;
                case 3: Information(); break;
                case 4: Exit(); break;
                default: Menu(); break;
            }
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar o editor de texto :)\nVolte sempre!");
            Environment.Exit(0);
        }

        static void Information()
        {
            Console.Clear();
            Console.WriteLine("Ao criar ou editar um texto, você pode digitar e pular linhas a vontade.");
            Console.WriteLine("Quando finalizar, dê um último Enter e aperte Esc no seu teclado.");
            Console.WriteLine("Escolha um nome criativo para seu arquivo que represente bem ele.");
            Console.WriteLine("Ao salvar apertando Enter, um arquivo .txt será criado no seu projeto.");

            Console.ReadKey();
            Menu();
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do arquivo para abrir:");
            string value = Console.ReadLine().ToLower();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = Path.Combine(desktop, "Estudos Backend", "projects", "TextEditor");
            string path = Path.Combine(folder, $"{value}.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine($"Arquivo '{value}' não encontrado!");
                Console.ReadLine();
                Menu();
                return;
            }

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
            Menu();
        }

        static void Create()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
            Console.WriteLine("------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("DDigite o nome do arquivo:");
            string value = Console.ReadLine().ToLower();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = Path.Combine(desktop, "Estudos Backend", "projects", "TextEditor");
            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"{value}.txt");

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {value} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

    }
}