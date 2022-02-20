using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _4RTools.Utils
{
    public static class KeyboardHook
    {
        #region interop
        //This is the Import for the SetWindowsHookEx function.
        //Use this function to install a thread-specific hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn,
        IntPtr hInstance, int threadId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetModuleHandle(string lpModuleName);

        //This is the Import for the CallNextHookEx function.
        //Use this function to pass the hook information to the next hook procedure in chain.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        //This is the Import for the UnhookWindowsHookEx function.
        //Call this function to uninstall the hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        internal static extern bool UnhookWindowsHookEx(IntPtr idHook);
        #endregion

        public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr hHook = IntPtr.Zero;
        //Delegate that points to the filter function
        private static HookProc hookproc = new HookProc(Filter);

        /// <summary>
        /// Check to see if either Control modifier is active.
        /// </summary>
        public static bool Control = false;
        /// <summary>
        /// Check to see if either Shift modifier is active.
        /// </summary>
        public static bool Shift = false;
        /// <summary>
        /// Check to see if either Alt modifier is active.
        /// </summary>
        public static bool Alt = false;
        /// <summary>
        /// Check to see if either Win modifier is active.
        /// </summary>
        public static bool Win = false;

        /// <summary>
        /// The function prototype for keypresses.
        /// </summary>
        public delegate bool KeyPressed();

        /// <summary>
        /// Keys handled and their callbacks
        /// </summary>
        private static System.Collections.Generic.Dictionary<Keys, KeyPressed> handledKeysDown = new System.Collections.Generic.Dictionary<Keys, KeyPressed>();
        private static System.Collections.Generic.Dictionary<Keys, KeyPressed> handledKeysUp = new System.Collections.Generic.Dictionary<Keys, KeyPressed>();

        /// <summary>
        /// Delegate for handling a key down event.
        /// </summary>
        /// <param name="key">The key that was pressed. Check Control, Shift, Alt, and Win for modifiers.</param>
        /// <returns>True if you want the key to pass through
        /// (be recognized for the app), False if you want it
        /// to be trapped (app never sees it).</returns>
        public delegate bool KeyboardHookHandler(Keys key);

        /// <summary>
        /// Add a HookHandler delegate to this to activate hotkeys.
        /// </summary>
        public static KeyboardHookHandler KeyDown;

        /// <summary>
        /// Keep track of the hook state.
        /// </summary>
        private static bool Enabled;

        /// <summary>
        /// Start the keyboard hook.
        /// </summary>
        /// <returns>True if no exceptions.</returns>
        public static bool Enable()
        {
            if (Enabled == false)
            {
                try
                {
                    using (Process curProcess = Process.GetCurrentProcess())
                    using (ProcessModule curModule = curProcess.MainModule)
                        hHook = SetWindowsHookEx((int)Constants.WH_KEYBOARD_LL, hookproc, GetModuleHandle(curModule.ModuleName), 0);
                    Enabled = true;
                    return true;
                }
                catch
                {
                    Enabled = false;
                    return false;
                }
            }
            else
                return false;
        }
        /// <summary>
        /// Disable keyboard hooking.
        /// </summary>
        /// <returns>True if disabled correctly.</returns>
        public static bool Disable()
        {
            if (Enabled == true)
            {
                try
                {
                    UnhookWindowsHookEx(hHook);
                    Enabled = false;
                    return true;
                }
                catch
                {
                    Enabled = true;
                    return false;
                }
            }
            else
                return false;
        }

        private static IntPtr Filter(int nCode, IntPtr wParam, IntPtr lParam)
        {
            bool result = true;

            if (nCode >= 0)
            {
                if (wParam == (IntPtr)Constants.WM_KEYDOWN_MSG_ID
                    || wParam == (IntPtr)Constants.WM_SYSKEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    if ((Keys)vkCode == Keys.LControlKey ||
                        (Keys)vkCode == Keys.RControlKey)
                        Control = true;
                    else if ((Keys)vkCode == Keys.LShiftKey ||
                        (Keys)vkCode == Keys.RShiftKey)
                        Shift = true;
                    else if ((Keys)vkCode == Keys.RMenu ||
                        (Keys)vkCode == Keys.LMenu)
                        Alt = true;
                    else if ((Keys)vkCode == Keys.RWin ||
                        (Keys)vkCode == Keys.LWin)
                        Win = true;
                    else
                        result = OnKeyDown((Keys)vkCode);
                }
                else if (wParam == (IntPtr)Constants.WM_KEYUP_MSG_ID
                    || wParam == (IntPtr)Constants.WM_SYSKEYUP)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    if ((Keys)vkCode == Keys.LControlKey ||
                        (Keys)vkCode == Keys.RControlKey)
                        Control = false;
                    else if ((Keys)vkCode == Keys.LShiftKey ||
                        (Keys)vkCode == Keys.RShiftKey)
                        Shift = false;
                    else if ((Keys)vkCode == Keys.RMenu ||
                        (Keys)vkCode == Keys.LMenu)
                        Alt = false;
                    else if ((Keys)vkCode == Keys.RWin ||
                        (Keys)vkCode == Keys.LWin)
                        Win = false;
                    else
                        result = OnKeyUp((Keys)vkCode);
                }
            }

            return result ? CallNextHookEx(hHook, nCode, wParam, lParam) : new IntPtr(1);
        }

        /// <summary>
        /// Adds a key down to the hook.
        /// </summary>
        /// <param name="key">The key to be added.</param>
        /// <param name="callback">The function to be called when the key is pressed.</param>
        public static bool AddKeyDown(Keys key, KeyPressed callback)
        {
            KeyDown = null;
            if (!handledKeysDown.ContainsKey(key))
            {
                handledKeysDown.Add(key, callback);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Adds a key up to the hook.
        /// </summary>
        /// <param name="key">The key to be added.</param>
        /// <param name="callback">The function to be called when the key is pressed.</param>
        public static bool AddKeyUp(Keys key, KeyPressed callback)
        {
            if (!handledKeysUp.ContainsKey(key))
            {
                handledKeysUp.Add(key, callback);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// AddKeyDown wrapper
        /// </summary>
        /// <param name="key">The key to be added.</param>
        /// <param name="callback">The function to be called when the key is pressed.</param>
        public static bool Add(Keys key, KeyPressed callback)
        {
            return AddKeyDown(key, callback);
        }

        /// <summary>
        /// Removes a key down from the hook.
        /// </summary>
        /// <param name="key">The key to be removed.</param>
        public static bool RemoveDown(Keys key)
        {
            return handledKeysDown.Remove(key);
        }

        /// <summary>
        /// Removes a key up from the hook.
        /// </summary>
        /// <param name="key">The key to be removed.</param>
        public static bool RemoveUp(Keys key)
        {
            return handledKeysUp.Remove(key);
        }

        /// <summary>
        /// Removes a key from the hook.
        /// </summary>
        /// <param name="key">The key to be removed.</param>
        public static bool Remove(Keys key)
        {
            return RemoveDown(key);
        }

        private static bool OnKeyDown(Keys key)
        {
            if (KeyDown != null)
                return KeyDown(key);
            if (handledKeysDown.ContainsKey(key))
                return handledKeysDown[key]();
            else
                return true;
        }

        private static bool OnKeyUp(Keys key)
        {
            if (handledKeysUp.ContainsKey(key))
                return handledKeysUp[key]();
            else
                return true;
        }

        /// <summary>
        /// Return a string representation of the given key based on current modifiers.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string KeyToString(Keys key)
        {
            return (KeyboardHook.Control ? "Ctrl + " : "") +
                            (KeyboardHook.Alt ? "Alt + " : "") +
                            (KeyboardHook.Shift ? "Shift + " : "") +
                            (KeyboardHook.Win ? "Win + " : "") +
                            key.ToString();
        }
    }
}
