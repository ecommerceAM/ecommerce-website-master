using System.Collections.Generic;
using CP.API.Model;

namespace CP.API.Dto
{
    public class ProductReturnDTO
    {

        public int ProductId { get; set; }
        public int ProductNumber { get; set; }
        public string SKU { get; set; }
        public string ProductNameEnglish { get; set; }
        public string ProductNameArabic { get; set; }
        public string ProductDescriptionEnglish { get; set; }
        public string ProductDescriptionArabic { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal VAT { get; set; }
        public decimal AmountOfTheAddedTax { get; set; }
        public decimal PriceAfterTax { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
        public string PhotoURL { get; set; }
        public string SubCategoryName { get; set; }
        public string VendorName { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<PhotoForProduct> Photos { get; set; }


    }
}