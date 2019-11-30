using SoftBankSPAapi.Models.Enum;

namespace SoftBankSPAapi.Models
{
    public class AccountProduct
    {
        public int AccountProductId { get; set; }

        public string NameService { get; set; }

        public decimal Price { get; set; }

        public TypeServiceAccount TypeService { get; set; }
    }
}