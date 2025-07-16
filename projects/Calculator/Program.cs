namespace Calculator
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

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
            Console.Write("Selecione uma opção: ");
            short selectedOption = short.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Exit(); break;
                default: Menu(); break;
            }
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar a calculadora :)\nVolte sempre!");
            System.Environment.Exit(0);
        }

        static (float valueOne, float valueTwo) ChooseValues()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float valueOne = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            return (valueOne, valueTwo);
        }
        static void ShowResult(float result)
        {
            Console.WriteLine("Resultado: " + result);
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }


        static void Sum()
        {
            var (valueOne, valueTwo) = ChooseValues();

            float result = valueOne + valueTwo;
            ShowResult(result);
        }

        static void Subtract()
        {
            var (valueOne, valueTwo) = ChooseValues();

            float result = valueOne - valueTwo;
            ShowResult(result);
        }

        static void Division()
        {
            var (valueOne, valueTwo) = ChooseValues();

            float result = valueOne / valueTwo;
            ShowResult(result);
        }

        static void Multiplication()
        {
            var (valueOne, valueTwo) = ChooseValues();

            float result = valueOne * valueTwo;
            ShowResult(result);
        }
    }
}