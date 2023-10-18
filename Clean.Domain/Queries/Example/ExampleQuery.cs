using Clean.Api.Dto.Responses;
using MediatR;

namespace Clean.Domain.Queries.Example
{
    public class ExampleQuery : IRequest<ExampleResponse>
    {
        internal class ExampleQueryHandler : IRequestHandler<ExampleQuery, ExampleResponse>
        {
            public Task<ExampleResponse> Handle(ExampleQuery request, CancellationToken ct)
            {
                throw new NotImplementedException();
            }
        }
    }
}
