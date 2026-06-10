using MaktabGram.Domain.BasicInformation;
using MaktabGram.Domain.ChatMemmberEntities;
using MaktabGram.Domain.Common.Enum;
using MaktabGram.Domain.MessageEntities;
using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.ChatEntities
{
    public class Chat : BaseEntity
    {
        #region Properties

        /// <summary>
        /// عنوان چت، گروه یا کانال
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// شناسه کاربر ایجاد کننده چت
        /// </summary>
        public Guid CreatedByUserId { get; set; }

        /// <summary>
        /// نوع چت
        /// </summary>
        public ChatTypeEnum Type { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// کاربر ایجاد کننده چت
        /// </summary>
        public User CreatedByUser { get; set; } = null!;

        /// <summary>
        /// لیست اعضای چت
        /// </summary>
        public List<ChatMember> ChatMembers { get; set; } = new();

        /// <summary>
        /// لیست پیام‌های این چت
        /// </summary>
        public List<Message> Messages { get; set; } = new();

        #endregion

    }
}
