using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface IPaymentRepo
    {
        List<Payment> GetPaymentList();
        Payment GetPaymentById(int id);

        bool InsertPayment(Payment payment);
        bool UpdatePayment(Payment payment);
        bool DeletePayment(int id);
    }
}
