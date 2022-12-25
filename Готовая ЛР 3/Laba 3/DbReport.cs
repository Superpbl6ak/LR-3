using Laba3_wpf;
using Laba3;

namespace Laba3;


public class DbReport
{
    public ApplicationContext DateBase { get; set; }

    public void WriteAllReport()
    {
        string path =
            $"Report/{DateTime.Now.Day:00}.{DateTime.Now.Month:00}.{DateTime.Now.Year} {DateTime.Now.Hour:00}-{DateTime.Now.Minute:00}-{DateTime.Now.Second:00} AllCars.txt";
        Directory.CreateDirectory("Report");
        File.Create(path).Close();
        
        var Report = DateBase.Cars.Include(p => p.Stock).ToList();
        foreach (var z in Report)
        {
            File.AppendAllText(path,
                $"{z.Id} {z.Name}. Цена: {z.Cost}$. Год выпуска: {z.DataRelease} {z.Remark}. В наличии: {z.IsStock} на складе {z.Stock.Town}\n");
        }

        WriteLine("Отчёт создан");
    }
}