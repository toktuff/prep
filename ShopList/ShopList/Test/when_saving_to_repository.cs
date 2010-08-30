using System;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using ShopList.Model;
using Rhino.Mocks;

namespace ShopList.Test
{
    public class when_saving_to_repository : Observes<FileShoppingListRepository>
    {
        Establish c = () =>
            {
                _id = Guid.NewGuid();
                _list = an<IShoppingList>();
                _list.Id = _id;
            };

        Because b = () =>
            {
                sut.Add(_list);
            };

        It should_use_the_list_id_to_form_the_file_name = () =>
            {
                the_dependency<IFileSystem>().received(fs => fs.Save(_id.ToString("N").ToUpper(), null));
            };

        static IShoppingList _list;
        static Guid _id;
    }
   public class when_loading_from_repository : Observes<FileShoppingListRepository>
    {
        Establish c = () =>
            {
                _id = Guid.NewGuid();
            };

        Because b = () =>
            {
                _result = sut.Get(_id);
            };

        It should_use_the_list_id_to_form_the_file_name = () =>
            {
                the_dependency<IFileSystem>().received(fs => fs.Load(_id.ToString("N").ToUpper()));
            };

        static Guid _id;
       static IShoppingList _result;
    }
}