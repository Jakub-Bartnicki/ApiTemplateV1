using Clean.Domain.Interfaces;
using MediatR;

namespace Clean.Domain.Base
{
    public class BaseQuery : IBaseQuery
    {
        public Guid? UserId { get; set; }

        internal class BaseQueryHandler : IRequestHandler<IBaseQuery, IRequestDto>
        {
            public Task<IRequestDto> Handle(IBaseQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
