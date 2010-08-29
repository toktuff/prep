using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ShopList.Presenter;

namespace ShopList.View
{
    public partial class ShoppingListIndexView : System.Web.UI.Page, IShoppingListIndexView
    {
        private ShoppingListIndexPresenter _presenter;
        protected List<string> _names = new List<string>();
        protected List<Guid> _ids = new List<Guid>();

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
            _names.Clear();
            _ids.Clear();
        }

        public void AddShoppingList(Guid id, string name)
        {
            _names.Add(name);
            _ids.Add(id);
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            _presenter.DeleteShoppingList(new Guid(b.CommandArgument));
        }
    }
}
