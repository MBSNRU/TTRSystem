using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int? BookingId { get; set; }

    public int? Amount { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public int? TransactionId { get; set; }

    public virtual Booking? Booking { get; set; }
}
