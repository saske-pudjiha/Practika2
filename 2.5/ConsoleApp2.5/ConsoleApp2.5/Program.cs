using System;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main()
    {
        Console.WriteLine("1 - Получение данных о водителях. ");
        Console.WriteLine("2 - Добавить новый тип автомобиля. ");
        Console.WriteLine("3 - Получение данные о типах автомобилей. ");
        Console.WriteLine("4 - Добавить нового водителя. ");
        Console.WriteLine("5 - Получение данных о категории прав водителей. ");
        Console.WriteLine("6 - Добавление новой категории прав. ");
        Console.WriteLine("7 - Добавление категории прав для водителя. ");
        Console.WriteLine("8 - Получение данных о автомобилях. ");
        Console.WriteLine("9 - Добавление нового категории прав для водителя.");
        Console.WriteLine("10 - Получение данных о маршрутах. ");
        Console.WriteLine("11 - Добавление нового маршрута. ");
        Console.WriteLine("12 - Получение данных о рейсах.  ");
        Console.WriteLine("13 - Добавление нового рейса. ");
        Console.WriteLine("0 - Завершение. ");
        
        int choose = int.Parse(Console.ReadLine());
        while (choose != 0)
        {
            Console.Write("Введите номер операции которую хотите выполнить: ");
            
            switch (choose)
            {
                case (1):
                {
                    DatabaseRequests.GetDriverQuery();
                    break;
                }
                
                case (2):
                {
                    Console.Write("Введите новый тип машин: ");
                    DatabaseRequests.AddTypeCar(Console.ReadLine());
                    break;
                }
                
                case (3):
                {
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                }
                
                case (4):
                {
                    Console.Write("Введите имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введите фамилию: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Введите дату рождения: ");
                    DatabaseRequests.AddDriver(firstName,lastName, DateTime.Parse(Console.ReadLine()));
                    break;
                }
                case (5):
                {
                    DatabaseRequests.GetDriverRightsCategory();
                    break;
                }
                case (6):
                {
                    Console.WriteLine("Категории прав:");
                    DatabaseRequests.GetRightsCategory();
                    Console.Write("Введите новую категорию прав: ");
                    DatabaseRequests.AddRightsCategory(Console.ReadLine());
                    break;
                }
                case (7):
                {
                    Console.WriteLine("Водители:");
                    DatabaseRequests.GetDriverQuery();
                    Console.WriteLine("Категории прав:");
                    DatabaseRequests.GetRightsCategory();
                    Console.Write("Введите ID водителя: ");
                    int driver = int.Parse(Console.ReadLine());
                    Console.Write("Введите ID категории прав: ");
                    int category = int.Parse(Console.ReadLine());
                    
                    DatabaseRequests.AddDriverRightsCategory(driver, category);
                    break;
                }
                case (8):
                {
                    DatabaseRequests.GetCars();
                    break;
                }
                case (9):
                {
                    Console.Write("Введите ID типа машины: ");
                    int typeCar = int.Parse(Console.ReadLine());
                    Console.Write("Введите модель машины: ");
                    string nameCar = Console.ReadLine();
                    Console.Write("Введите Гос.номер: ");
                    string stateNum = Console.ReadLine();
                    Console.Write("Введите количество пассажиров: ");
                    DatabaseRequests.AddCar(typeCar,nameCar,stateNum,int.Parse(Console.ReadLine()));
                    break;
                }
                case (10):
                {
                    DatabaseRequests.Getitinerary();
                    break;
                }
                
                case (11):
                {
                    Console.Write("ведите новый маршрут: ");
                    DatabaseRequests.AddItinerary(Console.ReadLine());
                    break;
                }
                
                case (12):
                {
                    DatabaseRequests.GetRoute();
                    break;
                }
                
                case (13):
                {
                    Console.Write("Введите Id Водителя: ");
                    int driver = int.Parse(Console.ReadLine());
                    Console.Write("Введите Id машины: ");
                    int car = int.Parse(Console.ReadLine());
                    Console.Write("Введите Id Маршрута: ");
                    int itinerary = int.Parse(Console.ReadLine());
                    Console.Write("Введите количество пассажиров: ");
                    DatabaseRequests.AddRoute(driver, car, itinerary, int.Parse(Console.ReadLine()));
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}