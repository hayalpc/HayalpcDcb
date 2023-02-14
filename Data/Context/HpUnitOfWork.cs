using Hayalpc.Library.Repository;

namespace Hayalpc.Dcb.Data
{
    public class HpUnitOfWork : HpUnitOfWork<HpDbContext>
    {
        public HpUnitOfWork(HpDbContext context) : base(context)
        {
        }
    }
}
