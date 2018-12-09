using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DojoTDD.Tests
{
    public class RomanNumeralsConverterTest
    {
        private RomanNumeralsConverter _romanNumeralsConverter;

        [SetUp]
        public void SetUp()
        {
            _romanNumeralsConverter = new RomanNumeralsConverter();
        }

        [Test]
        public void deve_retornar_1()
        {
            _romanNumeralsConverter.ConverterNumerosRomanos("I").Should().Be(1);
        }

        [Test]
        public void deve_retornar_5()
        {
            _romanNumeralsConverter.ConverterNumerosRomanos("V").Should().Be(5);
        }

        [Test]
        public void deve_retornar_10()
        {
            _romanNumeralsConverter.ConverterNumerosRomanos("X").Should().Be(10);
        }

        [Test]
        public void deve_retornar_2()
        {
            _romanNumeralsConverter.ConverterNumerosRomanos("II").Should().Be(2);
        }

        [Test]
        public void deve_retornar_20()
        {
            _romanNumeralsConverter.ConverterNumerosRomanos("XX").Should().Be(20);
        }

        [TestCase("XXII", 22)]
        [TestCase("XI", 11)]
        [TestCase("XV", 15)]
        [TestCase("IV", 4)]
        [TestCase("CCCXCIX", 399)]
        [TestCase("MCMLXXXIV", 1984)]
        [TestCase("DIX", 509)]
        public void deve_somar_dois_numeros(string str, int ret)
        {
            _romanNumeralsConverter.ConverterNumerosRomanos(str).Should().Be(ret);
        }


    }
}
