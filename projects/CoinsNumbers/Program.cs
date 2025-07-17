using System.Globalization;

namespace CoinsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // TIPO PARA MOEDAS
            // Precisão grande usa decimal, é o mais recomendado
            // porém vai da necessidade
            // var value = 10.25m;

            // Console.WriteLine(value);
            // -------------------------------------------------------------------------------------------------

            // FORMATANDO MOEDAS
            // decimal value = 10536.25m;

            // Console.WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
            // Console.WriteLine(value.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(value.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
            // -------------------------------------------------------------------------------------------------

            // MATH
            decimal value = 10536.75m;

            Console.WriteLine(Math.Round(value));
            Console.WriteLine(Math.Ceiling(value));
            Console.WriteLine(Math.Floor(value));
            // -------------------------------------------------------------------------------------------------
        }
    }
}