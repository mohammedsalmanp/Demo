using System.Collections.Generic;

public class Item
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}

public class ViewModel
{
    public List<Item> Items { get; set; }

    public ViewModel()
    {
        Items = new List<Item>
        {
            new Item { Title = "mono", Description = "Description for mono" },
            new Item { Title = "monopoly", Description = "Description for monopoly" },
            new Item { Title = "monoesthetic", Description = "Description for monoesthetic" },
            new Item { Title = "monology", Description = "Description for monology" },
            new Item { Title = "monoty", Description = "Description for monoty" },
            new Item { Title = "monow", Description = "Description for monow" },
            new Item { Title = "monosds", Description = "Description for monosds" }
        };
    }
}
