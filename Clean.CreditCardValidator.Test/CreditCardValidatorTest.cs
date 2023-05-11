using NUnit.Framework;

namespace Clean.CreditCardValidator.Test
{
    [TestFixture]
    public class CreditCardValidatorTest
    {
        [Test, Description("should return false if an invalid credit card is provided")]
        public void CreditCardValidator_InvalidCreditCard_ReturnsFalse()
        {
            Assert.That(CreditCardValidator.Validate("1234 1234 1234"), Is.EqualTo(false));
        }

        [Test, Description("should return false if an empty credit card is provided")]
        public void CreditCardValidator_EmptyCreditCard_ReturnsFalse()
        {
            Assert.That(CreditCardValidator.Validate(""), Is.EqualTo(false));
        }

        [Test, Description("should return true if a valid credit card is provided with no spaces")]
        public void CreditCardValidator_ValidCreditCard_WithNoSpaces_ReturnsTrue()
        {
            Assert.That(CreditCardValidator.Validate("1234123412341234"), Is.EqualTo(true));
        }
    }
}
