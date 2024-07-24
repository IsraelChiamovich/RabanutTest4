using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabanut.Model
{
    internal record Query(string Day, int DayManth, string Manth, string Year, string Result);
}
