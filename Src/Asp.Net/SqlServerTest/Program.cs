﻿using OrmTest.PerformanceTesting;
using OrmTest.UnitTest;
using System;

namespace OrmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OldTestMain.Init();

            Demo1_SqlSugarClient.Init();

            Console.WriteLine("all successfully.");
            Console.ReadKey();
        }

 
    }
}
