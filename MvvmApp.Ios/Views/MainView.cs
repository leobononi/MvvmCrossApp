using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace MvvmApp.Ios.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();
            set.Bind(TextTitle).To(vm => vm.Title);
            set.Bind(TextGenre).To(vm => vm.Genre);
            set.Bind(TextAuthor).To(vm => vm.Author);
            set.Bind(ButtonSave).To(vm => vm.SaveBookCommand);
            set.Bind(ButtonListBook).To(vm => vm.ListBookCommand);
            set.Apply();
        }
    }
}
