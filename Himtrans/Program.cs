using Aramis.Platform;
using Aramis.DatabaseConnector;
using System;

namespace Aramis
    {
    static class Program
        {
        [System.STAThread]
        static void Main(string[] args)
            {
            SystemAramis.SystemStart(args, typeof(Aramis.GreenHouse.MainForm));
            }
        }
    }