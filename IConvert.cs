using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal interface IConvert
    {
        double Mult { get; set; }       // 倍率屬性
        void Convert(double value);     // 換算長度的方法原型
    }
}
