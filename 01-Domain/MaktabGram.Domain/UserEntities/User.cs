using MaktabGram.Domain.BasicInformation;
using MaktabGram.Domain.ChatMemmberEntities;
using MaktabGram.Domain.MessageEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.UserEntities
{
    public class User : BaseEntity
    {


        #region Properties

        /// <summary>
        /// نام کاربری کاربر
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// رمز عبور هش شده کاربر
        /// </summary>
        public string PasswordHash { get; set; } = null!;

        /// <summary>
        /// شماره تماس کاربر
        /// </summary>
        public string PhoneNumber { get; set; } = null!;

        #endregion

        #region Relations

        /// <summary>
        /// لیست عضویت‌های کاربر در چت‌ها
        /// </summary>
        public List<ChatMember> ChatMembers { get; set; } = new();

        /// <summary>
        /// لیست پیام‌های ارسال شده توسط کاربر
        /// </summary>
        public List<Message> SentMessages { get; set; } = new();

        /// <summary>
        /// پروفایل تکمیلی کاربر
        /// </summary>
        public UserProfile? UserProfile { get; set; }

        #endregion

    }
}
