using Microsoft.EntityFrameworkCore;
using TicketBooking.Entities;

namespace TicketBooking.Data
{
    public class TicketBookingContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=codezen.database.windows.net;Initial Catalog=codezen;Persist Security Info=True;user id=Lowcodeadmin;password=NtLowCode^123*;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<Ticket>().HasKey(a => a.Id);
            modelBuilder.Entity<Reservation>().HasKey(a => a.Id);
            modelBuilder.Entity<Event>().HasKey(a => a.Id);
            modelBuilder.Entity<Venue>().HasKey(a => a.Id);
            modelBuilder.Entity<Seat>().HasKey(a => a.Id);
            modelBuilder.Entity<TicketType>().HasKey(a => a.Id);
            modelBuilder.Entity<Pricing>().HasKey(a => a.Id);
            modelBuilder.Entity<Customer>().HasKey(a => a.Id);
            modelBuilder.Entity<Payment>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentMethod>().HasKey(a => a.Id);
            modelBuilder.Entity<Booking>().HasKey(a => a.Id);
            modelBuilder.Entity<TicketStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<EventCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<EventSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Discount>().HasKey(a => a.Id);
            modelBuilder.Entity<PromoCode>().HasKey(a => a.Id);
            modelBuilder.Entity<Organizer>().HasKey(a => a.Id);
            modelBuilder.Entity<RefundPolicy>().HasKey(a => a.Id);
            modelBuilder.Entity<Section>().HasKey(a => a.Id);
            modelBuilder.Entity<Row>().HasKey(a => a.Id);
            modelBuilder.Entity<SeatMap>().HasKey(a => a.Id);
            modelBuilder.Entity<TicketHolder>().HasKey(a => a.Id);
            modelBuilder.Entity<TicketDeliveryMethod>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentTransaction>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentGateway>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<CardIssuer>().HasKey(a => a.Id);
            modelBuilder.Entity<CardType>().HasKey(a => a.Id);
            modelBuilder.Entity<TransactionFee>().HasKey(a => a.Id);
            modelBuilder.Entity<Refund>().HasKey(a => a.Id);
            modelBuilder.Entity<Chargeback>().HasKey(a => a.Id);
            modelBuilder.Entity<Settlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Currency>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentAccount>().HasKey(a => a.Id);
            modelBuilder.Entity<BillingAddress>().HasKey(a => a.Id);
            modelBuilder.Entity<MerchantAccount>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Ticket>().HasOne(a => a.ReservationId_Reservation).WithMany().HasForeignKey(c => c.ReservationId);
            modelBuilder.Entity<Ticket>().HasOne(a => a.SeatId_Seat).WithMany().HasForeignKey(c => c.SeatId);
            modelBuilder.Entity<Ticket>().HasOne(a => a.TicketTypeId_TicketType).WithMany().HasForeignKey(c => c.TicketTypeId);
            modelBuilder.Entity<Reservation>().HasOne(a => a.EventId_Event).WithMany().HasForeignKey(c => c.EventId);
            modelBuilder.Entity<Event>().HasOne(a => a.VenueId_Venue).WithMany().HasForeignKey(c => c.VenueId);
            modelBuilder.Entity<Seat>().HasOne(a => a.VenueId_Venue).WithMany().HasForeignKey(c => c.VenueId);
            modelBuilder.Entity<Pricing>().HasOne(a => a.EventId_Event).WithMany().HasForeignKey(c => c.EventId);
            modelBuilder.Entity<Pricing>().HasOne(a => a.TicketTypeId_TicketType).WithMany().HasForeignKey(c => c.TicketTypeId);
            modelBuilder.Entity<Payment>().HasOne(a => a.PaymentMethodId_PaymentMethod).WithMany().HasForeignKey(c => c.PaymentMethodId);
            modelBuilder.Entity<Booking>().HasOne(a => a.CustomerId_Customer).WithMany().HasForeignKey(c => c.CustomerId);
            modelBuilder.Entity<Booking>().HasOne(a => a.EventScheduleId_EventSchedule).WithMany().HasForeignKey(c => c.EventScheduleId);
            modelBuilder.Entity<Booking>().HasOne(a => a.PaymentId_Payment).WithMany().HasForeignKey(c => c.PaymentId);
            modelBuilder.Entity<EventSchedule>().HasOne(a => a.EventCategoryId_EventCategory).WithMany().HasForeignKey(c => c.EventCategoryId);
            modelBuilder.Entity<PromoCode>().HasOne(a => a.DiscountId_Discount).WithMany().HasForeignKey(c => c.DiscountId);
            modelBuilder.Entity<Section>().HasOne(a => a.SeatMapId_SeatMap).WithMany().HasForeignKey(c => c.SeatMapId);
            modelBuilder.Entity<Row>().HasOne(a => a.SectionId_Section).WithMany().HasForeignKey(c => c.SectionId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.PaymentGatewayId_PaymentGateway).WithMany().HasForeignKey(c => c.PaymentGatewayId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.PaymentStatusId_PaymentStatus).WithMany().HasForeignKey(c => c.PaymentStatusId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.CardIssuerId_CardIssuer).WithMany().HasForeignKey(c => c.CardIssuerId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.CardTypeId_CardType).WithMany().HasForeignKey(c => c.CardTypeId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.TransactionFeeId_TransactionFee).WithMany().HasForeignKey(c => c.TransactionFeeId);
            modelBuilder.Entity<PaymentTransaction>().HasOne(a => a.RefundId_Refund).WithMany().HasForeignKey(c => c.RefundId);
            modelBuilder.Entity<Refund>().HasOne(a => a.PaymentTransactionId_PaymentTransaction).WithMany().HasForeignKey(c => c.PaymentTransactionId);
            modelBuilder.Entity<Chargeback>().HasOne(a => a.SettlementId_Settlement).WithMany().HasForeignKey(c => c.SettlementId);
            modelBuilder.Entity<Chargeback>().HasOne(a => a.CurrencyId_Currency).WithMany().HasForeignKey(c => c.CurrencyId);
            modelBuilder.Entity<Settlement>().HasOne(a => a.MerchantAccountId_MerchantAccount).WithMany().HasForeignKey(c => c.MerchantAccountId);
            modelBuilder.Entity<Settlement>().HasOne(a => a.CurrencyId_Currency).WithMany().HasForeignKey(c => c.CurrencyId);
            modelBuilder.Entity<PaymentAccount>().HasOne(a => a.BillingAddressId_BillingAddress).WithMany().HasForeignKey(c => c.BillingAddressId);
        }

        public DbSet<UserInRole> UserInRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<TicketStatus> TicketStatus { get; set; }
        public DbSet<EventCategory> EventCategory { get; set; }
        public DbSet<EventSchedule> EventSchedule { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<PromoCode> PromoCode { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<RefundPolicy> RefundPolicy { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Row> Row { get; set; }
        public DbSet<SeatMap> SeatMap { get; set; }
        public DbSet<TicketHolder> TicketHolder { get; set; }
        public DbSet<TicketDeliveryMethod> TicketDeliveryMethod { get; set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<PaymentGateway> PaymentGateway { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<CardIssuer> CardIssuer { get; set; }
        public DbSet<CardType> CardType { get; set; }
        public DbSet<TransactionFee> TransactionFee { get; set; }
        public DbSet<Refund> Refund { get; set; }
        public DbSet<Chargeback> Chargeback { get; set; }
        public DbSet<Settlement> Settlement { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<PaymentAccount> PaymentAccount { get; set; }
        public DbSet<BillingAddress> BillingAddress { get; set; }
        public DbSet<MerchantAccount> MerchantAccount { get; set; }
    }
}