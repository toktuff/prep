// ReSharper disable InconsistentNaming
using System;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using ShopList.Model;

namespace ShopList.Test
{
    public class FileRepositoryTests2
    {
        public class concern : Observes<FileShoppingListRepository>
        {
            Establish c = () =>
                {
                    _list = an<IShoppingList>();
                    _id = Guid.NewGuid();
                    _list.Id = _id;
                    _formattedListId = _list.Id.ToString("N").ToUpper();
                };

            public static IShoppingList _list;
            public static string _formattedListId;
            public static Guid _id;
        }

        public class when_saving_to_repository : concern
        {
            Because b = () => sut.Add(_list);

            It should_use_the_list_id_to_form_the_file_name = () =>
                the_dependency<IFileSystem>().received(fs => fs.Save(_formattedListId, null));
        }

        public class when_loading_from_repository : concern
        {
            Because b = () => { _result = sut.Get(_id); };

            It should_use_the_id_to_form_the_file_name = () =>
                the_dependency<IFileSystem>().received(fs => fs.Load(_formattedListId));

            static IShoppingList _result;
        }
    }
}