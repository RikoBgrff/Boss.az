﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boss.az
{
    class Program
    {

        static void Main(string[] args)
        {
            SystemManagement manager = new SystemManagement();

            manager.Start();
        }
    }
}
