Imports Microsoft.VisualBasic.FileIO
Imports System.Text.RegularExpressions
Public Class Form1

    Private termsFromFiles As New Generic.Dictionary(Of String, SortedSet(Of String))

    Private Sub btnFindOverlappingTerms_Click(sender As System.Object, e As System.EventArgs) Handles btnFindOverlappingTerms.Click
        'Display an error if no files are selected
        If (ofdSelectFiles.FileNames.Length <= 1) Then
            MessageBox.Show("Please select at least 2 files (see step 1) before trying to compare them", "Error: Please Select Files", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Get the go terms from all the files and then store them
        For Each fileName As String In ofdSelectFiles.FileNames
            Dim goTerms As New SortedSet(Of String)
            Dim fileParser As New TextFieldParser(fileName)
            While Not fileParser.EndOfData
                Dim line As String = fileParser.ReadLine.Trim.ToLower
                line = Regex.Replace(line, "\(sensu.+\)", "").Trim
                goTerms.Add(line)
            End While
            termsFromFiles.Add(fileName, goTerms)
        Next
        'Find terms that overlap between all the files
        Dim overlapGoTerms As New SortedSet(Of String)
        overlapGoTerms.UnionWith(termsFromFiles.Item(ofdSelectFiles.FileNames(0)))
        For i As Integer = 1 To ofdSelectFiles.FileNames.Length - 1
            overlapGoTerms.IntersectWith(termsFromFiles.Item(ofdSelectFiles.FileNames(i)))
        Next
        'Find terms that do not overlap between the two files
        Dim nonOverlapGoTerms As New SortedSet(Of String)
        For i As Integer = 0 To ofdSelectFiles.FileNames.Length - 1
            nonOverlapGoTerms.UnionWith(termsFromFiles.Item(ofdSelectFiles.FileNames(i)))
        Next
        nonOverlapGoTerms.ExceptWith(overlapGoTerms) 'All terms except those that intersect
        'Output the overlap results to the overlap results text box
        For Each goTerm As String In overlapGoTerms
            txtOverlapResults.Text += goTerm & Environment.NewLine
        Next
        'Output the results to the non overlap results text box
        For Each goTerm As String In nonOverlapGoTerms
            txtNonOverlapResults.Text += goTerm & Environment.NewLine
        Next
    End Sub

    Private Sub btnSelectFiles_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectFiles.Click
        ofdSelectFiles.ShowDialog()
        lblNumberOfFileSelected.Text = ofdSelectFiles.FileNames.Length.ToString & " files selected"
    End Sub
End Class
