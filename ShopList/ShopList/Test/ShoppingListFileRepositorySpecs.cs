// ReSharper disable InconsistentNaming
#pragma warning disable 169
using System;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using ShopList.Model;

namespace ShopList.Test
{
    public class when_adding_a_list_to_repository : Observes<FileShoppingListRepository>
    {
        Establish c = () =>
            {
                _list = an<IShoppingList>();
                _list.Id = new Guid("{3636A382-6DE7-4A3E-A5D1-FF5CFF40C76E}");
            };

        Because b = () =>
                    sut.Add(_list);

        It should_store_list_with_filename_based_of_id = () =>
                                                         the_dependency<IFileSystem>().received(
                                                             fs => fs.Save("3636A3826DE74A3EA5D1FF5CFF40C76E", null));

        static IShoppingList _list;
    }

    //public class when_retrieving_list_previously_added : Observes<FileShoppingListRepository>
    //{
    //    Establish c = () =>
    //        {
    //            _id = Guid.NewGuid();

    //            // Set up mock.
    //            _shoppingList = an<IShoppingList>();
    //            _shoppingList.Id = _id;
    //            _shoppingList.Name = "Foo";
    //        };

    //    Because b = () =>
    //                _list = sut.Get(_id);

    //    It should_get_list_with_corresponding_id = () =>
    //                                               _list.Id.ShouldEqual(_id);

    //    It should_include_details_from_stored_shopping_list = () =>
    //                                                          _list.Name.ShouldEqual("Foo");

    //    static IShoppingList _list;
    //    static IShoppingList _shoppingList;
    //    static Guid _id;
    //}
}