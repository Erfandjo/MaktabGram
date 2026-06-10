using MaktabGram.Domain.BasicInformation;
using MaktabGram.Domain.ChatEntities;
using MaktabGram.Domain.Common.Enum;
using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.MessageEntities
{
    public class Message : BaseEntity
    {

        #region Properties

        /// <summary>
        /// شناسه چتی که پیام در آن ارسال شده است
        /// </summary>
        public Guid ChatId { get; set; }

        /// <summary>
        /// شناسه کاربری که پیام را ارسال کرده است
        /// </summary>
        public Guid SenderId { get; set; }

        /// <summary>
        /// متن پیام
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// تعداد دفعاتی که این پیام فوروارد شده است
        /// </summary>
        public int ForwardNumber { get; set; }

        /// <summary>
        /// وضعیت ارسال پیام
        /// </summary>
        public StatusMessageEnum StatusMessage { get; set; }

        /// <summary>
        /// مشخص می‌کند که آیا این پیام در پاسخ به پیام دیگری ارسال شده است یا خیر
        /// </summary>
        public bool IsReply { get; set; }

        /// <summary>
        /// شناسه پیامی که این پیام در پاسخ به آن ارسال شده است
        /// </summary>
        public Guid? ReplyToMessageId { get; set; }

        /// <summary>
        /// مشخص می‌کند که آیا این پیام فوروارد شده است یا خیر
        /// </summary>
        public bool IsForward { get; set; }

        /// <summary>
        /// شناسه پیام مبدا که این پیام از آن فوروارد شده است
        /// </summary>
        public Guid? ForwardFromMessageId { get; set; }

        /// <summary>
        /// مشخص می‌کند که آیا متن پیام ویرایش شده است یا خیر
        /// </summary>
        public bool IsEdited { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// چتی که پیام در آن قرار دارد
        /// </summary>
        public Chat Chat { get; set; } = null!;

        /// <summary>
        /// کاربری که پیام را ارسال کرده است
        /// </summary>
        public User Sender { get; set; } = null!;

        /// <summary>
        /// پیام مرجعی که این پیام در پاسخ به آن ارسال شده است
        /// </summary>
        public Message? ReplyToMessage { get; set; }

        /// <summary>
        /// پیام مرجعی که این پیام از روی آن فوروارد شده است
        /// </summary>
        public Message? ForwardFromMessage { get; set; }



        #endregion


    }
}
