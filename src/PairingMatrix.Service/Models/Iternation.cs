using System;
using System.Collections.Generic;
using PairingMatrix.Service.Interfaces;

namespace PairingMatrix.ServiceClient.Models
{
    public class Iternation : IModel
    {
        public long Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public long TeamId { get; set; }

        public IList<long> PairIds { get; set; }
    }
}