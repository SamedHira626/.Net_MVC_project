//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblRegistration
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter a name")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Enter a surname")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Enter a password which contains 8 symbol, 1 digit, 1 letter")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter a e-mail")]
        public string Email { get; set; }
    }
}