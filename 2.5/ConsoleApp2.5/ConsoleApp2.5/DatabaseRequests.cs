using System;
using Npgsql;

/// <summary>
/// Класс DatabaseRequests
/// содержит методы для отправки запросов к БД
/// </summary>
public static class DatabaseRequests
{ 
    public static void GetDriverQuery()
    {
        var querySql = "SELECT * FROM driver";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
        }
    }
    public static void GetTypeCarQuery()
    {
        var querySql = "SELECT * FROM type_car";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader[0]} Название: {reader[1]}");
        }
    }
    
    public static void AddTypeCar(string name)
    {
        var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void AddDriver(string firstName, string lastName, DateTime birthdate)
    {
        string date = $"{birthdate.Year}-{birthdate.Month}-{birthdate.Day}";
        var querySql = $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{date}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    public static void AddRightsCategory(string name)
    {
        var querySql = $"INSERT INTO rights_category(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void AddDriverRightsCategory(int driver, int rightsCategory)
    {
        var querySql = $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ({driver}, {rightsCategory})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void GetDriverRightsCategory()
    {
        var querySql = "SELECT dr.first_name, dr.last_name, rc.name " +
                       "FROM driver_rights_category " +
                       "INNER JOIN driver dr on driver_rights_category.id_driver = dr.id " +
                       "INNER JOIN rights_category rc on rc.id = driver_rights_category.id_rights_category ";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Имя, Фамилия:  {reader[0]} {reader[1]}, Его категория прав: {reader[2]}");
        }
    }
    
    public static void GetRightsCategory()
    {
        var querySql = "SELECT * FROM rights_category";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID категории: {reader[0]} Категория: {reader[1]}");
        }
    }
    
    public static void GetCars()
    {
        var querySql = "SELECT * FROM car";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID Машины: {reader[0]} | ID типа машины: {reader[1]} | Модель: {reader[2]} | Гос.номер: {reader[3]} | Количество пассажиров: {reader[4]}");
        }
    }
    
    public static void AddCar(int typeCar, string NameCar, string StateNum, int numPassengers)
    {
        var querySql = $"INSERT INTO car(id_type_car, name, state_number, number_passengers) VALUES ('{typeCar}','{NameCar}', '{StateNum}', '{numPassengers}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void Getitinerary()
    {
        var querySql = "SELECT * FROM itinerary";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id маршрута: {reader[0]} | Маршрут: {reader[1]}");
        }
    }
    public static void AddItinerary(string name)
    {
        var querySql = $"INSERT INTO itinerary(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void GetRoute()
    {
        var querySql = "SELECT * FROM route";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID рейса: {reader[0]} | ID водителя: {reader[1]} | ID машины: {reader[2]} | ID маршрута: {reader[3]} | Количество пассажиров: {reader[4]}");
        }
    }
    public static void AddRoute(int driver, int car, int itinerary, int passengers)
    {
        var querySql = $"INSERT INTO route(id_driver, id_car, id_itinerary, number_passengers) " + 
                       $"VALUES ('{driver}', '{car}', '{itinerary}', '{passengers}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
}
