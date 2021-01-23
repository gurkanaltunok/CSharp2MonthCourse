
using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            BasvuruManager basvuruManager = new BasvuruManager();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { smsLoggerService, databaseLoggerService, fileLoggerService };
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, esnafKrediManager, konutKrediManager };

            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);



            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
