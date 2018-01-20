namespace _01._BillsPaymentSystem.App
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data;
    using P01_BillsPaymentSystem.Data.Models;
    using _01._BillsPaymentSystem.App.UI;

    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();
            engine.Run();
            engine.PayBills(2, 20.00m);

            using (var db = new BillsPaymentSystemContext())
            {
                // UNCOMMENT THE LINES BELOW TO CREATE THE DATABASE AND SEED SOME EXAMPLE DATA IN IT    

                //var initializer = new DatabaseInitializer();
                //initializer.ResetDatabase(db);
            }
        }
    }
}
