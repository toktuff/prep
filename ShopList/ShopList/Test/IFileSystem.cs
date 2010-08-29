using System.IO;

namespace ShopList.Test
{
    public interface IFileSystem
    {
        void Save(string name, Stream data);
        Stream Load(string name);
    }
}