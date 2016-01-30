using System.Collections.Generic;
using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient.Models
{
    public class TeamMember:IModel
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public IList<Team> Teams { get; set; }
    }
}