using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using System.Linq;

namespace MvvmApp.Core.ViewModels
{
    public class BookDetailsViewModel : MvxViewModel
    {

        public Book Book { get; private set; }

        public string Author { get; private set; }

        public void Init(string jsonBook)
        {
            Book = JsonConvert.DeserializeObject<Book>(jsonBook);
            Author = Book.Authors.First();
        }
    }
}
