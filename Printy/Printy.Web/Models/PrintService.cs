using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Models {
    public class PrintService {
        public int Id { get; set; }
        public PrintSize PrintSize { get; set; }
        public PrintColor PrintColor { get; set; }
        public PrintMaterial PrintMaterial { get; set; }
        public decimal Price { get; set; }
    }
    public enum PrintMaterial {
        Error = 0,
        StandardPaper = 1,
        BoldPaper = 2,
    }
	public enum PrintColor {
		Error = 0,
		BlackAndWhite = 1,
		Colored = 2
	}
	public enum PrintSize {
        Error = 0,
		A1 = 1,
		A2 = 2,
		A3 = 3,
		A4 = 4,
        A5 = 5,
	}
}
