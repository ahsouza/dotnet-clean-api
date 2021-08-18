  
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
  public class Participant
  {
    [JsonIgnore]
    public int ParticipantId { get; set; }

    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Bio { get; set; }
    public string? Image { get; set; }
    public bool? IsAdmin { get; set; }
  //  [JsonIgnore]
  //  public List<MyEvents> MyEvents { get; set; } = new();
  //  [JsonIgnore]
  //  public List<MyInscriptions> MyInscriptions { get; set; } = new();
    [JsonIgnore]
    public byte[] Hash { get; set; } = Array.Empty<byte>();
    
    [JsonIgnore]
    public byte[] Salt { get; set; } = Array.Empty<byte>();
  }
}