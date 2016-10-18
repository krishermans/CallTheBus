using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CallTheBus.ViewModel;

namespace CallTheBus.Tests
{
    public class BuzzAlerterTests
    {
        [Fact]
        public void AlertMessage_WhenCreated_ReturnsStop()
        {
            var sut = new BuzzAlerterViewModel();
            Assert.Equal("Stop!", sut.AlertMessage);
        }
    }
}
