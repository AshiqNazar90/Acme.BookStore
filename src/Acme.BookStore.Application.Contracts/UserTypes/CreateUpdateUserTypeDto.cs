using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.UserTypes
{
    public class CreateUpdateUserTypeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
       
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
    }
}
