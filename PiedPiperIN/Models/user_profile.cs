//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PiedPiperIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user_profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Username required.", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required.", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        public string Profile_Pic { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public byte[] timestamp { get; set; }
        public bool RememberMe { get; set; }
    }
}
