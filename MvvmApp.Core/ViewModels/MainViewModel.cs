using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace MvvmApp.Core.ViewModels
{
    [Preserve(AllMembers = true)]
    public class MainViewModel : MvxViewModel
    {

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; RaisePropertyChanged(() => Text); }
        }

        private MvxCommand _resetTextCommand;

        public MvxCommand ResetTextCommand
        {
            get
            {
                return _resetTextCommand ??
                    (_resetTextCommand = new MvxCommand(() => { Text = string.Empty; }));
            }
        }

        private readonly IBookService _bookManager;
        private readonly IUserDialogs _userDialog;

        private MvxCommand _saveBookCommand;

        public MvxCommand SaveBookCommand
        {
            get
            {
                return _saveBookCommand ?? 
                    (_saveBookCommand = new MvxCommand(async () => { await SaveBookAction(); }));
            }
        }

        private MvxCommand _listBookCommand;

        public MvxCommand ListBookCommand
        {
            get
            {
                return _listBookCommand ?? (_listBookCommand = new MvxCommand(() => { ShowViewModel<BookListViewModel>(); }));
            }
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(() => Title); }
        }

        private string _isbn;

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; RaisePropertyChanged(() => ISBN); }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; RaisePropertyChanged(() => Author); }
        }

        private DateTime _publishDate;

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; RaisePropertyChanged(() => PublishDate); }
        }

        private string _genre;

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; RaisePropertyChanged(() => Genre); }
        }

        public MainViewModel(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        private async Task SaveBookAction()
        {
            var config = new ProgressDialogConfig()
                .SetTitle("Salvando")
                .SetMaskType(MaskType.None)
                .SetIsDeterministic(false);

            using (Mvx.Resolve<IUserDialogs>().Progress(config))
            {
                var addedBook = await _bookManager.Add(_title, _author, _genre);

                if (addedBook != null)
                    ShowViewModel<BookDetailsViewModel>(new { jsonBook = JsonConvert.SerializeObject(addedBook) });
            }

            //using (var dlg = Mvx.Resolve<IUserDialogs>().Progress("Progress (No Cancel)"))
            //{
            //    while (dlg.PercentComplete < 100)
            //    {
            //        var addedBook = await _bookManager.Add(_title, _author, _genre);

            //        //if (addedBook != null)
            //        //    ShowViewModel<BookDetailsViewModel>(new { jsonBook = JsonConvert.SerializeObject(addedBook) });

            //        //dlg.PercentComplete += 20;
            //    }
            //}
        }
    }
}
