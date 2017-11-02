namespace WcfDataService
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public int[] OrderItems { get; set; }
    }
}