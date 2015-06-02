using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("lol1");
            q1.Enqueue("lol2");
            q1.Enqueue("lol3");
            string queueString = q1.Dequeue();
            Console.WriteLine(queueString);
            queueString = q1.Dequeue();
            Console.WriteLine(queueString);
            queueString = q1.Dequeue();
            Console.WriteLine(queueString + "\r\n");

            Stack<string> s1 = new Stack<string>();
            s1.Push("lol1");
            s1.Push("lol2");
            s1.Push("lol3");
            string stackString = s1.Pop();
            Console.WriteLine(stackString);
            stackString = s1.Pop();
            Console.WriteLine(stackString);
            stackString = s1.Pop();
            Console.WriteLine(stackString + "\r\n");

            LinkedList<string> llist1 = new LinkedList<string>();
            LinkedListNode<string> node1 = llist1.AddFirst("lol1");
            LinkedListNode<string> node2 = llist1.AddAfter(node1, "lol2");
            LinkedListNode<string> node3 = llist1.AddBefore(node1, "lol3");

            foreach (var value in llist1)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            LinkedListNode<string> node22 = node1.Next;
            LinkedListNode<string> node31 = node1.Previous;
            Console.WriteLine(node22.Value);
            Console.WriteLine(node31.Value);

            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            // KEY VALUE
            //Digest = anders
            //Cipher = qwelækqwlæasc98009+12i3+12983
            dic1.Add("LOL1KEY", "LOL1VALUE");
            dic1.Add("LOL2KEY", "LOL2VALUE");
            dic1.Add("LOL3KEY", "LOL3VALUE");

            string lol1String = String.Empty;
            dic1.TryGetValue("LOL1KEY", out lol1String);
            if(lol1String != String.Empty)
                Console.WriteLine(lol1String);


            List<string> list1 = new List<string>();
            ArrayList list2 = new ArrayList();
            list2.Add("LOL1");
            list2.Add("LOL2");
            Console.WriteLine(list2[1]);

            list1.Add("LOL1");
            list1.Add("LOL2");
            list1.Add("LOL3");

            Console.ReadKey();



        }
    }
}
