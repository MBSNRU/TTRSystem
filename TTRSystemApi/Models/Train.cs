using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Train
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public string? Name { get; set; }

    public string? SourceStation { get; set; }

    public string? DestinationStation { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<TrainStation> TrainStations { get; set; } = new List<TrainStation>();
}
