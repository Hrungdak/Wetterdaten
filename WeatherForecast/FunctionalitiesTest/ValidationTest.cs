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

            int result = sut.ConvertStringToInt("12345");

            result.Should().Be(12345);
        }
    }
}