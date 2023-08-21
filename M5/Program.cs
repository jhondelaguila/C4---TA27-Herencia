using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Manager man = new Manager("Jhon",4000);
        }
        catch(SueldoIncorrecto E)
        {
            Console.WriteLine(E.Message);
        }
    }
}