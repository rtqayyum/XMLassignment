Public Class Form1
    Private xmlDocument As New System.Xml.XmlDocument
    Private ids As System.Xml.XmlNodeList
    Private names As System.Xml.XmlNodeList
    Private gpas As System.Xml.XmlNodeList
    Private id As System.Xml.XmlNode
    Private nm As System.Xml.XmlNode
    Private gpa As System.Xml.XmlNode
    Private count As Integer = 0
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
       
        OpenFileDialog1.ShowDialog()

        xmlDocument.Load(OpenFileDialog1.FileName)
        ids = xmlDocument.GetElementsByTagName("id")
        names = xmlDocument.GetElementsByTagName("name")
        gpas = xmlDocument.GetElementsByTagName("gpa")

        id = ids.ItemOf(count)
        nm = names.ItemOf(count)
        gpa = gpas.ItemOf(count)
        txtID.Text = id.InnerText
        txtName.Text = nm.InnerText
        txtGPA.Text = gpa.InnerText
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        count = 0
        id = ids.ItemOf(count)
        nm = names.ItemOf(count)
        gpa = gpas.ItemOf(count)
        txtID.Text = id.InnerText
        txtName.Text = nm.InnerText
        txtGPA.Text = gpa.InnerText
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        count = ids.Count - 1
        id = ids.ItemOf(count)
        nm = names.ItemOf(count)
        gpa = gpas.ItemOf(count)
        txtID.Text = id.InnerText
        txtName.Text = nm.InnerText
        txtGPA.Text = gpa.InnerText
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        count = count - 1
        If count >= 0 Then
            id = ids.ItemOf(count)
            nm = names.ItemOf(count)
            gpa = gpas.ItemOf(count)
            txtID.Text = id.InnerText
            txtName.Text = nm.InnerText
            txtGPA.Text = gpa.InnerText
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        count = count + 1
        If count < ids.Count Then
            id = ids.ItemOf(count)
            nm = names.ItemOf(count)
            gpa = gpas.ItemOf(count)
            txtID.Text = id.InnerText
            txtName.Text = nm.InnerText
            txtGPA.Text = gpa.InnerText
        End If
    End Sub
End Class
