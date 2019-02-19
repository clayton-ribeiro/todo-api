namespace I4Pro.Todo.Shared.Commands
{
    public interface IComandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
