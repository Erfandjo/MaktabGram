using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.Common.Enum
{
    public enum StatusMessageEnum
    {
        /// <summary>
        /// پیام در انتظار ارسال
        /// </summary>
        Pending = 1,

        /// <summary>
        /// ارسال پیام ناموفق بوده است
        /// </summary>
        Failed = 2,

        /// <summary>
        /// پیام با موفقیت ارسال شده است
        /// </summary>
        Sent = 3
    }
}
