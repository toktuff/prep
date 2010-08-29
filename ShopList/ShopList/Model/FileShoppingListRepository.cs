using System;
using ShopList.Test;

namespace ShopList.Model
{
    public class FileShoppingListRepository
    {
        public Guid Add(ShoppingList list)
        {
            return Guid.NewGuid();
        }

        public ShoppingList Get(Guid id)
        {
            return new ShoppingList
                       {
                           Id = id
                       };
        }
    }
}