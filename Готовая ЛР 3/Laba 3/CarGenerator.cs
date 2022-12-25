namespace Laba3;

public static class CarGenerator
{
    public static List<Car> GetCars(List<Stock> stockList)
    {
        var rand = new Random();

        var maxCarsCount = rand.Next(30, 100);

        var cars = new List<Car>();

        for (var i = 0; i < maxCarsCount; i++)
        {
            var car = GenerateCar(stockList[rand.Next(0, stockList.Count)]);
            cars.Add(car);
        }

        return cars;
    }

    private static Car GenerateCar(Stock stock)
    {
        var rand = new Random();

        var cost = 0;
        var remark = "";
        var dateRelease = rand.Next(1988, 2022);
        var currentStock = stock;

        switch (dateRelease)
        {
            case <= 2000:
                cost = rand.Next(1000, 10000);
                break;
            case > 2000 and <= 2010:
                cost = rand.Next(10000, 100000);
                break;
            case > 2010 and <= 2015:
                cost = rand.Next(100000, 300000);
                break;
            case > 2015 and <= 2020:
                cost = rand.Next(300000, 500000);
                break;
            default:
                remark = "all inclusive";
                cost = rand.Next(500000, 1500000);
                break;
        }

        return new Car()
        {
            Id = Guid.NewGuid(),
            Name = Constants.CarNames[rand.Next(0, Constants.CarNames.Count)],
            DataRelease = dateRelease,
            Cost = cost,
            Remark = remark,
            IsStock = true,
            Stock = currentStock
        };
    }
}