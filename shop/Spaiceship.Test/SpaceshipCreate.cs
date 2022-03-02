using shop.ApplicationServices.Services;
using shop.Core.Dtos;
using shop.Core.ServiceInterface;
using shop.Models.Spaceship;
using System;
using Xunit;

namespace Spaiceship.Test
{
    public class SpaceshipCreate
    {
        private readonly ISpaceshipService _spaceship;
        public SpaceshipCreate
            (
            ISpaceshipService spaceship
            )
        {
            spaceship = _spaceship;
        }

        [Fact]
        public void When_CreateNewSpaceship_ThenItWillAddNewData()
        {
            //shop - Model - Spaceship - SpaceshipViewModel
            var spaceship = new SpaceshipDto
            {
                Name = "Superman",
                Type = "Convette",
                Mass = 123,
                Price = 123,
                Crew = 123,
                ConstructedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            var result = _spaceship.Add(spaceship);

            Assert.True(result);
        }
    }
}
