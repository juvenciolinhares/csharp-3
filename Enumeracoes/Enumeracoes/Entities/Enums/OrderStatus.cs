

namespace Enumeracoes.Entities.Enums
{
    // é criado dessa forma: internal class OrderStatus, mas devo substituir para:
    enum OrderStatus : int //isso diz que cada valor do orderstatus é um número inteiro
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
