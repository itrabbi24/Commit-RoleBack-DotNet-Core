using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Models
{
    public class TestModel
    {
            [Key]
            public int SL { get; set; }

            //[MaxLength(12)]
            [Required(ErrorMessage = "This feils is requird.")]
            [DisplayName("Account Number")]
            [Column(TypeName = "Nvarchar(12)")]
            public string AccountNumber { get; set; }
        }
}
