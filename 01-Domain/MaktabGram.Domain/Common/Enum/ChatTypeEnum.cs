using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.Common.Enum
{
    public enum ChatTypeEnum
    {
        /// <summary>
        /// چت خصوصی بین دو کاربر
        /// </summary>
        Private = 1,

        /// <summary>
        /// گروه با چند عضو
        /// </summary>
        Group = 2,

        /// <summary>
        /// کانال
        /// </summary>
        Channel = 3
    }
}
