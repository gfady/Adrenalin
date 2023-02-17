using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.New
{
    public class NewCreateDTO
    {
        public DateOnly Date { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
