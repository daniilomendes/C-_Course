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

            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("I = Informações");
            Console.WriteLine("Sair = Sair");
            Console.WriteLine("---------------------------");

            string value = Console.ReadLine().ToLower();

            if (value == "sair") Exit();
            if (value == "i") Information();

            char type = char.Parse(value.Substring(value.Length - 1, 1));
            int time = int.Parse(value.Substring(0, value.Length - 1));

            int multiplaier = 1;

            if (type == 'm') multiplaier = 60;

            PreStart(time * multiplaier);
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar o Stopwatch :)\nVolte sempre!");
            Environment.Exit(0);
        }

        static void Information()
        {
            Console.Clear();
            Console.WriteLine("Ao digitar 10s, está escolhendo segundos, ou seja, 10s é igual a 10 segundos.");
            Console.WriteLine("Ao digitar 10m, está escolhendo minutos, ou seja, 1m é igual a 60 segundos.");
            Console.WriteLine("Ao digitar sair, estara encerrando a aplicação.");
            Console.WriteLine("\nSegurando Ctrl e apertando C no teclado interrompe e encerra a contagem.");
            Console.WriteLine("\nDica: digite o tempo e logo após se prefere minuto ou segundo.");
            Console.WriteLine("Ex.: 10s");
            Console.ReadKey();
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!!");
            Thread.Sleep(1000);
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(1000);
            Console.Clear();
            Menu();
        }
    }
}