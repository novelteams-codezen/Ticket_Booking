using System;

namespace TicketBooking.Filter
{
    public class FilterCriteria
    {
        public string PropertyName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}