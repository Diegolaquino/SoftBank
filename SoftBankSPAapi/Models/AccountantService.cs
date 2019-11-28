using SoftBankSPAapi.Models.Enum;

namespace SoftBankSPAapi.Models
{
    public class AccountantService
    {
        public int AccountantServiceId { get; set; }

        public string NameService { get; set; }

        public decimal Price { get; set; }

        public TypeServiceAccount TypeService { get; set; }
    }
}