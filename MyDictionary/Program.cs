namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> dictionarys =new MyDictionary<string>();
            dictionarys.Add("Elif");
            dictionarys.Add("Ayşe");
            dictionarys.Add("Emir");
            Console.WriteLine(dictionarys.Length);
            foreach (var item in dictionarys.Items)
            {
                Console.WriteLine(item);
            }   
        }
    }
}