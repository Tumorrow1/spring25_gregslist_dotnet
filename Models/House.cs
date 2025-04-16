namespace gregslist_dotnet.Models
{

}
public class House
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public int SqFt { get; set; }
  public int BedRoom { get; set; }
  public int BathRoom { get; set; }
  public string ImgUrl { get; set; }
  public string Description { get; set; }
  public int Price { get; set; }
  public string CreatorId { get; set; }
  public Account Creator { get; set; }
}