namespace Lesson010_HttpClient.SericeContracts
{
    public interface ITodoService
    {
        async Task<Dictionary<string, object>> GetTodos(string id);
    }
}
