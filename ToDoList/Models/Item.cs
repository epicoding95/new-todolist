using System.Collections.Generic;

namespace ToDoList.Models
{///check if first section is needed
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }

        public ICollection<CategoryItem> Categories { get; }
    }


    public class CategoryItem
    {
        public int CategoryItemId { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public Item Item { get; set; }
        public Category Category { get; set; }
    }
}
