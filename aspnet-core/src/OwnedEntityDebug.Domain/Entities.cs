using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Values;

namespace OwnedEntityDebug
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        private Order()
        {
        }

        public Order(Guid id) : base(id)
        {
            Cargoes=new List<Cargo>();
        }

        public ICollection<Cargo> Cargoes { get; set; }
        public Address InvoiceAddress { get; set; }
    }

    public class Cargo : FullAuditedAggregateRoot<Guid>
    {
        public Cargo()
        {
        }

        public Cargo(Guid id) : base(id)
        {
        }

        public Address ConsigeeAddress { get; set; }
        public Guid OrderId {get;set;}
    }


    //value object
    public class Address : ValueObject
    {
        public string City { get; set; }
        public string Street { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Street;
        }
    }
}