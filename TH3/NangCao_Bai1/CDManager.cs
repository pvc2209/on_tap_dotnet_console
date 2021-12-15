using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class CDManager
    {
        private CD[] cds;
        private int n;

        public CDManager()
        {
            cds = new CD[1000];
            n = 0;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("-----------------");
            Console.WriteLine("  1. Add CD");
            Console.WriteLine("  2. Search CD");
            Console.WriteLine("  3. Dislay catalog");
            Console.WriteLine("  4. Exit");
            Console.Write("  Your choice: ");
        }

        public void GetChoice()
        {
            int choice = 0;
            do
            {
                DisplayMenu();

                choice = Helper.ReadInt();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        AddCD();
                        break;
                    case 2:
                        Console.Clear();
                        SearchCD();
                        break;
                    case 3:
                        Console.Clear();
                        DisplayCatalog();
                        break;
                    case 4:
                        Console.WriteLine("Good bye...");
                        break;
                    default:
                        choice = -1;
                        Console.WriteLine("Invalid Option...");
                        break;
                }
            } while (choice != 4);
        }

        private void AddCD()
        {
            if (n == 1000)
            {
                Console.WriteLine("Can't hanlde more than 1000 CDs.");
                return;
            }

            CD cd = new CD();
            cd.Input();

            cds[n] = cd;
            ++n;
            Console.WriteLine();
        }

        private void SearchCD()
        {
            Console.Write("Enter CD Name: ");
            string cdName = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (cds[i].Name == cdName)
                {
                    cds[i].Display();
                    Console.WriteLine();
                }
            }
        }

        private void DisplayCatalog()
        {
            // Tham số đầu tăng dần từ 0, 1, 2, 3
            // Tham số sau nếu dương thì là cách bên tay trái
            // còn âm thì là cách bên tay phải
            string format = "| {0,-10} | {1, -20} | {2, -20} | {3, 15} |";

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(String.Format(format, "CD No.", "CD Name", "CD Type", "CD Price"));
            Console.WriteLine("------------------------------------------------------------------------------");

            for (var i = 0; i < n; ++i)
            {
                Console.WriteLine(String.Format(format, i + 1, cds[i].Name, cds[i].Type, cds[i].Price.ToString() + "K(VND)"));
            }
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
    }
}
