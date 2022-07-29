using cgidemoapp.Models;
using System.Collections.Generic;

namespace cgidemoapp.Data;
public static class DbInitializer
{
    private static int CategoryCounter = 0;
    private static int ProductCounter = 0;
    public static void Initialize(DataContext context)
    {
        context.Database.EnsureCreated();

        if (context.Categories.Any())
        {
            return;
        }

        AddCat(context, "Area cleaning equipment and tools", 
            new string[]{
                "Waste and sand containers",
                "Area cleaners",
                "Snow blowers",
                "Multifunctional cleaning tools",
                "Garbage collection tools",
                "Brooms and brushes",
                "Snow shovels and shovels",
                "Ice picks",
                "Surface spreading materials"
            });
        var seeds = AddCat(context, "Seeds",
            new string[] {
                    "Vegetables and berries",
                    "Greens and herbs",
                    "Flowers",
                    "Grassland and meadow",
                    "Seeds for germination and kits",
                    "Seed potatoes"
        });
        var c1 = AddCat(context, "Plant care and cultivation", 
            new string[] {
                "Fertilizer",
                "Soils and peats",
                "Composting",
                "Mulch",
                "Plant protection products",
                "Greenhouses and greenhouses",
                "Garden films",
                "Planting container",
                "Supports and fasteners for plants",
                "Cords, links, fastenings"
            });
        var s1 = AddSubCats(context, c1.Item2.First(), 
            new string[] {
                "For indoor plants",
                "For fruit trees and berries",
                "For decorative trees and plants",
                "For summer and balcony flowers",
                "For vegetables and herbs",
                "Universal",
                "For the lawn",
                "For cut flowers"
            });

        context.CategoryMappings.Add(new CategoryMapping() { ParentCategoryId =  s1.First().Id, ChildCategoryId = seeds.Item1.Id });
        context.SaveChanges();

        AddCat(context, "Flower bulbs and gum", 
            new string[] {
                "Erantes",
                "Gloxinias",
                "Muscari",
                "Liatris",
                "Tritelian",
                "Faster",
                "Tigris",
                "Agapanta",
                "Ear liatres",
                "Pushkin"
            });
        AddCat(context, "Garden houses, cabinets and boxes", 
            new string[] {
                "Garden houses",
                "Cabinets, boxes and shelves"
            });
        AddCat(context, "Grills, smokehouses, fire pits and accessories", 
            new string[] {
                "Grill",
                "Disposable grills",
                "Smokehouses",
                "Furnaces, cauldrons",
                "Grilling accessories",
                "Utensils for baking and cooking",
                "Charcoal, wood chips and kindling",
                "Barbecue gas and cylinders",
                "Fire vessels, stands",
                "Garden fireplaces",
                "Pizza ovens"
            });
        AddCat(context, "Garden Furniture", 
            new string[] {
                "Furniture sets",
                "Tables",
                "Chairs",
                "A step",
                "Sofas",
                "Party furniture",
                "Picnic tables",
                "Picnic and fishing chairs",
                "children furniture",
                "Loungers"
            });
        AddCat(context, "Garden canopies, parasols and awnings", 
            new string[] {
                "Wind screens",
                "Awnings",
                "Sunshades, holders and bases",
                "Marquesses"
            });
        AddCat(context, "Garden watering", 
            new string[]{
                "Sprinklers and sprinklers",
                "Watering guns and nozzles",
                "Underground irrigation systems",
                "Automation, timers and regulators",
                "Rainwater harvesting",
                "Garden showers",
                "Pumps",
                "Watering cans and hand sprayers",
                "Hoses",
                "Hose reels and holders"
            });

        var p = context.Products.Add(new Product() { Id = ++ProductCounter, Name = "Reused product" }).Entity;
        context.SaveChanges();
        foreach (var c in context.Categories)
        {
            for (var n = 0; n < 4; n++)
            {
                var newprod = AddCategoryProduct(context, c, $"P[{ProductCounter + 1}] {c.Name}");
                if (n == 1)
                {
                    newprod.Promoted = true;
                    context.SaveChanges();
                }
            }
            context.ProductCategories.Add(new ProductCategory() { CategoryId = c.Id, ProductId = p.Id });
            context.SaveChanges();
        }
        context.Categories.First(x=>x.Name == "Fertilizer").Promoted = true;
        context.Categories.First(x => x.Name == "Garden watering").Promoted = true;
        context.Categories.First(x => x.Name == "Sofas").Promoted = true;
        context.Categories.First(x => x.Name == "Gloxinias").Promoted = true;
        context.Categories.First(x => x.Name == "Flowers").Promoted = true;
        

        context.SaveChanges();
    }
    private static Product AddCategoryProduct(DataContext ctx, Category c, string product)
    {
        var p = ctx.Products.Add(new Product() { Id = ++ProductCounter, Name = product }).Entity;
        ctx.SaveChanges();
        ctx.ProductCategories.Add(new ProductCategory() { CategoryId = c.Id, ProductId = p.Id });
        ctx.SaveChanges();
        return p;
    }
    private static (Category, List<Category>?) AddCat(DataContext ctx, string cat, string[] sub)
    {
        var category = ctx.Categories.Add(new Category() { Id = ++CategoryCounter, Name = cat }).Entity;
        ctx.SaveChanges();
        if (sub != null && sub.Length > 0)
        {
            var subcats = AddSubCats(ctx, category, sub);
            return (category, subcats);
        }
        return (category, null);
    }

    private static List<Category> AddSubCats(DataContext ctx, Category parentCat, string[] subCats)
    {
        var subcats = new List<Category>();
        foreach (var subCat in subCats)
        {           
            var subcat = ctx.Categories.Add(new Category() { Id = ++CategoryCounter, Name = subCat }).Entity;
            ctx.SaveChanges();
            ctx.CategoryMappings.Add(new CategoryMapping() { ParentCategoryId = parentCat.Id, ChildCategoryId = subcat.Id });
            ctx.SaveChanges();    
            subcats.Add(subcat);
        }
        return subcats;
    }
}

