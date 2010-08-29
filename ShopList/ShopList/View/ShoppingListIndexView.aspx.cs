using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopList.Presenter;

namespace ShopList.View
{
    public partial class ShoppingListIndexView : Page, IShoppingListIndexView
    {
        readonly ShoppingListIndexPresenter _presenter;
        protected List<string> Names = new List<string>();
        protected List<Guid> Ids = new List<Guid>();

        public ShoppingListIndexView()
        {
            _presenter = new ShoppingListIndexPresenter(this);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter.UpdateView();
        }

        public void ClearShoppingLists()
        {
            Names.Clear();
            Ids.Clear();
        }

        public void AddShoppingList(Guid id, string name)
        {
            Names.Add(name);
            Ids.Add(id);
        }

        protected void DeleteButtonClick(object sender, EventArgs e)
        {
            var b = (Button) sender;
            _presenter.DeleteShoppingList(new Guid(b.CommandArgument));
        }
    }
}