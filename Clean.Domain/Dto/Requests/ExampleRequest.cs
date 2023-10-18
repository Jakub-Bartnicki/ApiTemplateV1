using Clean.Domain.Interfaces;

namespace Clean.Api.Dto.Requests
{
    public class ExampleRequest : IRequestDto
    {
        public int Foo { get; set; }
    }
}
