using System;
using System.Data.SqlClient;


namespace ConsoleUIDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.ConnectToDatabase();
        }
    }
}
