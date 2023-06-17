using Appliction.Controllers;

namespace WebTest
{
    public class HomeUnitTest
    {
        [Fact]
        public void Index_CallHomeNormally_ShouldReturnValue()
        {
            //arrange
            var req = new HomeController();

            //act
            var res = req.Index();

            //assert
            Assert.NotNull(res);
        }

        [Fact]
        public void Index_CallPrivacyNormally_ShouldReturnValue()
        {
            //arrange
            var req = new HomeController();

            //act
            var res = req.Privacy();

            //assert
            Assert.NotNull(res);
        }
    }
}