using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Departments
{
    public class CreateUpdateDepartmentDto
    {
        [Required]
        [StringLength (12)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
