using System.ComponentModel.DataAnnotations.Schema;

namespace Printy.Web.Models {
    public class UserOrder {
        public int? Id { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        [ForeignKey("Printer")]
        public int? PrinterId { get; set; }
        public string UserFile { get; set; }
        public int FileCopies { get; set; }
    }
}
