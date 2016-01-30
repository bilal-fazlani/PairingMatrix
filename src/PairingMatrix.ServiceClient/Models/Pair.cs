using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient.Models
{
    public class Pair : IModel
    {
        public long Id { get; set; }

        public TeamMember Member1 { get; set; }

        public TeamMember Member2 { get; set; }
    }
}