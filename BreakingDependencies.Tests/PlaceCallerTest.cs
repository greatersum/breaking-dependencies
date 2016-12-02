using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BreakingDependencies.Tests
{
    [TestFixture]
    public class PlaceCallerTest
    {
        [Test]
        public void CountryInfoTest()
        {
            Assert.That(new PlaceCaller().CountryInfo("DE"), Is.EqualTo(""));
        }
    }
}
