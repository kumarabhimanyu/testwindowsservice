using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace testwindowsservice
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        public static int DivideNumbers(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Division by Zero");
            }
            else
            {
                return a / b;
            }
        }
    }
}