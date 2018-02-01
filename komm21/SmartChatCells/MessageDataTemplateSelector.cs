using komm21.Models;
using Xamarin.Forms;

namespace komm21.SmartChatCells
{
    public class MessageDataTemplateSelector : DataTemplateSelector
    {
        readonly DataTemplate incomingDataTemplate;
        readonly DataTemplate outgoingDataTemplate;

        public MessageDataTemplateSelector()
        {
            incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null)
                return null;
            return messageVm.IsIncoming ? incomingDataTemplate : outgoingDataTemplate;
        }
    }
}
