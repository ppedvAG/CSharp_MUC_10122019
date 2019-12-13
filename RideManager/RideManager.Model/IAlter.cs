using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideManager.Model
{
    public interface IAlter
    {
        int MindestAlter { get; }

        bool AlterPrüfen(DateTime alter);
    }
}
