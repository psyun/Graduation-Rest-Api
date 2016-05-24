using System;
using System.Data.Entity;

namespace HDO2O.Infranstructure
{
    public interface IDbContextFactory<TContext> : IDisposable where TContext : DbContext
    {
        TContext GetContext();
    }
}
