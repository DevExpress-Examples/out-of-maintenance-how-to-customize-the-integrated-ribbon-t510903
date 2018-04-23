using DevExpress.Xpf.Core;
using System;
using System.Windows;

namespace IntegratedRibbonCustomization {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void About_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            DXMessageBox.Show("Click!", "Integrated Ribbon Customization", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
