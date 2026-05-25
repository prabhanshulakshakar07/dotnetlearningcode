using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWork.Models
{

    [Table("Customer")]
    public class  Customer //POCO class 
    {
        [Key]
        [Column("Id",TypeName ="int")]
        public int CId { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string CName { get; set; }

        [Column("Address", TypeName = "varchar(50)")]
        public string CAddress { get; set; }

        


    }



}
