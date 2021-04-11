using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Forum.ViewsModels
{
    public class ContaRegistrarViewModel
    {
        [Required]        
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
