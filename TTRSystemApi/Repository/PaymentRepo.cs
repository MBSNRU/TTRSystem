using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class PaymentRepo : IPaymentRepo
    {
        private readonly TtrsContext dbContext;

        public PaymentRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeletePayment(int id)
        {
            var exi = dbContext.Payments.Where(x=>x.Id == id).FirstOrDefault();
            if (exi == null) { return false; }
            dbContext.Payments.Remove(exi);
            dbContext.SaveChanges();
            return true;
        }

        public Payment GetPaymentById(int id)
        {
            return dbContext.Payments.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Payment> GetPaymentList()
        {
            return dbContext.Payments.ToList();
        }

        public bool InsertPayment(Payment payment)
        {
            dbContext.Payments.Add(payment);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdatePayment(Payment payment)
        {
            var exi = dbContext.Payments.Where(x=>x.Id==payment.Id).FirstOrDefault();
            if (exi == null) { return false; }
            exi.BookingId = payment.BookingId;
            exi.Amount = payment.Amount;
            exi.PaymentDate = payment.PaymentDate;
            exi.TransactionId = payment.TransactionId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
