
namespace ServicesRepository.HttpHelper
{
    public interface IHttpHelpers
    {
        Task DeleteAsync(string uri, string authToken = "");
        Task<T> GetAsync<T>(string uri, string authToken = "");
        Task<TR> PostAsync<T, TR>(string uri, T data, string authToken = "") where TR : new();
        Task<T> PostAsync<T>(string uri, T data, string authToken = "");
        Task<TR> PutAsync<T, TR>(string uri, T data, string authToken = "") where TR : new();
        Task<T> PutAsync<T>(string uri, T data, string authToken = "");
    }
}