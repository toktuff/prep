using System;
using ShopList.Test;

namespace ShopList.Model
{
    public class FileShoppingListRepository
    {
        readonly IFileSystem _fileSystem;

        public FileShoppingListRepository(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void Add(IShoppingList list)
        {
         //   _fileSystem.Save(list.Id.ToString("N"), new MemoryStream());
            _fileSystem.Save(list.Id.ToString("N").ToUpper(), null);
        }

        public IShoppingList Get(Guid id)
        {
            _fileSystem.Load(id.ToString("N").ToUpper());
            return new ShoppingList
                       {
                           Id = id
                       };
        }
    }
}