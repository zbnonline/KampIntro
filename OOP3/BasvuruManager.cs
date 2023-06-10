﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BavuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();

            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
