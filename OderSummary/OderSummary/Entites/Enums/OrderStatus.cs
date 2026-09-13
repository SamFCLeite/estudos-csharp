using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderSummary.Entites.Enums {
    //STATUS DO PEDIDO
    enum OrderStatus : int {
        PENDING_PAYMENT,
        PROCESSING,
        SHIPPED,
        DELIVERED
    }
}
