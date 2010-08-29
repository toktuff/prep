using System;

namespace ShopList.Model
{
    public class ShoppingList : IShoppingList
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ShoppingList() : this(Guid.NewGuid(), "")
        {
            
        }


        public ShoppingList(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}