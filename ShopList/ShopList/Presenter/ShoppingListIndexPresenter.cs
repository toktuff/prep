using System;
using System.Collections.Generic;

namespace ShopList.Presenter
{
    public class ShoppingListIndexPresenter
    {
        private readonly IShoppingListIndexView _view;

        public ShoppingListIndexPresenter(IShoppingListIndexView view)
        {
            _view = view;
        }

        public void UpdateView()
        {

            _view.ClearShoppingLists();
            _view.AddShoppingList(Guid.NewGuid(), "Fruits and veggies");
        }

        public void DeleteShoppingList(Guid id)
        {
            // TODO
        }
    }
}