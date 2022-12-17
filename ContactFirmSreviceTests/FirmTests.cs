using ContactFirmService.BLL;
using System.Collections.Generic;
using Xunit;

namespace ContactFirmSreviceTests
{
    public class FirmTests
    {
        [Fact]
        public void FirmCreateMainSubFirmDetectet()
        {

            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create("Новя фирма");
            // Act
            string result = firm.subFirms[0].Name;
            // Assert
            Assert.Equal(mainSubFirmName, result);
        }
        [Fact]
        public void FirmAddContactDetected()
        {
            // Arrange
            ContType contType = new ContType();
            Contact contact = new Contact(contType);
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create("Новя фирма");
            firm.AddCont(contact);
            // Act
            Contact result = firm.subFirms[0].ExistContact()[0];
            // Assert
            Assert.Equal(contact, result);
        }
        [Fact]
        public void FirmAddNewSubFirm()
        {
            // Arrange
            string subFirmName = "Second SubFirm";
            SbFirmType sbFirmType = new SbFirmType();
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create("Новя фирма");
            firm.AddSbFirm(subFirmName, sbFirmType);
            // Act
            SubFirm result = firm.subFirms.Find(x => x.Name == subFirmName);
            // Assert
            Assert.Equal(subFirmName, result.Name);
        }

        [Fact]
        public void Firmfild()
        {
            // Arrange
            string[] flds1 = new string[] { "Влад", "Совельев", "Евшеньевичь", "flds5", "flds6" };
            string[] flds2 = new string[] { "Денис", "Иванов", "Владимирович", "flds5", "flds6" };
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm1 = firmFactory.Create("Первая фирма");
            Firm firm2 = firmFactory.Create("вторая фирма");
            firm1.SetField(flds1);
            firm2.SetField(flds2);
            // Act
            Dictionary<string, string> result1 = firm1.GetField();
            Dictionary<string,string> result2 = firm2.GetField();
            // Assert
            Assert.NotEqual(result2, result1);
        }

    }
}
