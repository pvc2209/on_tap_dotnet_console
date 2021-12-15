using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    // Nguyên lý hoạt động của Stack là FILO
    // FIST IN LAST OUT
    internal class Stack
    {
        private int[] data;

        private int count;

        public Stack()
        {
            data = new int[20];
            count = 0;
        }

        public Stack(int n)
        {
            if (n <= 0)
            {
                throw new Exception("Số lượng phần tử không hợp lệ.");
            }

            data = new int[n];
            count = 0;
        }

        public int Count { get { return count; } }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == data.Length;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                throw new Exception("Stack dầy - Không thể Push");
            }

            data[count++] = value;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack rỗng - Không thể Pop");
            }

            int value = data[count - 1];
            --count;

            return value;
        }

        public void Display()
        {
            Console.Write("Đáy Stack -> ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{data[i]} ");
            }

            Console.Write("<- Đỉnh Stack");
            Console.WriteLine();
        }
    }
}
