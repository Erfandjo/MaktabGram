using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.BasicInformation
{

    public abstract class BaseEntity
    {

        /// <summary>
        /// شناسه رکورد
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// شناسه کاربر ایجاد کننده رکورد
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// تاریخ ایجاد رکورد
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// شناسه کاربر آخرین ویرایش کننده رکورد
        /// </summary>
        public Guid? ModifyUserId { get; set; }

        /// <summary>
        /// تاریخ آخرین ویرایش رکورد
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// وضعیت حذف (اگر رکورد حذف شده باشد)
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}



