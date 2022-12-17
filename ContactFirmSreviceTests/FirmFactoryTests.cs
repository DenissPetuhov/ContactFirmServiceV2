using ContactFirmService.BLL;
using Xunit;

namespace ContactFirmSreviceTests
{
   
    public class FirmFactoryTests
    {
        [Fact]
        public void FirmFactorySigltonSeting()
        {
            // Arrange
            FirmFactory firmFactory = FirmFactory.GetInstance();
            FirmFactory firmFactory1 = FirmFactory.GetInstance();
            // Act
            bool result = false;
            if (firmFactory1 == firmFactory)
                 result = true;
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void FirmFactoryCreateFirmSetigs()
        {
            // Arrange
            string SetName = "NameFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create(SetName);
            // Act
            string result = firm.Name;
            // Assert
            Assert.Equal(SetName, result);
        }
       
    }
}