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

            Console.Write("\nEnter the Position Which you want to Insert Value : ");
            int position = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter the value Which you want to Insert : ");
            int value = Convert.ToInt32(Console.ReadLine());   
            list.InsertAtParticularPosition(position, value);
            list.Display();

            list.Search(40);
            Console.Write("\nEnter the Position Which you want to Delete Value : ");
            int node = Convert.ToInt32(Console.ReadLine());  
            list.DeleteNodeAtPerticularPosition(node);
            list.Display();
        }
    }
}