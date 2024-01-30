using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Coach
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
