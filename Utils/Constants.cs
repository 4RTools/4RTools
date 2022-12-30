using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4RTools.Utils
{
    internal class Constants
    {
        public const int WM_HOTKEY_MSG_ID = 0x0312;
        public const int WM_KEYUP_MSG_ID = 0x0101;
        public const int WM_KEYDOWN_MSG_ID = 0x0100;
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_SYSKEYDOWN = 0x0104;
        public const int WM_SYSKEYUP = 0x0105;
        public const int WH_KEYBOARD_LL = 13;

        public const int MINIMUM_HP_TO_RECOVER = 20;
        public const int MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK = 1;
        public const int MAX_BUFF_LIST_INDEX_SIZE = 100;

        public const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const uint MOUSEEVENTF_LEFTUP = 0x0004;
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;
        public const int VK_SHIFT = 0x10;
    }
}
