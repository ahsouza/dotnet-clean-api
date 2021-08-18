using Domain.Entities.MongoDB.CustomAttributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.MongoDB
{
  public class Ticket
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Title")]
    [Required]
    public string Title { get; set; }

    [BsonElement("Description")]
    [Required]
    public string Description { get; set; }

    [BsonElement("Year")]
    [Required]
    [YearRange]
    public int Year { get; set; }

    [BsonElement("Price")]
    [Display(Name = "Price($)")]
    [DisplayFormat(DataFormatString = "{0:#,0}")]
    public decimal Price { get; set; }

    [BsonElement("ImageUrl")]
    [Display(Name = "Photo")]
    [DataType(DataType.ImageUrl)]
    [Required]
    public string ImageUrl { get; set; }
  }
}