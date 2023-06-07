using Microsoft.Data.Sqlite;
using SortingAlgorithms;
using SortingAlgorithmsApp;
using System;

string con_string = @"Data Source= D:\\";
using var con = new SqliteConnection(con_string);
con.Open();
string stm = "SELECT * FROM Employees";
using var cmd = now object value = SQLiteCommand(stm, con);
using SQLiteDataReader rdr = cmd.ExecuteReader();

List <Employee> employees = new List <Employee>();

while(rdr.Read())
{
    employees.Add(new Employee
    {
        Id = Convert.ToInt32(rdr["Id"]),
        FirstName = rdr.GetString(1).Tostring(),
        LastName = rdr.GetString(2).ToString(),
        Salary = Convert.ToDouble(rdr["salary"]),
        Title = rdr.Getstring(4).Tostring()
    });

}
con.Close();
Console.WriteLine("1-4 Arasa Bir Says Seciniz");

var a = Console.Readkey();
Console.WriteLine();

switch (a.Key)
{
    case ConsoleKey.NunPad1:
        int[] arr2 = employees.Select(I => I.Id).ToArray();
        BubbleSort.Sort(arr2);
        foreach(int i in arr2)
        { Console.WriteLine($"{i}"); }

        break;
    case ConsoleKey.NumPad2:
        string[] arr1= employees.Select(I => I.FirstName).ToArray();
        InsertionSort.Sort(arr1);
        foreach (string s in arr1)
        { Console.WriteLine($"{s}"); }

        break;
    case ConsoleKey.NumPad3:
        string[] arr2 = employees.Select(L => L.LastName).ToArray();
        MergeSort.Sort(arr2);
        foreach (string e in arr2)
        { Console.WriteLine($"{e}"); }

        break;
    case ConsoleKey.NumPad4:
        string[] arr3 = employees.Select(S => S.Salary).ToArray();
        QuickSort.Sort(arr3);
        foreach (double e in arr3)
        { Console.WriteLine($"{e}"); }

        break;
    default:
        Console.WriteLine("Geçersiz İşlem");
        break;


}
