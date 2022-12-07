using System;
using System.Collections.Generic;

namespace WareHouseManagementAPI.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? WarehouseName { get; set; }

    public string? ProductName { get; set; }

    public string? Manufacturer { get; set; }

    public string? ProductDescription { get; set; }

    public long? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? Image { get; set; }
}
