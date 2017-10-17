using System;

namespace Solid.ISP
{
    public interface IProductPersistence
    {
        void Validate();
        void Commit();
    }
}