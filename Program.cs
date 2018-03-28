using System;
using System.Windows.Forms;

namespace PasteClip {
    class Program {
        [STAThread]
        static void Main (string[] args) {
            if (Clipboard.ContainsText()) {
                Console.Write (Clipboard.GetText ());                
            }
        }
    }
}
