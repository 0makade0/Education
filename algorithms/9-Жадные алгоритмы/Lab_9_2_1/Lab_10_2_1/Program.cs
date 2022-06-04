Console.WriteLine("Вв-те количество сотрудников");
var countWorkers=Convert.ToInt16(Console.ReadLine());

int[] rangeWorkers = new int[countWorkers];
for (var i = 0; i < countWorkers; i++)
{
    Console.WriteLine($"Вв-те расстояние для {i+1} сотрудника");
    rangeWorkers[i] = Convert.ToInt16(Console.ReadLine());
}
Array.Sort(rangeWorkers);

int[] minimalCost = new int[countWorkers];
var taxiAndPrice = new Dictionary<int, int>();
for (var i = 0; i < countWorkers; i++)
{
    Console.WriteLine($"Вв-те цену для {i+1} такси");
    minimalCost[i] = Convert.ToInt16(Console.ReadLine());
    taxiAndPrice.Add(i,minimalCost[i]);
}

Array.Sort(minimalCost);
Array.Reverse(minimalCost);

for (var i = 0; i < countWorkers; i++)
{
    foreach (var x in taxiAndPrice)
    {
        if (minimalCost[i] == taxiAndPrice[x.Key])
        {
            Console.WriteLine(x.Key+1);
            taxiAndPrice.Remove(x.Key);
        }
    }
}

Console.ReadLine();