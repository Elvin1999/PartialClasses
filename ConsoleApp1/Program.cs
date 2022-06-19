using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public class Worker
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    static Worker()
    //    {
    //        Console.WriteLine("Static Constructor");
    //        throw new Exception("Some error occurred");
    //    }
    //    public Worker()
    //    {
    //        Console.WriteLine("Default constructor");
    //    }

    //    public Worker(int id, string name)
    //    {
    //        Id = id;
    //        Name = name;
    //        Console.WriteLine("Parametric constructor");
    //    }
    //}
    //public class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        Worker[] workers = new Worker[3];
    //        for (int i = 0; i < workers.Length; i++)
    //        {
    //            workers[i] = new Worker();
    //        }

    //        //int[] arr = {1,2, 3};
    //        //foreach (var item in arr)
    //        //{
    //        //    Console.Write($"{item}  ");
    //        //}
    //        //Console.WriteLine();

    //    }
    //}


    class Car
    {

        public static DateTime GlobalStartTime;
        static Car()
        {
            GlobalStartTime = DateTime.Now;
            Console.WriteLine($@"Static constructor called
            Global Start Time : {GlobalStartTime.ToLongTimeString()}");
        }

        public Car(int id)
        {
            Thread.Sleep(1000);
            Id = id;
        }

        public int Id { get; set; }

        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - GlobalStartTime;

            Console.WriteLine($@"
            Car ID : {Id} is starting its works 
            {elapsedTime.Seconds} seconds
            after global start time
            {GlobalStartTime.ToLongTimeString()}");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Car car = null;
            //for (int i = 0; i < 10; i++)
            //{
            //    car = new Car(1);
            //    Thread.Sleep(350);

            //}
            //car.Drive();


            //Partial 


            //BankAccount bankAccount = new BankAccount()
            //{
            //    Id = 1,
            //    Name = "John"
            //};
            //BankAccount bankAccount=new BankAccount("Mike");
            //bankAccount.Start();

            //Console.WriteLine(NetworkConstants.TempFolderPath);

            //

        }
    }
}
