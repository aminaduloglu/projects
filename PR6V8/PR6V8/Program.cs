
using System;
using System.IO;
using System.Linq;

class Program
{
    //В исходном файле в каждой строке записаны код, название, количество, стоимость
    //товаров некоторой фирмы.Все они разделены между собой символом $. Создать три
    //файла, в каждый из который будут построчно записываться только наименования товаров,
    //только количественные значения товаров, только стоимостные показатели товаров.
    //Сортировка элементов в каждом файле – по возрастанию.
    static void Main()
    {
        string inputFile = "input.txt";
        string nameFile = "name.txt";
        string quantityFile = "quantity.txt";
        string costFile = "cost.txt";

        // Чтение данных из входного файла
        string[] lines = File.ReadAllLines(inputFile);

        // Разделение каждой строки на части и сохранение их в отдельные массивы
        string[] names = lines.Select(line => line.Split('$')[1]).ToArray();
        int[] quantities = lines.Select(line => int.Parse(line.Split('$')[2])).ToArray();
        double[] costs = lines.Select(line => double.Parse(line.Split('$')[3])).ToArray();

        // Сортировка массивов по возрастанию
        Array.Sort(names);
        Array.Sort(quantities);
        Array.Sort(costs);

        // Запись отсортированных данных в соответствующие файлы
        File.WriteAllLines(nameFile, names);
        File.WriteAllLines(quantityFile, quantities.Select(q => q.ToString()));
        File.WriteAllLines(costFile, costs.Select(c => c.ToString()));
    }
}
