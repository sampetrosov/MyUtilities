﻿// Copyright (c) 2017 Samvel Petrosov
// Created at 8/8/2017 10:08 AM
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace MyUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.LiterateConsole()
                .CreateLogger();
            string a = "One Two Bla blabla b2la";
            Console.WriteLine(a.SplitAndSort());
        }
    }
}
