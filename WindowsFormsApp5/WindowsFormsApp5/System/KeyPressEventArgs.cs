

namespace System
{
    internal class KeyPressEventArgs
    {
        private Action<object, Windows.Forms.KeyPressEventArgs> reshit_click;

        public KeyPressEventArgs(Action<object, Windows.Forms.KeyPressEventArgs> reshit_click)
        {
            this.reshit_click = reshit_click;
        }

        public KeyPressEventArgs(Action<object, KeyPressEventArgs> reshit_click1)
        {
        }
    }
}