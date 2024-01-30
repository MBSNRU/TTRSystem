using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Seat
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public bool? Availability { get; set; }

    public int? CoachId { get; set; }

    public int? TrainId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Coach? Coach { get; set; }

    public virtual Train? Train { get; set; }
}
