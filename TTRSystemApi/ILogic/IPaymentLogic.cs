using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface IPaymentLogic
    {
        List<Payment> GetPaymentList();
        Payment GetPaymentById(int id);

        bool InsertPayment(Payment payment);
        bool UpdatePayment(Payment payment);
        bool DeletePayment(int id);
    }
}
