Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace IntegratedRibbonCustomization
    #Region "#SourceHelper"
    Public NotInheritable Class SourceHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDocumentSource() As String
            Return "Grimm.docx"
        End Function
    End Class
    #End Region ' #SourceHelper
End Namespace
