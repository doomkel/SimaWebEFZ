using Xunit;
using Moq;
using System.Data;
using System.Collections.Generic;
using DataAccessLibrary.Models;
using System.Threading.Tasks;
using Dapper;
using System.Reflection;

namespace DataAccessLibrary.Tests
{
    public class EntradasDataTest
    {
        [Fact]
        public async void GetEntradas_Valid()
        {
            //arrange
            Mock<ISqlDataAccess> connection = new Mock<ISqlDataAccess>();
            var expected = new List<EntradasModel>{

                new EntradasModel { Folio = 1, NombreRecibe = "Test1" },
                new EntradasModel { Folio = 2, NombreRecibe = "Test2" }

            };
            connection.Setup(x => x.LoadData<EntradasModel, object>
                (It.IsAny<string>(), It.IsAny<object>()))
                .Returns(Task.FromResult(expected));


            //act
            var sut = new EntradasData(connection.Object);
            List<EntradasModel> actual = await sut.GetEntradas();


            //assert
            Assert.True(actual.Count == 2);
        }
    }
}
