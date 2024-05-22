using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TicketBooking.Entities
{
    /// <summary> 
    /// Represents a ticketdeliverymethod entity with essential details
    /// </summary>
    public class TicketDeliveryMethod
    {
        /// <summary>
        /// TenantId of the TicketDeliveryMethod 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TicketDeliveryMethod 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the TicketDeliveryMethod 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the TicketDeliveryMethod 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the TicketDeliveryMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TicketDeliveryMethod 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TicketDeliveryMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TicketDeliveryMethod 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}