namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

        
            //1.1
            int myNumber = 5;
            Console.WriteLine(myNumber.CheckIfHigher(6));

            //1.2
            string fullName = "harry potter";
            string email = fullName.CreateEmailAdress(1995, "gmail.com");
            Console.WriteLine(email);
            Console.ResetColor();

            //1.3

            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
            List<int> everySecondInt = ints.GetListEverySecondWord();

            foreach (int i in everySecondInt) 
            {
                Console.WriteLine(i);
            }
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.WriteLine("Pakeitimas");
            Console.WriteLine("EXT-3");
            Console.WriteLine("Pakeitimas more");

            Console.WriteLine("EXT-2");


            Console.WriteLine("URGENT-1");

            Console.WriteLine("Ext-4");

            Console.WriteLine("Protected By PULL REQUEST");


        }
}
