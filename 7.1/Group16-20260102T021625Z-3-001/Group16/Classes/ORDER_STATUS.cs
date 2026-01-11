using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public enum ORDER_STATUS
    {
        Editable,
        WaitingForSupplierAnswer,
        Canceled,
        Shipped,
        InReceptionArrived,
        InReceptionWithExceptions,
        InReceptionIntact,
        Archive

    }
}

