namespace MovieManagementDomain.Entities;

public class Biography
{
    public int Id { get; set; }
    public string bioDescription { get; set; } = string.Empty;
    public Actor? Actor {get; set;}
    public int ActorId { get; set; }
}