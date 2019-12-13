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
            Action meinDeleAlsActionAno = delegate () { Console.WriteLine("Hallooo"); };
            Action meinDeleAlsActionAno2 = () => { Console.WriteLine("Hallooo"); };
            Action meinDeleAlsActionAno3 = () => Console.WriteLine("Hallooo");

            DelegateMitParameter meinDeleMitPara = MethodeMitPara;
            Action<string> meinDeletMitParaAlsAction = MethodeMitPara;
            Action<string> meinDeleMitParaAno = (string txt) => { Console.WriteLine(txt); };
            Action<string> meinDeleMitParaAno2 = (txt) => Console.WriteLine(txt);
            Action<string> meinDeleMitParaAno3 = x => Console.WriteLine(x);

            CalcDelegate calc = Minus;
            Func<int, int, long> calcAlsFunc = Sum;
            CalcDelegate calcAno = (int a, int b) => { return a + b; };
            CalcDelegate calcAno2 = (a, b) => { return a + b; };
            CalcDelegate calcAno3 = (a, b) => a + b;

            long result = calc.Invoke(3, 4);

            List<string> texte = new List<string>();
            List<string> nurB = texte.Where(x => x.StartsWith("b")).ToList();
            List<string> nurB2 = texte.Where(Filter).ToList();

            foreach (var item in texte)
            {
             //   if(item.StartsWith("b"))
                    //...
            }
        }

        private bool Filter(string arg)
        {
            if (arg.StartsWith("b"))
                return true;
            else
                return false;
        }

        private int myVar;

        public int MyProperty
        {
            get => myVar;
            set => myVar = value;
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
