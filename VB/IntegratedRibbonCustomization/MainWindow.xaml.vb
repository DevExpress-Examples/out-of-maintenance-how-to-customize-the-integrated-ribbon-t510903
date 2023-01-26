Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace IntegratedRibbonCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub About_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            DXMessageBox.Show("Click!", "Integrated Ribbon Customization", MessageBoxButton.OK, MessageBoxImage.Information)
        End Sub
    End Class
End Namespace
