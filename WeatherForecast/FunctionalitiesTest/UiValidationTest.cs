using FluentAssertions;
using Functionalities.DomainLogic;
using NUnit.Framework;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class UiValidationTest
    {
        [Test]
        public void areUserSettingsValid_UsernameIsEmpty_ReturnFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.AreUserSettingsValid("", 55555, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_UsernameIsNull_ReturnFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.AreUserSettingsValid(null, 55555, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidZipcode_ReturnFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.AreUserSettingsValid("TestUser", -1, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidForecastType_ReturnFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.AreUserSettingsValid("TestUser", 55555, -1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidTempertureType_ReturnFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.AreUserSettingsValid("TestUser", 55555, 1, -1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void isZipcode_InvalidZipcode_returnsFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.IsZipcode(0);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void isStringADate_invalidString_returnsFalse()
        {
            //arr
            var sut = new UiValidation();

            //act
            var result = sut.IsStringADate("Test");

            //assert
            result.Should().Be(false);
        }
    }
}