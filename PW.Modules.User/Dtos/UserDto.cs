using AutoMapper;
using PW.Modules.Base.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.User.Dtos
{
    [AutoMap(typeof(User), ReverseMap = true)]
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
    }
}
