using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager;
using ItemView.ItemController;

namespace ItemManager.Tests
{
    class ItemView
    {
        static void Main(string[] args)
        {
            Console.writeline("What would you like to do? Create, List All, Find By Id, Edit, or Remove.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "create" || answer == "list" || answer == "find" || answer == "edit" || answer == "remove")
            {
                if (answer == "create")
                {
                    ItemView.ItemController.CreateItem createItem = new ItemView.ItemController.CreateItem();
                }
                else if (answer == "list")
                {
                    ListItems listItems = new ListItems();   
                }
                else if (answer == "find")
                {
                    FindItem;
                }
                else if (answer == "edit")
                {
                    EditItem;
                }
                else
                {
                    RemoveItem;
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid choice");
            }
        }
    }
}
        }
    }
}
//GetMenuChoice(): int
//GetNewItemInfo(): Item
//DisplayItem(Item item) : void
//EditItemInfo(Item item) : Item
//SearchItem(): int
//ConfirmRemoveItem(Item): Boolean