using System;
using System.Collections.Generic;
using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient.Models
{
    public class Iternation : IModel
    {
        public long Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Team Team { get; set; }

        public IList<Pair> Pairs { get; set; }
    }
}