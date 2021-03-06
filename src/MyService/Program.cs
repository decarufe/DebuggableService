﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using ServiceDebuggerHelper;

namespace MyService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(params string[] args)
        {
            if (args.Length > 0 && args[0].ToLower().Equals("/debug"))
            {
                Application.Run(new ServiceRunner(new Service1()));
            }
            else
            {
                var ServicesToRun = new ServiceBase[] { new Service1() };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
