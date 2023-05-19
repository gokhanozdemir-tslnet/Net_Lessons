namespace Lesson010_HttpClient.SericeContracts
{
    public interface ITodoService
    {
        Dictionary<string, object> GetTodos(string id);
    }
}
