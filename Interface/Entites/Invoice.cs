using System.Globalization;

namespace Interface.Entites {
    internal class Invoice {

        public double BasicPayment { get; set; }

        public double tax { get; set; }

        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            this.tax = tax;
        }

        public double TotalPayment { 
            get { return BasicPayment + tax; }
        }

        public override string ToString() {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nTax: " + tax.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nTotal payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
