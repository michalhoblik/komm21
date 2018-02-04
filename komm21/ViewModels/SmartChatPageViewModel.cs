using komm21.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace komm21.ViewModels
{
    public class SmartChatPageViewModel : BaseViewModel
    {
        private string _outgoingText = string.Empty;

        public ObservableCollection<Message> Messages { get; }

        public ICommand SendCommand { get; set; }

        public string OutGoingText
        {
            get => _outgoingText;
            set => SetProperty(ref _outgoingText, value);
        }

        public SmartChatPageViewModel()
        {
            Messages = new ObservableCollection<Message>();
            InitializeMock();
            SendCommand = new Command(SendMessage);
        }

        public void InitializeMock()
        {
            Messages.Add(new Message { Text = "Hi Squirrel! \uD83D\uDE0A", IsIncoming = true, MessageDateTime = DateTime.Now.AddMinutes(-25) });
            Messages.Add(new Message { Text = "Hi Baboon, How are you? \uD83D\uDE0A", IsIncoming = false, MessageDateTime = DateTime.Now.AddMinutes(-24) });
            Messages.Add(new Message { Text = "We've a party at Mandrill's. Would you like to join? We would love to have you there! \uD83D\uDE01", IsIncoming = true, MessageDateTime = DateTime.Now.AddMinutes(-23) });
            Messages.Add(new Message { Text = "You will love it. Don't miss.", IsIncoming = true, MessageDateTime = DateTime.Now.AddMinutes(-23) });
            Messages.Add(new Message { Text = "Sounds like a plan. \uD83D\uDE0E", IsIncoming = false, MessageDateTime = DateTime.Now.AddMinutes(-23) });
            Messages.Add(new Message { Text = "\uD83D\uDE48 \uD83D\uDE49 \uD83D\uDE49", IsIncoming = false, MessageDateTime = DateTime.Now.AddMinutes(-23) });
        }

        private void SendMessage(object obj)
        {
            var message = new Message
            {
                Text = OutGoingText,
                IsIncoming = false,
                MessageDateTime = DateTime.Now
            };

            Messages.Add(message);

            // TODO: send message

            OutGoingText = string.Empty;
        }
    }
}
