using System.Data.Common;

namespace ArraysGuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // ARRAYS
            // int[] myArray = new int[5];
            // var myArray = new int[5] { 1, 2, 3, 4, 5 };

            // Console.WriteLine(myArray[0]);
            // Console.WriteLine(myArray[1]);
            // Console.WriteLine(myArray[2]);
            // Console.WriteLine(myArray[3]);
            // Console.WriteLine(myArray[4]);

            // myArray[0] = 12;

            // Console.WriteLine("--------");
            // Console.WriteLine(myArray[0]);

            // var test = new Test[1] { new Test() };
            // var test = new Test[1];
            // test[0] = new Test();

            // Console.WriteLine(test[0].Id);
            // -------------------------------------------------------------------------------------------------

            // PERCORRENDO UM ARRAY
            // var myArray = new int[5] { 345, 12, 457, 989, 261 };
            // use o myArray.Clone para copiar um array
            // use o myArray.CopyTo para copiar um valor
            // Console.WriteLine($"Tamanho do array: {myArray.Length} itens");
            // Console.WriteLine("-------------------------");

            // for (var item = 0; item < myArray.Length; item++)
            // {
            //     Console.WriteLine(myArray[item]);
            // }
            // -------------------------------------------------------------------------------------------------

            // FOREACH
            // var myArray = new int[5] { 345, 12, 457, 989, 261 };
            // Console.WriteLine($"Tamanho do array: {myArray.Length} itens");
            // Console.WriteLine("-------------------------");

            // foreach (var item in myArray)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("-------------------------");

            // var employees = new Employee[5];
            // employees[0] = new Employee() { Id = 123, Name = "André" };

            // foreach (var employee in employees)
            // {
            //     Console.WriteLine(employee.Id);
            //     Console.WriteLine(employee.Name);
            // }
            // -------------------------------------------------------------------------------------------------

            // ALTERANDO OS VALORES
            // var myArray = new int[5];
            // var myArrayB = myArray;

            // myArray[0] = 234;
            // Console.WriteLine(myArrayB[0]);

            var myArray = new int[5];
            var myArrayB = new int[5];

            myArrayB[0] = myArray[0];

            myArray[0] = 234;
            Console.WriteLine(myArrayB[0]);
            // -------------------------------------------------------------------------------------------------
        }

        struct Test
        {
            public int Id { get; set; }
        }

        public struct Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}