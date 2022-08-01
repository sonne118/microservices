using MicroCourier.Web.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroCourier.Web.RESTClients
{
    public interface IPaymentAPI
    {    
        Task<string> CreatedPayment(PaymentDTO payment);
    }
}
