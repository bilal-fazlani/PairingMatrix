using System.Collections.Generic;
using PairingMatrix.Service.Interfaces;

namespace PairingMatrix.Service.Models
{
    public class TeamMember:IModel
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public List<long> TeamIds { get; set; }
    }
}