using System;
using NUnit.Framework;
using Rhino.Mocks;
using ShopList.Model;

namespace ShopList.Test
{
    [TestFixture]
    public class FileRepositoryTests 
    {

        MockRepository _mockery;
        IFileSystem _mockFileSystem;
        IShoppingList _mockShoppingList;
        Guid _id;
        string _nameCorrespondingToId;

        [SetUp]
        public void SetUp()
        {
            _mockery = new MockRepository();
            _mockFileSystem = _mockery.DynamicMock<IFileSystem>();
            _mockShoppingList = _mockery.DynamicMock<IShoppingList>();
            _id = Guid.NewGuid();
            _nameCorrespondingToId = _id.ToString("N").ToUpper();

            _mockShoppingList.Stub(x => x.Id).Return(_id);
        }



        [Test]
        public void Should_use_backing_filesystem_when_saving_ShoppingLists()
        {
            using(_mockery.Record())
            {
                _mockFileSystem.Expect(fs => fs.Save(_nameCorrespondingToId, null));
            }

            using(_mockery.Playback())
            {
                var repository = CreateSUT();
                repository.Add(_mockShoppingList);
            }
        }

        [Test]
        public void Should_use_backing_filesystem_when_loading_shopping_list()
        {
            using (_mockery.Record())
            {
                Expect.Call(_mockFileSystem.Load(_nameCorrespondingToId)).Return(null);
            }

            using (_mockery.Playback())
            {
                var sut = CreateSUT();
                var shoppingList = sut.Get(_id);
                Assert.IsNotNull(shoppingList);
            }
            
        }

        FileShoppingListRepository CreateSUT()
        {
            return new FileShoppingListRepository(_mockFileSystem);
        }

    }
}