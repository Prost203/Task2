namespace Task3
{
    class ListNode
    {
        public int Key { get; set; }
        public ListNode? Next { get; set; }
        public ListNode? Prev { get; set; }
    }

    class LinkedList
    {
        public ListNode? Head { get; set; }
    }

    class Program
    {
        static void ListInsert(LinkedList list, ListNode newNode)
        {
            if (newNode == null)
            {
                Console.WriteLine("пустой элемент");
                return;
            }

            newNode.Next = list.Head;
            newNode.Prev = null;

            if (list.Head != null)
            {
                list.Head.Prev = newNode;
            }

            list.Head = newNode;
        }
        static void PrintList(LinkedList list)
        {
            ListNode current = list.Head;
            while (current != null)
            {
                Console.Write(current.Key + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            //linkedlist = l , newNode = x указатель на элемент списка
            LinkedList linkedList = new LinkedList();
            ListNode newNode1 = null;
            ListNode newNode2 = new ListNode() { Key = 73 };

            ListInsert(linkedList, newNode1); // Проверка вставки пустого элемента
            PrintList(linkedList);
            ListInsert(linkedList, newNode2);
            PrintList(linkedList);
        }
    }
}