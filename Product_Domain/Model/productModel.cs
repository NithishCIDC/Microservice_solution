using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Domain.Model;

public class productModel
{
    public int productId { get; set; }

    public string? productName { get; set; }

    public string? productCompany { get; set; }

    public decimal? productPrice { get; set; }

    public decimal? productQuantity { get; set; }

    public int productDiscount { get; set; }

    public int customerId { get; set; }
}

