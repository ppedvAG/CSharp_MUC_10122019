using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideManager.Model
{

    delegate void EinfacheDelegate();
    delegate void DelegateMitParameter(string text);
    delegate long CalcDelegate(int a, int b);

    class HalloDelegate
    {
        public HalloDelegate()
        {
            EinfacheDelegate meineDelegate = EinfacheMethode;
            Action meinDeleAlsAction = EinfacheMethode;

            DelegateMitParameter meinDeleMitPara = MethodeMitPara;
            Action<string> meinDeletMitParaAlsAction = MethodeMitPara;

            CalcDelegate calc = Minus;
            Func<int, int, long> calcAlsFunc= Sum;

            long result = calc.Invoke(3, 4);
        }

        private long Minus(int a, int b)
        {
            return a - b;
        }

        private long Sum(int a, int b)
        {
            return a + b;
        }

        public void MethodeMitPara(string bla)
        {
            Console.WriteLine("Hallo" + bla);
        }
        public void EinfacheMethode()
        {
            Console.WriteLine("Hallo");
        }
    }
}
