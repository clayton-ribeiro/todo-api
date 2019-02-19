namespace I4Pro.Todo.Shared.Commands
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
