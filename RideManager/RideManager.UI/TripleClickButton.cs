using System.Windows.Forms;

namespace RideManager.UI
{
    public delegate void TripleClickEventHandler(int clickCount);

    public class TripleClickButton : Button
    {
        public event TripleClickEventHandler TripleClick;

        public TripleClickButton()
        {
            Click += TripleClickButton_Click;
        }
        int count = 0;
        private void TripleClickButton_Click(object sender, System.EventArgs e)
        {
            count++;
            if (count % 3 == 0)
            {
                OnTripleClick(count); //rise event
            }
        }

        protected virtual void OnTripleClick(int count)
        {
            TripleClick(count); //rise event
        }
    }

    public class MyTri : TripleClickButton
    {
        public MyTri()
        {
            OnTripleClick(5);
        }
    }
}
