using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Station
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public virtual ICollection<TrainStation> TrainStations { get; set; } = new List<TrainStation>();
}
