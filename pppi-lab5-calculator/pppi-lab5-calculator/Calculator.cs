using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppi_lab5_calculator {
	internal class Calculator {
		public double Add(double n, double m) {
			double result = 0;
			// to do
			return n+m;
		}

		public double Substract(double n, double m) {
			double result = 0;
			// to do
			return result;
		}

		public double Multiply(double n, double m) {
			double result = 0;
			// to do
			return n*m;
		}

		public double Divide(double n, double m) {
			return n / m;
		}

		public double Pow(double n, double m) {
			double result = Math.Pow(Convert.ToDouble(n), Convert.ToDouble(m));
			return result;
		}
	}
}
