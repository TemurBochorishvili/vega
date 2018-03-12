using System.Threading.Tasks;

namespace Test.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}