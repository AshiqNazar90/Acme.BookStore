using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.UserTypes
{
   
public class UserTypeDto : FullAuditedEntityDto<Guid>
    {

    public string Name { get; set; }
    public string Code { get; set; }
    public bool Active { get; set; }
}
}
