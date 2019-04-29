using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class BookingHelperTests
    {
        [Test]
        public void OverlappingBookingsExist_BookingCancelled_ReturnEmptyString()
        {
            
            var booking = new Booking {Status = "Cancelled"};

            var result = BookingHelper.OverlappingBookingsExist(booking);
            
            Assert.That(result, Is.Empty);
        }
    }
}