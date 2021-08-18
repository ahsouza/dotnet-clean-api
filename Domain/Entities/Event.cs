using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
  public class Event
  {
    [JsonIgnore]
    public int EventId { get; set; }

  }
}