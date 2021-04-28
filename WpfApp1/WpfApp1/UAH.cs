using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1 {
    /// <summary>
    /// Звичайне виведення спільного та роздільного рахунку.
    /// </summary>
    class UAH {
        public static string UAH_NewResult(double result) {
        string NewResult = Math.Round(result, 2).ToString();
        return NewResult;
        }
        public static string UAH_Result(double invoice) {
        string Result = invoice.ToString();
        return Result;
        }
    }
}
