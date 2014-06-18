//Written by Ivan Minno
//Copyright 2014

using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace MPP.AnotherDollar
{
    public partial class View : Window
    {
        private Model model;

        public View()
        {
            model = new Model();
            DataContext = model;

            InitializeComponent();
        }

        

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (model != null)
                model.Dispose();
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)        
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    FrameworkElement parent = (FrameworkElement)textBox.Parent;
                    while (parent != null && parent is IInputElement && !((IInputElement)parent).Focusable)
                    {
                        parent = (FrameworkElement)parent.Parent;
                    }

                    DependencyObject scope = FocusManager.GetFocusScope(textBox);
                    FocusManager.SetFocusedElement(scope, parent as IInputElement);
                }
            }
        }

        
    }
}
