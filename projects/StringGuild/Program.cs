using System.Text;

namespace StringGuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // GUID
            // var id = Guid.NewGuid();
            // id.ToString();
            // id = new Guid("");
            // id.ToString().Substring(0, 8);
            // id = new Guid();
            // Console.WriteLine(id.ToString().Substring(0, 8));
            // -------------------------------------------------------------------------------------------------

            // INTERPOLAÇÃO DE STRINGS
            // var price = 10.2;
            // var text = "O preço do produto é " + price + " apenas na promoção.";
            // var text = string.Format("O preço do produto é {0} apenas na promoção.", price);
            // var text = $"O preço do produto é {price} apenas na promoção.";
            // @ antes das "" permite quebrar o texto
            // /n quebra o texto
            // Console.WriteLine(text);
            // -------------------------------------------------------------------------------------------------

            // COMPARAÇÃO DE TEXTO
            // var text = "Testando";
            // var text2 = "Este texto é um teste";
            // Console.WriteLine(text.CompareTo("Testando"));
            // Console.WriteLine(text.CompareTo("testando"));
            // Console.WriteLine(text.Contains("Testando"));
            // Console.WriteLine(text2.Contains("teste"));
            // Console.WriteLine(text2.Contains("Teste"));
            // Console.WriteLine(text2.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            // -------------------------------------------------------------------------------------------------

            // StartsWith e EndsWith
            // var text = "Este texto é um teste";
            // Console.WriteLine(text.StartsWith("Este"));
            // Console.WriteLine(text.StartsWith("este"));
            // Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine(text.EndsWith("teste"));
            // Console.WriteLine(text.EndsWith("Teste"));
            // Console.WriteLine(text.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            // -------------------------------------------------------------------------------------------------

            // EQUALS
            // é valido para qualquer tipo de objeto
            // var text = "Este texto é um teste";
            // Console.WriteLine(text.Equals("este texto é um teste"));
            // Console.WriteLine(text.StartsWith("Este texto é um teste"));
            // Console.WriteLine(text.StartsWith("este texto é um teste", StringComparison.OrdinalIgnoreCase));
            // -------------------------------------------------------------------------------------------------

            // ÍNDICES
            // var text = "Este texto é um teste";
            // Console.WriteLine(text.IndexOf("é"));
            // Console.WriteLine(text.LastIndexOf("s"));
            // -------------------------------------------------------------------------------------------------

            // MÉTODOS ADICIONAIS
            // var text = "Este texto é um teste";
            // Console.WriteLine(text.ToLower());
            // Console.WriteLine(text.ToUpper());
            // Console.WriteLine(text.Insert(5, "AQUI "));
            // Console.WriteLine(text.Remove(5, 6));
            // Console.WriteLine(text.Length);
            // -------------------------------------------------------------------------------------------------

            // MANIPULANDO STRINGS
            // var text = "Este texto é um teste";
            // Console.WriteLine(text.Replace("Este", "isto"));
            // Console.WriteLine(text.Replace("e", "X"));
            // var division = text.Split(" ");
            // Console.WriteLine(division[0]);
            // Console.WriteLine(division[1]);
            // Console.WriteLine(division[2]);
            // Console.WriteLine(division[3]);
            // Console.WriteLine(division[4]);

            // var result = text.Substring(5, 5);
            // var result = text.Substring(5, text.LastIndexOf("o"));
            // Console.WriteLine(result);

            // var text = "  Este texto é um teste  ";
            // Console.WriteLine(text);
            // Console.WriteLine(text.Trim());
            // -------------------------------------------------------------------------------------------------

            // STRINGBUILDER
            var text = new StringBuilder();
            text.Append("Este texto é um teste\n");
            text.Append("Este texto é um teste\n");
            text.Append("Este texto é um teste\n");
            text.Append("Este texto é um teste\n");

            text.ToString();
            Console.WriteLine(text);

            // -------------------------------------------------------------------------------------------------
        }
    }
}