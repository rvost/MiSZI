using System;

namespace Lab01.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время горения ЗЕЛЕНОГО:");
            var kg = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите время горения ЖЕЛТОГО:");
            var ky = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите время горения КРАСНОГО:");
            var kr = int.Parse(Console.ReadLine());

            var pg = ((double)kg) / (kg + ky + kr);
            var py = ((double)ky) / (kg + ky + kr);
            var pr = ((double)kr) / (kg + ky + kr);

            var ig = Math.Ceiling(Math.Log2(1 / pg));
            var iy = Math.Ceiling(Math.Log2(1 / py));
            var ir = Math.Ceiling(Math.Log2(1 / pr));

            Console.WriteLine($"Количество информации, которое несет зеленый: {ig}");
            Console.WriteLine($"Количество информации, которое несет желтый: {iy}");
            Console.WriteLine($"Количество информации, которое несет крастный: {ir}");

            var aver = Math.Ceiling(pg * ig + py * iy + pr * ir);

            Console.WriteLine($"Среднее количество информации: {aver}");
        }
    }
}
