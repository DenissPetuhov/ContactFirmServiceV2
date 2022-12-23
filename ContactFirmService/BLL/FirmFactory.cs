using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFirmService.BLL
{
    public class FirmFactory
    {
        private static FirmFactory? Instance;
        protected FirmFactory()
        {

        }
        public static FirmFactory GetInstance()
        {
            if (Instance == null)
                Instance = new FirmFactory();
            return Instance;

        }
        private const int fldscount = 5;
        public string[] nameMain = new string[fldscount]
        {"Имя","Фамилия","Отчество","Возраст","Телефон"};
       
        public Firm Create(string nameFirm)
        {

            Firm firm = new Firm(nameFirm, nameMain);

            return firm;

        }

    }
}
