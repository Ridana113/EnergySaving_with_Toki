using System.Windows.Forms;

namespace System
{
    internal class KeyEventHandler
    {
        private Action<object, KeyPressEventArgs> yess_KeyPress;
        private Action<object, KeyEventArgs> yess_Click;

        public KeyEventHandler(Action<object, KeyPressEventArgs> yess_KeyPress)
        {
            this.yess_KeyPress = yess_KeyPress;
        }

        public KeyEventHandler(Action<object, KeyEventArgs> yess_Click)
        {
            this.yess_Click = yess_Click;
        }
    }
}