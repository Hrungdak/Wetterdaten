using FluentAssertions;
using Functionalities;
using NUnit.Framework;
using System;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class ValidationTest
    {
        [Test]
        public void IsInteger_StringEmpty_ReturnsFalse()
        {
            var sut = new Validation();

            var result = sut.IsInteger(string.Empty);

            result.Should().Be(false);
        }

        [Test]
        public void IsInteger_StringIsValidInteger_ReturnsTrue()
        {
            var sut = new Validation();

            var result = sut.IsInteger("12345");

            result.Should().Be(true);
        }

        [Test]
        public void IsInteger_StringIsNotValidInteger_ReturnsFalse()
        {
            var sut = new Validation();

            var result = sut.IsInteger("ASD");

            result.Should().Be(false);
        }

        [Test]
        public void IsInteger_StringIsNull_ReturnsFalse()
        {
            var sut = new Validation();

            var result = sut.IsInteger(null);

            result.Should().Be(false);
        }

        [Test]
        public void ConvertStringToInt_StringEmpty_Throws()
        {
            var sut = new Validation();

            Action action = () => sut.ConvertStringToInt("");

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ConvertStringToInt_StringIsNull_Throws()
        {
            var sut = new Validation();

            Action action = () => sut.ConvertStringToInt("");

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ConvertStringToInt_StringIsNotValidInteger_Throws()
        {
            var sut = new Validation();

            Action action = () => sut.ConvertStringToInt("ASD");

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ConvertStringToInt_StringIsValidInteger_ReturnsInteger()
        {
            var sut = new Validation();

            var result = sut.ConvertStringToInt("12345");

            result.Should().Be(12345);
        }

        [Test]
        public void areUserSettingsValid_UsernameIsEmpty_ReturnFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.areUserSettingsValid("", 55555, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_UsernameIsNull_ReturnFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.areUserSettingsValid(null, 55555, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidZipcode_ReturnFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.areUserSettingsValid("TestUser", -1, 1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidForecastType_ReturnFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.areUserSettingsValid("TestUser", 55555, -1, 1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void areUserSettingsValid_InvalidTempertureType_ReturnFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.areUserSettingsValid("TestUser", 55555, 1, -1);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void isZipcode_InvalidZipcode_returnsFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.isZipcode(0);

            //assert
            result.Should().Be(false);
        }

        [Test]
        public void isStringADate_invalidString_returnsFalse()
        {
            //arr
            var sut = new Validation();

            //act
            var result = sut.isStringADate("Test");

            //assert
            result.Should().Be(false);
        }
    }
}