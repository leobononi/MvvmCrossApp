using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmApp.Core.ViewModels
{
    [Preserve(AllMembers = true)]
    public class BookListViewModel : MvxViewModel
    {
        private readonly IBookService _bookManager;

        public IMvxCommand ShowCommand { get; private set; }


        private MvxObservableCollection<Book> _bookList;

        public MvxObservableCollection<Book> BookList
        {
            get
            {
                return _bookList ?? (_bookList = new MvxObservableCollection<Book>());
            }
            set
            {
                _bookList = value;
                RaisePropertyChanged(() => BookList);
            }
        }

        public BookListViewModel(IBookService bookManager)
        {
            _bookManager = bookManager;

            FetchData((data) =>
            {
                BookList = new MvxObservableCollection<Book>(data);
            });

            ShowCommand = new MvxCommand<Book>((b) => { ShowViewModel<BookInfoDetailsViewModel>(new { isbn = b.ISBN }); });
        }

        private void FetchData(Action<IEnumerable<Book>> callback)
        {
            Task.Run(() =>
            {
                var config = new ProgressDialogConfig()
                .SetTitle("Carregando")
                .SetMaskType(MaskType.None)
                .SetIsDeterministic(false);

                using (Mvx.Resolve<IUserDialogs>().Progress(config))
                {
                    return _bookManager.GetAll();
                }
            }).ContinueWith((data) =>
            {
                callback(data.Result);
            });
        }
    }
}
