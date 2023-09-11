using System;
using System.Diagnostics;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bstSize = 100;

            TestBinaryTree(bstSize);
            TestRandomBinaryTree(bstSize);

            Console.Read();
        }

        private static void TestRandomBinaryTree(int bstSize)
        {
            var random = new Random(1234);

            var watch = new Stopwatch();

            watch.Start();
            IBinarySearchTree bst = new BinarySearchTree(random.Next(1,bstSize));

            for (int i = 0; i < bstSize; i++)
            {
                bst.Insert(random.Next(1,bstSize));
            }
            watch.Stop();
            Console.WriteLine($"Добавление random в дерево - {watch.ElapsedMilliseconds}");

            watch.Restart();
            for (int i = 0; i < bstSize/10; i++)
            {
                bst.Search(random.Next(1, bstSize));
            }
            watch.Stop();
            Console.WriteLine($"Поиск в random дереве - {watch.ElapsedMilliseconds}");

            watch.Restart();
            for (int i = 0; i < bstSize/10; i++)
            {
                bst.Remove(random.Next(1, bstSize));
            }
            watch.Stop();
            Console.WriteLine($"Удаление в random дереве - {watch.ElapsedMilliseconds}");
            Console.WriteLine("=============================");
        }

        private static void TestBinaryTree(int bstSize)
        {
            var watch = new Stopwatch();

            watch.Start();
            IBinarySearchTree bst = new BinarySearchTree(1);

            for (int i = 2; i < bstSize; i++)
            {
                bst.Insert(i);
            }
            watch.Stop();
            Console.WriteLine($"Добавление в дерево - {watch.ElapsedMilliseconds}");

            watch.Restart();
            for (int i = 1; i < bstSize / 10; i++)
            {
                bst.Search(i);
            }
            watch.Stop();
            Console.WriteLine($"Поиск в дереве - {watch.ElapsedMilliseconds}");

            watch.Restart();
            for (int i = bstSize/10; i >=1 ; i--)
            {
                bst.Remove(i);
            }
            watch.Stop();
            Console.WriteLine($"Удаление в дереве - {watch.ElapsedMilliseconds}");
            Console.WriteLine("=============================");
        }
    }
}
