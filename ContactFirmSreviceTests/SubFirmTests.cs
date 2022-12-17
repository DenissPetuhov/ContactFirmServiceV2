using ContactFirmService.BLL;
using Xunit;

namespace ContactFirmSreviceTests
{
    public class SubFirmTests
    {
        [Fact]
        public void SubFirmIsMain()
        {
            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create("new Firm");
            // Act
            SubFirm result = firm.subFirms.Find(x=>x.Name== mainSubFirmName);
            // Assert
            Assert.True(result.IsMain);
        }
        [Fact]
        public void SubFirmisMainType()
        {
            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            Firm firm = firmFactory.Create("new Firm");
            // Act
            bool result = firm.subFirms.Find(x => x.Name == mainSubFirmName).SbFirmTpy.IsMain;
            // Assert
            Assert.True(result);

        }
    }
}
