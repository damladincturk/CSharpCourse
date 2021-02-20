using System;

namespace VirtualMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            Mysql mysql = new Mysql();

            sqlServer.Add();
            mysql.Add();
        }
    }

    class Database{

        public virtual void Add() {

            Console.WriteLine("Added by defaualt");
        }
        public void Delete() {

             Console.WriteLine("Deleted by default");
        }

    }

    class SqlServer : Database {

        public override void Add()
        {
            Console.WriteLine("Added by Sql");
            base.Add();
        }

    }

    class Mysql :  Database
    {


    }

}
