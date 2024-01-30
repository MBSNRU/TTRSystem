using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Booking
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? SeatId { get; set; }

    public DateOnly? BookingDate { get; set; }

    public string? PaymentStatus { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Seat? Seat { get; set; }

    public virtual User? User { get; set; }
}
