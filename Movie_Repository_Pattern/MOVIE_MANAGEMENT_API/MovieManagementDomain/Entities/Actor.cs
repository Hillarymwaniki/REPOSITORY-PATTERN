namespace MovieManagementDomain.Entities;

public class Actor
{
    public int Id { get; set; }
    public string firstName { get; set; } = string.Empty();
    public string lastName { get; set; } = string.Empty();
    public List<Movie>? Movies {get; set;} // An actor can act in many movies
    public Biography? Biography {get; set;}
}