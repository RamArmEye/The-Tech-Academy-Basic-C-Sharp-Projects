using static System.Net.Mime.MediaTypeNames;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System;

Check for errors : using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class InvisibleLock : Form
{
    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    private const int WH_KEYBOARD_LL = 13;
    private const int WH_MOUSE_LL = 14;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_LBUTTONDOWN = 0x0201;
    private static IntPtr _keyboardHook = IntPtr.Zero;
    private static IntPtr _mouseHook = IntPtr.Zero;
    private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    public InvisibleLock()
    {
        // Create a transparent fullscreen form
        FormBorderStyle = FormBorderStyle.None;
        WindowState = FormWindowState.Maximized;
        TopMost = true;
        Opacity = 0.01; // Almost invisible
        ShowInTaskbar = false;

        // Block keyboard/mouse input globally
        _keyboardHook = SetHook(WH_KEYBOARD_LL, KeyboardHookProc);
        _mouseHook = SetHook(WH_MOUSE_LL, MouseHookProc);

        // Password prompt setup
        var passwordBox = new TextBox { PasswordChar = '*' };
        var btn = new Button { Text = "Unlock" };
        btn.Click += (sender, args) =>
        {
            if (passwordBox.Text == "secret") // Replace with secure validation
            {
                UnhookWindowsHookEx(_keyboardHook);
                UnhookWindowsHookEx(_mouseHook);
                Application.Exit();
            }
        };

        // Hidden until triggered (e.g., via secret key combo)
        var panel = new Panel { Visible = false };
        panel.Controls.Add(passwordBox);
        panel.Controls.Add(btn);
        Controls.Add(panel);

        // Example: Show panel on Ctrl+Alt+L
        KeyPreview = true;
        KeyDown += (sender, e) =>
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.L)
                panel.Visible = true;
        };
    }

    private static IntPtr SetHook(int hookType, HookProc proc)
    {
        using (var curModule = System.Diagnostics.Process.GetCurrentProcess().MainModule)
            return SetWindowsHookEx(hookType, proc, GetModuleHandle(curModule.ModuleName), 0);
    }

    private static IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        // Block all keyboard input except for the unlock trigger
        return (IntPtr)1; // Suppress input
    }

    private static IntPtr MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        // Block all mouse input
        return (IntPtr)1; // Suppress input
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new InvisibleLock());
    }
}