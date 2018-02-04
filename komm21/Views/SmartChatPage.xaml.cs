using komm21.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace komm21.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmartChatPage : ContentPage
    {
        private readonly SmartChatPageViewModel _viewModel;

        public SmartChatPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SmartChatPageViewModel();

            _viewModel.Messages.CollectionChanged += Messages_CollectionChanged;
        }

        private void Messages_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var target = _viewModel.Messages[_viewModel.Messages.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
        }

        private void MessagesListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        private void MessagesListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }
    }
}