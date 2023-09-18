namespace MovieManagementDomain.Entities;

public class Genre
{
    public int Id { get; set; }
    public string genreName { get; set; } = string.Empty;
    public List <Movie>? Movie {get; set;} // Many-to-Many Relationships

}