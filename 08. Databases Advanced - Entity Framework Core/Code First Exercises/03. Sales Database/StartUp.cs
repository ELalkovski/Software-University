namespace _03._Sales_Database
{
    using P03_SalesDatabase.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new SalesContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
