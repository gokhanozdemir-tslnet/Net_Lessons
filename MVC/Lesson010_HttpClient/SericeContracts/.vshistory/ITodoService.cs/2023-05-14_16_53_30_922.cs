namespace Lesson010_HttpClient.SericeContracts
{
    public interface ITodoService
    {
        Task<Dictionary<string, object>> GetTodos(string id);
    }
}
