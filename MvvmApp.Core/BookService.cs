using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Core
{
    public class BookService : IBookService
    {
        private const string Url = "http://xam150.azurewebsites.net/api/books/";
        private string authKey;

        public async Task<IEnumerable<Book>> GetAll()
        {
            var httpClient = await GetClient();
            var jsonResult = await httpClient.GetStringAsync(Url);

            return JsonConvert.DeserializeObject<IEnumerable<Book>>(jsonResult);
        }

        public async Task<Book> Add(string title, string author, string genre)
        {
            var book = new Book()
            {
                Authors = new List<string>() { author },
                Genre = genre,
                Title = title,
                PublishDate = DateTime.Now
            };

            var client = await GetClient();

            var content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");

            var result = await client.PostAsync(Url, content);

            var contentPostResult = JsonConvert.DeserializeObject<ContentPostResult<Book>>(await result.Content.ReadAsStringAsync());

            if (contentPostResult.isSuccessStatusCode)
                return book;

            return null;
        }

        public async Task Update(Book book)
        {
            var client = await GetClient();
            var content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            await client.PutAsync(Url + book.ISBN, content);
        }

        public async Task Delete(string isbn)
        {
            var client = await GetClient();
            await client.DeleteAsync(Url + isbn);
        }

        public async Task<Book> GetBookById(string isbn)
        {
            var client = await GetClient();
            var jsonResult = await client.GetStringAsync(Url + isbn);

            return JsonConvert.DeserializeObject<Book>(jsonResult);
        }

        private async Task<HttpClient> GetClient()
        {
            var httpClient = new HttpClient();

            if (string.IsNullOrEmpty(authKey))
            {
                var result = await httpClient.GetStringAsync(Url + "login");
                authKey = JsonConvert.DeserializeObject<string>(result);
            }

            httpClient.DefaultRequestHeaders.Add("Authorization", authKey);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            return httpClient;
        }

    }
}
