using ContactFirmService.BLL;
using System;
using Xunit;

namespace ContactFirmSreviceTests
{
    public class ContactTests
    {

        [Fact]
        public void ContactType()
        {
            // Arrange
            ContType contType = new ContType();
            Contact contact = new Contact(contType);

            // Act
            ContType result = contact.CntType;
            // Assert
            Assert.Equal(contType, result);
        }

        [Fact]
        public void ContactClone()
        {
            // Arrange
            ContType contType = new ContType();
            Contact contact = new Contact(contType);

            // Act
            DateTime result = contact.Clone().BeginDt;
            // Assert
            Assert.Equal(contact.BeginDt, result);
        }

    }
}
