using UnitTestExample;
using Xunit;
using M


namespace InterfaceExample.test
{
    public class DeskFunTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual);


        }
    }
        
    class PowerSupplyLowerThanZero:IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
}