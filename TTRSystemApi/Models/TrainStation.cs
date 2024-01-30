using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class TrainStation
{
    public int Id { get; set; }

    public int? TrainId { get; set; }

    public int? StationId { get; set; }

    public int? StopNumber { get; set; }

    public TimeOnly? DepartAt { get; set; }

    public TimeOnly? ArriveAt { get; set; }

    public virtual Station? Station { get; set; }

    public virtual Train? Train { get; set; }
}
