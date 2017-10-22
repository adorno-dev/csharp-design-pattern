using System;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}