using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using PairingMatrix.ServiceClient;
using PairingMatrix.ServiceClient.Models;
using Xunit;

namespace Tests.UnitTests
{
    public class InMemoryCrudTests
    {
        readonly InMemoryCRUD<Team> _crudService = new InMemoryCRUD<Team>();

        [Fact]
        public async Task AddOrUpdateAsync_CreatesTeam_WhenIdisZero()
        {
            string teamName = Guid.NewGuid().ToString();

            Team team = new Team
            {
                Name = teamName
            };

            await _crudService.AddOrUpdateAsync(team);

            team.Id.Should().NotBe(0);

            var retrievedTeam = await _crudService.GetbyIdAsync(team.Id);

            retrievedTeam.Name.ShouldBeEquivalentTo(teamName);
        }
    }
}
