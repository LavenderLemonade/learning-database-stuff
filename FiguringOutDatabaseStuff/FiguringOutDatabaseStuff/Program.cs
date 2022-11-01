using FiguringOutDatabaseStuff.DAO;

namespace FiguringOutDatabaseStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //so, this is where we need to do the actual connecting to the database, and to do that we need the DAO and the DAO interface

            IShoeDao shoeDao = new ShoeSqlDao(@"Server=.\SQLEXPRESS;Database=ShoeStore;Trusted_Connection=True;");



        }
    }
}