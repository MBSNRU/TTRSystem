using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class PaymentLogic : IPaymentLogic
    {
        private readonly IPaymentRepo repo;

        public PaymentLogic(IPaymentRepo repo)
        {
            this.repo = repo;
        }
        public bool DeletePayment(int id)
        {
            return repo.DeletePayment(id);
        }

        public Payment GetPaymentById(int id)
        {
            return repo.GetPaymentById(id);
        }

        public List<Payment> GetPaymentList()
        {
           return repo.GetPaymentList();
        }

        public bool InsertPayment(Payment payment)
        {
            return repo.InsertPayment(payment);
        }

        public bool UpdatePayment(Payment payment)
        {
            return repo.UpdatePayment(payment);
        }
    }
}
