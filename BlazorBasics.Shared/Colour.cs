namespace BlazorBasics.Shared;

public class Colour
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string HexCode { get; set; }
    
    public Colour(int id, string name, string hexCode)
    {
        this.Id = id;
        this.Name = name;
        this.HexCode = hexCode;
    }
}