using Task;

Console.OutputEncoding = System.Text.Encoding.UTF8;


Airplane рейс1 = new Airplane("Місто1", "Місто2", new MyDate(2023, 12, 28, 12, 0), new MyDate(2023, 12, 29, 12, 30));
Airplane рейс2 = new Airplane("Місто3", "Місто4", new MyDate(2023, 12, 29, 3, 0), new MyDate(2023, 12, 29, 12, 30));

Console.WriteLine($"Рейс 1 Загальний час: {рейс1.GetTotalTime()} хвилин");
Console.WriteLine($"Чи прибуде рейс 1 сьогодні? {рейс1.IsArrivingToday()}\n");

Console.WriteLine($"Рейс 2 Загальний час: {рейс2.GetTotalTime()} хвилин");
Console.WriteLine($"Чи прибуде рейс 2 сьогодні? {рейс2.IsArrivingToday()}\n");


Currency usd = new Currency("USD", 37.5);
Product товар1 = new Product("Товар1", 10.5, usd, 20, "Виробник1", 0.5);
Product товар2 = new Product(товар1); 

Console.WriteLine($"Товар 1 Ціна в UAH: {товар1.GetPriceInUAH()} UAH");
Console.WriteLine($"Товар 1 Загальна ціна в UAH: {товар1.GetTotalPriceInUAH()} UAH");
Console.WriteLine($"Товар 1 Загальна вага: {товар1.GetTotalWeight()} кг\n");

Console.WriteLine($"Товар 2 Ціна в UAH: {товар2.GetPriceInUAH()} UAH");
Console.WriteLine($"Товар 2 Загальна ціна в UAH: {товар2.GetTotalPriceInUAH()} UAH");
Console.WriteLine($"Товар 2 Загальна вага: {товар2.GetTotalWeight()} кг");