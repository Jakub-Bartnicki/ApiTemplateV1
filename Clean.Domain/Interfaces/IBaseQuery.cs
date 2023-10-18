using MediatR;

namespace Clean.Domain.Interfaces
{
    public interface IBaseQuery : IRequest<IRequestDto>
    { }
}
