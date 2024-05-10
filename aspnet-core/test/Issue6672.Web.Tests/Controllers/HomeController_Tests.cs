using System.Threading.Tasks;
using Issue6672.Models.TokenAuth;
using Issue6672.Web.Controllers;
using Shouldly;
using Xunit;

namespace Issue6672.Web.Tests.Controllers
{
    public class HomeController_Tests: Issue6672WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}