using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WareHouseManagementAPI.Models;

public partial class UserDetail
{
    [Key]
    public int Id { get; set; }

    //[Required(ErrorMessage = "Enter First Name")]
    //[RegularExpression(@"^([A-Za-z]+)$")]
    public string? Firstname { get; set; }

    //[Required(ErrorMessage = "Enter Last Name")]
    //[RegularExpression(@"^([A-Za-z]+)$")]
    public string? Lastname { get; set; }

    [Required(ErrorMessage = "Enter Username")]
    public string? Username { get; set; }

   // [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter Valid Email")]
    [DataType(DataType.EmailAddress)]
    public string? Useremail { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(10)]
    public string? Password { get; set; }


    // [Required]
    public string? Address { get; set; }



    public string? Landmark { get; set; }


    // [Required]
    public string? City { get; set; }


    // [Required]
    public string? State { get; set; }


    // [Required]
    public string? Country { get; set; }


    //  [Required]
  //  [DataType(DataType.PostalCode)]
    public string? Pincode { get; set; }


    // [Required]
  //  [DataType(DataType.PhoneNumber)]
    public long? MobileNumber { get; set; }

    public bool? IsActive { get; set; }


}
