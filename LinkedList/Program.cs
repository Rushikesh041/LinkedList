namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.Search(30);
            list.InsertAtParticularPosition(3, 40);
            list.Display();
        }
    }
}