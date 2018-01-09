using System;
using System.Collections.Generic;

namespace ANH.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatMessageListViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();

        //public static ChatListDesignModel Instance { get { return new ChatListDesignModel(); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {

            //Items = new List<ChatListItemViewModel>();
            //var item = new ChatListItemViewModel();
            //item.Initials = "LM";
            //item.Name = "Luke";
            //item.Message = "This chat app is awesome! I bet it will be fast too";
            //item.ProfilePictureRGB = "3099c5";
            //Items.Add(item);

            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "I'm about to wipe the old server. We need to update the old server to Windows 2016",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "LM",
                    SenderName = "Luke",
                    Message = "Let me know when you message to spin up the new 2016 server",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    SentByMe = true,
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "The new server is up. Go to 192.168.1.1.\r\n Username is admin, password is P8ssw0rd",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                },
            };
        }

        #endregion
    }
}
