using MaktabGram.Domain.BasicInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.UserEntities
{
    public class UserProfile : BaseEntity
    {

        #region Properties

        /// <summary>
        /// شناسه کاربر مرتبط با این پروفایل
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// نام نمایشی کاربر
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// توضیحات یا بیوگرافی کاربر
        /// </summary>
        public string? Bio { get; set; }

        /// <summary>
        /// مسیر یا آدرس تصویر پروفایل
        /// </summary>
        public string? ProfileImage { get; set; }

        /// <summary>
        /// تاریخ تولد کاربر
        /// </summary>
        public DateTime? DateBirth { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// کاربر مرتبط با این پروفایل
        /// </summary>
        public User User { get; set; }

        #endregion

    }
}
