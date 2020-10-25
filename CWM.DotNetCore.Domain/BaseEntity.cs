using System;

namespace CWM.DotNetCore.Domain
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
