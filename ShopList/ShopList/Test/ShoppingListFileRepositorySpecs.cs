using System;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using ShopList.Model;

namespace ShopList.Test
{
    public class when_adding_list_to_repository : Observes<FileShoppingListRepository>
    {
        static ShoppingList _list;
        static Guid _result;

        Establish c = () => { _list = new ShoppingList(); };

        Because b = () =>
                    _result = sut.Add(_list);


        It should_provide_list_id = () =>
            {
                _result.ShouldBeOfType<Guid>();
                _result.ShouldNotEqual(Guid.Empty);
            };
    }

    public class when_retrieving_list_previously_added : Observes<FileShoppingListRepository>
    {
        Establish c = () =>
                      _id = sut.Add(new ShoppingList());

        Because b = () =>
                    _list = sut.Get(_id);

        It should_get_list_with_corresponding_id = () =>
                                                   _list.Id.ShouldEqual(_id);

        static Guid _id;
        static ShoppingList _list;
    }
}