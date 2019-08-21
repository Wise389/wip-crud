using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager.Controllers;

namespace ItemManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemController NewController = new ItemController();
            NewController.Run();
        }
    }
}
