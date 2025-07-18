
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // EXCEPTIONS
            // var array = new int[3];

            // Retorna um erro
            // for (int i = 0; i <= array.Length; i++)
            // {
            //     Console.WriteLine(array[i]);
            // }
            // -------------------------------------------------------------------------------------------------

            // TRY/CATCH
            // var array = new int[3];

            // try
            // {
            //     for (int i = 0; i <= array.Length; i++)
            //     {
            //         Console.WriteLine(array[i]);
            //     }
            // }
            // catch (Exception exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Ops, Algo deu errado! :/");
            // }
            // -------------------------------------------------------------------------------------------------


            // TRATANDO ERROS
            // var array = new int[3];

            // try
            // {
            //     for (int i = 0; i <= array.Length; i++)
            //     {
            //         Console.WriteLine(array[i]);
            //     }
            // }
            // catch (IndexOutOfRangeException)
            // {
            // Console.WriteLine(exception.InnerException);
            // Console.WriteLine(exception.Message);
            //     Console.WriteLine("Não encontrei o índice na lista.");
            // }
            // catch (Exception)
            // {
            //     // Console.WriteLine(exception.InnerException);
            //     // Console.WriteLine(exception.Message);
            //     Console.WriteLine("Ops, Algo deu errado! :/");
            // }
            // -------------------------------------------------------------------------------------------------


            // DISPARANDO EXCEÇÕES
            // var array = new int[3];

            // try
            // {
            // for (int i = 0; i <= array.Length; i++)
            // {
            //     Console.WriteLine(array[i]);
            // }

            //     Save("");
            // }
            // catch (IndexOutOfRangeException exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Não encontrei o índice na lista.");
            // }
            // catch (ArgumentNullException exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Erro ao cadastrar o texto.");
            // }
            // catch (Exception exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Ops, Algo deu errado! :/");
            // }
            // -------------------------------------------------------------------------------------------------

            // CUSTOM EXCEPTIONS
            // try
            // {
            //     Save("");
            // }
            // catch (MyException exception)
            // {
            //     Console.WriteLine(exception.Text);
            //     Console.WriteLine(exception.WhenDidItHappen);
            // }
            // catch (IndexOutOfRangeException exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Não encontrei o índice na lista.");
            // }
            // catch (ArgumentNullException exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Erro ao cadastrar o texto.");
            // }
            // catch (Exception exception)
            // {
            //     Console.WriteLine(exception.InnerException);
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine("Ops, Algo deu errado! :/");
            // }
            // -------------------------------------------------------------------------------------------------

            // CUSTOM FINALLY
            try
            {
                Save("");
            }
            catch (MyException exception)
            {
                Console.WriteLine(exception.Text);
                Console.WriteLine(exception.WhenDidItHappen);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.InnerException);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.InnerException);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Erro ao cadastrar o texto.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.InnerException);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Ops, Algo deu errado! :/");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!!!");
            }
            // -------------------------------------------------------------------------------------------------
        }

        private static void Save(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                // throw new Exception("O texto não pode ser nulo ou vazio.");
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
                throw new MyException(DateTime.Now, "O texto não pode ser nulo ou vazio.");
            }
        }

        public class MyException : Exception
        {
            public MyException(DateTime date, string text)
            {
                WhenDidItHappen = date;
                Text = text;
            }

            public DateTime WhenDidItHappen { get; set; }
            public string Text { get; set; }
        }
    }
}