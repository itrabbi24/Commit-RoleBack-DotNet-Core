using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionID { get; set; }

        //[MaxLength(12)]
        [Required(ErrorMessage ="This feils is requird.")]
        [DisplayName("Account Number")]
        [Column(TypeName ="Nvarchar(12)")]
        public string AccountNumber { get; set; }


        [Required(ErrorMessage = "This feils is requird.")]
        [DisplayName("Account Name")]
        [Column(TypeName = "Nvarchar(100)")]
        public string BeneficiaryName { get; set; }


        [Required(ErrorMessage = "This feils is requird.")]
        [DisplayName("Bank Name")]
        [Column(TypeName = "Nvarchar(100)")]
        public string BankName { get; set; }


        [Required(ErrorMessage = "This feils is requird.")]
        [DisplayName("SWIFT Code")]
        [Column(TypeName = "Nvarchar(11)")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}")]
        public DateTime EntryDate { get; set; }

    }
}
