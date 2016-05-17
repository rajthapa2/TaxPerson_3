using NUnit.Framework;
using TaxPerson.Service;

namespace Unit.TaxPerson.Tests
{
    [TestFixture]
    public class TaxPersonTests
    {
        [Test]
        public void Should_return_correct_amount_after_taxed_for_luxary_item()
        {
           var result =   TaxCalculator.Calculate(100, Item.Beer);
            Assert.That(result, Is.EqualTo(109));
        }

        [Test]
        public void Should_return_correct_amount_after_taxed_for_necessity_item()
        {
            var result = TaxCalculator.Calculate(100, Item.Water);
            Assert.That(result, Is.EqualTo(101));
        }
    }
}
