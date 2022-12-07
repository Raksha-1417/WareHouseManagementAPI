using System;
using System.Collections.Generic;

namespace WareHouseManagementAPI.Models;

public partial class UserType
{
    public int Id { get; set; }

    public string? Usertype1 { get; set; }

    public bool? IsActive { get; set; }
}
