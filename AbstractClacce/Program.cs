using System;

namespace AbstractClacce
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Database database = new SqlServer();
            Database database1 = new OracleServer();

            database.Add();
            database1.Add();

            database.Deleted();
            database1.Deleted();
        }
    }

    abstract class Database {

        public void Add() {

            Console.WriteLine("Added");

        }

        public abstract void Deleted();


    }

    class SqlServer : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class OracleServer : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
