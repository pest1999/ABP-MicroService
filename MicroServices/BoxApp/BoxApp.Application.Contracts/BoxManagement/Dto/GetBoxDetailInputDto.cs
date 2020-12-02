using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BoxApp.BoxManagement.Dto
{
    public class GetBoxDetailInputDto: PagedAndSortedResultRequestDto
    {
        [Required]
        public Guid Pid { get; set; }
    }
}
