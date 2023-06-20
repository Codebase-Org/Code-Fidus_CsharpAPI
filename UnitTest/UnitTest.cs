using Code_Fidus_CsharpAPI.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Moq;

namespace UnitTest
{
    public class UnitTest
    {
        //private readonly BaseEntitiesController _bect;
        //private readonly Mock<>
        //[Fact]
        //public void Test1()
        //{

        //}

        //private readonly UserModelsController _sut;
        //private Mock<IUserService> _userservice = new();

        //public UserModelsControllers()
        //{
        //    _sut = new UserModelsController(_userservice.Object);
        //}

        //[Fact]
        //public async void Create_ShouldReturStatusCode200()
        //{
        //    //Arrange
        //    UserModel user = new UserModel()
        //    {
        //        UserId = 0,
        //        UserName = "Eleven",
        //        UPassword = "Passw0rd",
        //        Email = "eleven@elev.tec.dk",
        //        UTLF = 12344321,
        //        RoleId = 1,
        //        role = new RoleModel
        //        {
        //            RoleId = 1,
        //            Role = "user"
        //        },
        //        AddressId = 11,
        //        address = new AddressModel
        //        {
        //            AddressId = 11,
        //            PostCodeId = 1,
        //            postCode = new PostcodeModel
        //            {
        //                PostcodeId = 1,
        //                Postcode = 2750,
        //                City = "Ballerup",
        //            },
        //            StreetNames = "Telegrafvej 9"
        //        }
        //    };
        //    UserResp create = new UserResp();
        //    // Interface niveau
        //    _userservice.Setup(a => a.CreateUserService(user)).ReturnsAsync(create);

        //    //Act
        //    var result = await _sut.CreateUser(user);

        //    //Assert - Controller niveau
        //    var statuscoderesult = (IStatusCodeActionResult)result.Result;
        //    Assert.Equal(200, statuscoderesult.StatusCode);
        //}
    }
}