namespace cgidemoapp.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Promoted { get; set; } = false;

    public ICollection<ProductCategory> ProductCategories { get; set; }
    public ICollection<CategoryMapping> CategoryMappings { get; set; }
}

