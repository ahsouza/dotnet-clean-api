using Domain.Entities.MongoDB.CustomAttributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities.MongoDB
{
  public class Participant
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Username")]
    [Required]
    public string Username { get; set; }

    [BsonElement("Email")]
    [Required]
    public string Email { get; set; }

    [BsonElement("Bio")]
    public string Bio { get; set; }

    [BsonElement("IsAdmin")]
    [Required]
    public bool IsAdmin { get; set; }

    [BsonElement("Hash")]
    public byte[] Hash { get; set; }

    [BsonElement("Salt")]
    public byte[] Salt { get; set; }

    [BsonElement("Image")]
    [Display(Name = "Image")]
    [DataType(DataType.Image)]
    public string Image { get; set; }
  }

}