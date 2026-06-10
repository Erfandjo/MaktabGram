using MaktabGram.Domain.BasicInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Domain.UserEntities
{
    public class UserBlock : BaseEntity
    {

        #region Properties

        /// <summary>
        /// شناسه کاربری که عمل بلاک را انجام داده است
        /// </summary>
        public Guid BlockerUserId { get; set; }

        /// <summary>
        /// شناسه کاربری که بلاک شده است
        /// </summary>
        public Guid BlockedUserId { get; set; }

        #endregion

    }
}
