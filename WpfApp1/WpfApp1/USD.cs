using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1{
    /// <summary>
    /// Конвертуванння в долари.
    /// </summary>
    class USD {
        public static string USDroz(double result) {
        string Usdroz = Math.Round(result / 28, 2).ToString();
        return Usdroz;
        }
        public static string USDpov(double invoice) {
        string Usdpov = Math.Round(invoice / 28, 2).ToString();
        return Usdpov;
        }
    }
}
