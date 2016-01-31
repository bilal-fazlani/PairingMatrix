using PairingMatrix.Service.Interfaces;

namespace PairingMatrix.Service.Models
{
    public class Pair : IModel
    {
        public long Id { get; set; }

        public long Member1Id { get; set; }

        public long Member2Id { get; set; }
    }
}