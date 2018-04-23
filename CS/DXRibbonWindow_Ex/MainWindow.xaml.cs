// Developer Express Code Central Example:
// How to create a DXRibbonWindow
// 
// This example shows how to create a DXRibbonWindow and add a RibbonControl to the
// window.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2186

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;

namespace DXRibbonWindow_Ex {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }
    }
}
