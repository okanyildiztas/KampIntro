namespace OOP3
{
     class Program
     {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager  = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}