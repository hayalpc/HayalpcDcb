using Hayalpc.Dcb.Data.Models;
using Hayalpc.Library.Common.Results;
using System;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IBlobFileService : IBaseService<BlobFile>
    {
        IDataResult<BlobFile> GetByGuid(Guid guid);
    }
}
