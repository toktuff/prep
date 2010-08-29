using System;

namespace ShopList.Model
{
    public interface IShoppingList
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}