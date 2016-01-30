using System.Collections.Generic;
using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient.Models
{
    public class Team : IModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public IList<TeamMember> Users { get; set; }

        public IList<Iternation> Iternations { get; set; } 
    }
}
