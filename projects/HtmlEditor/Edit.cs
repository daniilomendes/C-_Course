using System.Text;

namespace HtmlEditor
{
    public static class Edit
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");

            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("AAperte 1 para salvar o arquivo.");
            Console.WriteLine("Aperte 0 para sair.");

            short value = short.Parse(Console.ReadLine());

            if (value == 1)
            {
                Save.SaveText(file);
            }
            else
            {
                Menu.Show();
            }
        }
    }
}