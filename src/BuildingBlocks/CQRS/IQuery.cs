using MediatR;

namespace BuildinBlocks.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}
