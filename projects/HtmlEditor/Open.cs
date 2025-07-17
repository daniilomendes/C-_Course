namespace HtmlEditor
{
    class Open
    {
        public static void HandleOpen()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do arquivo para abrir:");
            string value = Console.ReadLine().ToLower();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = Path.Combine(desktop, "Estudos Backend", "projects", "HtmlEditor");
            string path = Path.Combine(folder, $"{value}.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine($"Arquivo '{value}' não encontrado!");
                Console.ReadLine();
                Menu.Show();
                return;
            }

            Console.Clear();
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Viewer.Show(text);
            }

            Console.ReadLine();
            Menu.Show();
        }
    }
}