using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities.Base
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
