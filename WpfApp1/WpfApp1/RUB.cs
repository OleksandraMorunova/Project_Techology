using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1 {
    /// <summary>
    /// Конвертування в рублі.
    /// </summary>
    class RUB {
        public static string RUBroz(double result) {
        string Rubroz = Math.Round(result / 0.4, 2).ToString();
        return Rubroz;
        }
        public static string RUBpov(double invoice) {
        string Rubpov = Math.Round(invoice / 0.4, 2).ToString();
        return Rubpov;
        }
    }
}
