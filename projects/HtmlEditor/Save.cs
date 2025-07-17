using System.Text;

namespace HtmlEditor
{
    public static class Save
    {

        public static void SaveText(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do arquivo:");
            string value = Console.ReadLine().ToLower();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = Path.Combine(desktop, "Estudos Backend", "projects", "HtmlEditor");
            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"{value}.txt");

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {value} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }

    }
}