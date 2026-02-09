using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QS.Data.Models.Enums
{
    public enum ApprovalStatus
    {
        [Description("Чакащ одобрение")]
        AwaitingApproval,
        [Description("Одобрен")]
        Approved,
        [Description("Отхвърлен")]
        Rejected
    }
}
