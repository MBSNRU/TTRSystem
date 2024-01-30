using System;
using System.Collections.Generic;

namespace TTRSystemApi.Models;

public partial class Class
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<Coach> Coaches { get; set; } = new List<Coach>();
}
