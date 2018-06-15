using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Threading.Tasks;

namespace MvvmApp.Core.ViewModels
{
    [Preserve(AllMembers = true)]
    public class BookInfoDetailsViewModel : MvxViewModel
    {
        private readonly IBookService _bookManager;

        private Book _book;

        public Book Book
        {
            get { return _book; }
            set { _book = value;  RaisePropertyChanged(() => Book);  }
        }


        public BookInfoDetailsViewModel(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        public void Init(string isbn)
        {
            FetchData((result) => { Book = result; }, isbn);
        }

        private void FetchData(Action<Book> callback, string isbn)
        {
            Task.Run(() =>
            {
                var config = new ProgressDialogConfig()
                .SetTitle("Carregando")
                .SetMaskType(MaskType.None)
                .SetIsDeterministic(false);

                using (Mvx.Resolve<IUserDialogs>().Progress(config))
                {
                    return _bookManager.GetBookById(isbn);
                }
            }).ContinueWith((data) =>
            {
                callback(data.Result);
            });
        }
    }
}
