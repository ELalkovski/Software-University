namespace P01_HospitalDatabase 
{
    using P01_HospitalDatabase.Data;
    using P01_HospitalDatabase.Initializer;

    public class StartUp
    {
        public static void Main()
        {
            DatabaseInitializer.ResetDatabase();

            using (HospitalContext db = new HospitalContext())
            {
                
            }
        }
    }
}
