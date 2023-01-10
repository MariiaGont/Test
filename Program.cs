internal class Program
{
    private static void Main(string[] args)
    {
        // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
        void Task()
        {
            Console.WriteLine("Программа принимает на вход строки и выдаёт те из них, длина которых меньше или равна 3 символам.");
            Console.Write("Введите строки через пробел: ");
            string lines = Console.ReadLine();
            string[] input = lines.Split();
            int inputLength = input.Length;
            string[] output = new string[inputLength];
            int stringLength = 3;
            Console.WriteLine();

            for (int i = 0; i < inputLength; i++)
            {
                int j = 0;
                if (input[i].Length <= stringLength)
                {
                    output[j] = input[i];
                    Console.Write(output[j] + " ");
                    j++;
                }
            }
            Console.WriteLine(" ");
        }
        Task();
    }
}