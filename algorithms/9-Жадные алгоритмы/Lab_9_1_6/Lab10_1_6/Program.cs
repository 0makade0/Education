var allTime=0;
var count = 0;

Console.WriteLine("Вв-те количество минут в рабочем дне [1;1000]");
var workDayTime = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Вв-те количество пар обуви [1;500]");
var countShoe = Convert.ToInt16(Console.ReadLine());

int[] repairShoeTime=new int[countShoe];
for (var i = 0; i < countShoe; i++)
{
    Console.WriteLine($"Вв-те время для починки {i+1} ботинка");
    repairShoeTime[i] = Convert.ToInt16(Console.ReadLine());
}

Array.Sort(repairShoeTime);

for (int i = 0;  i< repairShoeTime.Length; i++)
{
    if (allTime+repairShoeTime[i]<workDayTime && i<workDayTime)
    {
        allTime += repairShoeTime[i];
        count++;
        continue;
    }
    break;
}

Console.WriteLine(count);