using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TestApi.Controllers
{
    [DataContract(Namespace = "", Name = "Customer")]
    
    public class Customer
    {
        [DataMember(Name = "CustomerId")]
        public int CustomerId { get; set; }

        [DataMember(Name = "CustomerType")]
        public CustomerTypeDTO CustomerTypeDto { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Orders")]
        public List<OrderDTO> Orders { get; set; }
    }

    [DataContract(Namespace = "", Name = "CustomerType")]
    public class CustomerTypeDTO
    {
        [DataMember(Name = "CustomerTypeId")]
        public int CustomerTypeId { get; set; }

        [DataMember(Name = "TypeCode")]
        public string TypeCode { get; set; }

    }

    [DataContract(Namespace = "", Name = "Order")]
    public class OrderDTO
    {
        [DataMember(Name = "OrderId")]
        public int OrderId { get; set; }

        [DataMember(Name = "CustomerId")]
        public int CustomerId { get; set; }

        [DataMember(Name = "Amount")]
        public decimal Amount { get; set; }
    }

}


