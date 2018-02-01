using System;

namespace komm21.Models
{
    public class Message
    {
        public string Text
        {
            get;
            set;
        }

        //string text;

        //public string Text
        //{
        //    get { return text; }
        //    set { SetProperty(ref text, value); }
        //}

        public DateTime MessageDateTime
        {
            get;
            set;
        }

        //DateTime messageDateTime;

        //public DateTime MessageDateTime
        //{
        //    get { return messageDateTime; }
        //    set { SetProperty(ref messageDateTime, value); }
        //}

        public string MessageTimeDisplay => MessageDateTime.ToString();

        public bool IsIncoming
        {
            get;
            set;
        }

        //bool isIncoming;

        //public bool IsIncoming
        //{
        //    get { return isIncoming; }
        //    set { SetProperty(ref isIncoming, value); }
        //}

        string attachementUrl;

        public string AttachmentUrl
        {
            get { return attachementUrl; }
            set { attachementUrl = value; }
        }

        public bool HasAttachement => !string.IsNullOrEmpty(attachementUrl);

        //public string AttachementUrl
        //{
        //    get { return attachementUrl; }
        //    set { SetProperty(ref attachementUrl, value); }
        //}
    }
}
