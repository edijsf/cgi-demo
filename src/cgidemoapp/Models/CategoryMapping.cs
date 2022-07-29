namespace cgidemoapp.Models;

public class CategoryMapping
{
    public int ParentCategoryId { get; set; }
    public Category ParentCategory { get; set; }
    public int ChildCategoryId { get; set; }
    public Category ChildCategory { get; set; }

}

