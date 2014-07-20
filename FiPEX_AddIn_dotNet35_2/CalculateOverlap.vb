Public Class CalculateOverlap
    Inherits ESRI.ArcGIS.Desktop.AddIns.Button
    Private m_FiPEx__1 As FishPassageExtension

  Public Sub New()

  End Sub

  Protected Overrides Sub OnClick()
        My.ArcMap.Application.CurrentTool = Nothing
        If m_FiPEx__1 Is Nothing Then
            m_FiPEx__1 = FiPEX_AddIn_dotNet35_v10_23.FishPassageExtension.GetExtension()
        End If
        Using MyForm As New FiPEX_AddIn_dotNet35_v10_23.frmCalculateOverlap
            If MyForm.Form_Initialize(My.ArcMap.Application) Then
                MyForm.ShowDialog()
            End If
        End Using
    End Sub

    Protected Overrides Sub OnUpdate()
        If m_FiPEx__1 Is Nothing Then
            m_FiPEx__1 = FiPEX_AddIn_dotNet35_v10_23.FishPassageExtension.GetExtension()
        End If
    End Sub
End Class
