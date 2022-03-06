using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab_5_1_WpfApp1
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand Open { get; set; }
        public static RoutedUICommand Save { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            inputs.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O"));
            inputs.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));
            Open = new RoutedUICommand("Открыть", "Open", typeof(MyCommands), inputs);
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands), inputs);
            Save = new RoutedUICommand("Сохранить", "Save", typeof(MyCommands), inputs);
        }
    }
}