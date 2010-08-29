using System;

namespace ShopList.Presenter
{
    public interface IShoppingListIndexView
    {
        void ClearShoppingLists();
        void AddShoppingList(Guid id, string name);
    }
}