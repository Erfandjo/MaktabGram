using MaktabGram.Domain.BasicInformation;
using MaktabGram.Domain.ChatEntities;
using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.ChatMemmberEntities
{
    public class ChatMember : BaseEntity
    {

        #region Properties

        /// <summary>
        /// شناسه چتی که کاربر در آن عضو است
        /// </summary>
        public Guid ChatId { get; set; }

        /// <summary>
        /// شناسه کاربری که عضو چت است
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// مشخص می‌کند که آیا این کاربر در چت ادمین است یا خیر
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// شناسه آخرین پیامی که کاربر در این چت خوانده است
        /// </summary>
        public Guid? LastReadMessageId { get; set; }

        /// <summary>
        /// تاریخ و زمان عضویت کاربر در چت
        /// </summary>
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        #endregion

        #region Relations

        /// <summary>
        /// چتی که این عضویت به آن تعلق دارد
        /// </summary>
        public Chat Chat { get; set; } = null!;

        /// <summary>
        /// کاربری که این عضویت به او تعلق دارد
        /// </summary>
        public User User { get; set; } = null!;

        #endregion

    }
}
