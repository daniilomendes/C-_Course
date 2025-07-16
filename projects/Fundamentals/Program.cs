

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 25;
            // var text = "Hello, World!";

            // Console.WriteLine(age);
            // Console.WriteLine(text);

            // convertendo tipos
            // int inteiro = 100;
            // float real = 25.3f;

            // inteiro = (int)real;
            // inteiro = int.Parse(valorReal);
            // Console.WriteLine(inteiro);

            // string valorReal = real.ToString();
            // inteiro = Convert.ToInt32(real);

            // Console.WriteLine(inteiro);
            // Console.WriteLine(Convert.ToBoolean(2));

            // Operadores
            // int valueOne = 2;
            // int x = valueOne + 15;
            // Console.WriteLine(x);

            // Condicional IF
            // if (25 == 32) {
            //     Console.WriteLine("não");
            // } else {
            //     Console.WriteLine("finalizou");
            // }
            // MeuMetodo("Testando");
            // string nome = RetornaNome("Danilo", "Mendes");
            // string outroNome = RetornaNome("Danilo", "Mendes", 25);
            // Console.WriteLine(nome);
            // Console.WriteLine(outroNome);

            Product mouse = new Product(1, "Mouse", 299.97, EProductType.Product);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
        }

        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 25)
        {
            return nome + " " + sobrenome + " tem " + idade;
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2,
    }

}