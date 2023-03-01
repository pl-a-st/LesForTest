using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("UnitTest")]
namespace LesForTest {
    internal class AbstractClass {
        internal int Sum(int value1, int value2) {
            return value1 + value2;
        }
    }
}
