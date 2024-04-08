namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        // Вызовем метод для получения данных о водителях
        DatabaseRequests.GetDriverQuery();
        Console.WriteLine();
        // Добавим нового водителя в БД
        DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
        // Вызовем метод для получения данных о водителях
        DatabaseRequests.GetDriverQuery();
        
        
        // Вызовем метод для получения данных о типах автомобилей
        DatabaseRequests.GetTypeCarQuery();
        Console.WriteLine();
        // Добавим новый тип автомобиля в БД
        DatabaseRequests.AddTypeCarQuery("Воздушный");
        // Вызовем метод для получения данных о типах автомобилей
        DatabaseRequests.GetTypeCarQuery();
        
        
        // Вызовем метод для получения данных о машинах 
        DatabaseRequests.GetCarQuery();
        Console.WriteLine();
        // Добавим новую машину
        DatabaseRequests.AddCarQuery(2, "Mazda", "В423КЕ70", 4);
        DatabaseRequests.GetCarQuery();
        
        
        // Вызовем метод для получения данных о маршрутах
        DatabaseRequests.GetItineraryQuery();
        Console.WriteLine();
        // Добавим новый маршрут
        DatabaseRequests.AddItineraryQuery("Томск-Москва");
        DatabaseRequests.GetItineraryQuery();
        
        
        // Вызовем метод для получения данных о рейсах
        DatabaseRequests.GetRouteQuery();
        Console.WriteLine();
        // Добавим новый рейс
        DatabaseRequests.AddRouteQuery(1, 4, 3, 6);
        DatabaseRequests.GetRouteQuery();
    }
}