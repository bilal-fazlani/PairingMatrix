using System.Collections.Generic;
using PairingMatrix.Service.Interfaces;

namespace PairingMatrix.Service.Models
{
    public class Team : IModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<long> MemberIds { get; set; }

        public List<long> IternationIds { get; set; } 
    }
}
