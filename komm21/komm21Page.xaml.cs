using System;
using komm21.Views;
using Xamarin.Forms;

namespace komm21
{
    public partial class komm21Page : ContentPage
    {
        public komm21Page()
        {
            InitializeComponent();
        }

        private void BtnChatPage_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SmartChatPage());
        }
    }
}
