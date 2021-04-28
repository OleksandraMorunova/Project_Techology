using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1 {
    /// <summary>
    /// Конвертування в євро.
    /// </summary>
    class EUR {
        public static string EURroz(double result) {
        string Eurroz = Math.Round(result / 33, 2).ToString();
        return Eurroz;
        }
        public static string EURpov(double invoice) {
        string Eurpov = Math.Round(invoice / 33, 2).ToString();
        return Eurpov;
        }
    }
}
