using System;

namespace Lab01.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var control = '\0';
            do
            {
                try
                {
                    Console.WriteLine("C - закодировать сообщение;\n"+
                        "D - декодировать сообщение\n"+
                        "E - выйти.\n");
                    control = Console.ReadKey().KeyChar;
                    switch (control.ToString().ToUpper()[0])
                    {
                        case 'C':
                            Console.WriteLine("Введите сообщение:");
                            var message = Console.ReadLine().Trim();
                            var encoder = new Encoder<SimpleCodeTable>();
                            Console.WriteLine($"Закодированное сообщение: {encoder.Encode(message)}");
                            break;
                        case 'D':
                            Console.WriteLine("Введите код сообщения:");
                            var code = Console.ReadLine().Trim();
                            var decoder = new Decoder<SimpleCodeTable>();
                            Console.WriteLine($"Декодированное сообщение: {decoder.Decode(code)}");
                            break;
                        case 'E':
                            break;
                        default:
                            Console.WriteLine("Недопустимый управляющий символ");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            while (control != 'E');

        }
    }
}
