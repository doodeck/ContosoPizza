// Pizza.cs

namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; } // Nullable<string>
    public bool IsGlutenFree { get; set; }
}