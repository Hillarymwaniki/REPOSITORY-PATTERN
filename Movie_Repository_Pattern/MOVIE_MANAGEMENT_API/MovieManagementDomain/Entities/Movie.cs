namespace MovieManagementDomain.Entities;

public class Movie
{
    public int Id { get; set; }
    public string movieName { get; set; } = string.Empty;
    public string movieDescription { get; set; } = string.Empty;
    public int ActorId { get; set; } // Foreign Key
    public Actor? Actor {get; set;} // Many movies can have one actor

    public List <Genre>? Genre {get; set;}
}