using MediatR;

namespace BuildinBlocks.CQRS
{
    public interface ICommand : ICommand<Unit>
    {

    }



    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
