using Hayalpc.Dcb.Data.Models;
using Hayalpc.Library.Common.Results;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IMerchantPaymentService : IBaseService<MerchantPayment>
    {
        IResult Calculate(long[] merchantIds);
    }
}
