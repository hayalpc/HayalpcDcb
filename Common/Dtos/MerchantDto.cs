
namespace Hayalpc.Dcb.Common.Dtos
{
    public class MerchantDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long CountryId { get; set; }
        public long CityId { get; set; }
        public long? DistrictId { get; set; }
        public string TaxNo { get; set; }
        public string TaxOffice { get; set; }
        public string Iban { get; set; }
        public string AccountName { get; set; }
        public string ActivityArea { get; set; }
        public string AuthorizedPersonName { get; set; }
        public string AuthorizedPersonPhone { get; set; }
        public string AuthorizedPersonTckn { get; set; }
        public string PrivateKey { get; set; }
        public string CommercialTitle { get; set; }
        public string CommercialRegistryNo { get; set; }
        public string WebSite { get; set; }
        public string BusinessDesc { get; set; }
    }
}