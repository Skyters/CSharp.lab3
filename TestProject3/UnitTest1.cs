using NUnit.Framework;
using CSharp.lab3;

namespace TestProject3
{
    public class Tests
    {
        [Test]
        public void Value_IsClampedToZero_WhenNegative()
        {
            var red = new Red(-10);
            Assert.That(red.Value, Is.EqualTo(0));
        }

        [Test]
        public void Value_IsClampedTo255_WhenOver()
        {
            var red = new Red(300);
            Assert.That(red.Value, Is.EqualTo(255));
        }

        [Test]
        public void OperatorPlus_Object_IncreasesValue()
        {
            var red = new Red(100) + 50;
            Assert.That(red.Value, Is.EqualTo(150));
        }

        [Test]
        public void OperatorPlus_Object_ClampsAt255()
        {
            var red = new Red(250) + 100;
            Assert.That(red.Value, Is.EqualTo(255));
        }

        [Test]
        public void OperatorPlus_Int_IncreasesValue()
        {
            var red = 30 + new Red(100);
            Assert.That(red.Value, Is.EqualTo(130));
        }

        [Test]
        public void OperatorMinus_Object_DecreasesValue()
        {
            var red = new Red(100) - 40;
            Assert.That(red.Value, Is.EqualTo(60));
        }

        [Test]
        public void OperatorMinus_Object_ClampsAtZero()
        {
            var red = new Red(10) - 100;
            Assert.That(red.Value, Is.EqualTo(0));
        }

        [Test]
        public void OperatorMinus_Int_Works()
        {
            var red = 200 - new Red(50);
            Assert.That(red.Value, Is.EqualTo(150));
        }
    }
}