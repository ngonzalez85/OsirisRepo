Imports MySql.Data.MySqlClient
Imports System.IO
'Imports System.Runtime.InteropServices
Imports System.Drawing.Text
Imports System.Text
Imports System.Threading
Public Class orden_medica
    Private Sub orden_medica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView2.Nodes.Clear()
        TreeView3.Nodes.Clear()
        cargar_arbol_agenda()
        cargar_arbol_adjuntos()
        TabControl1.TabPages.Clear()

        Console.WriteLine(txtidcentro.Text & ", " & txtidcita.Text & ", " & txtidestudio.Text)

        If txtidcentro.Text <> 1 Then
            consultar_centro(txtidcentro.Text)
            If dr.Read Then
                '   TabControl1.TabPages.Remove(TabPage1)
                TabControl1.TabPages.Insert(1, TabPage2) 'Show female
                TabPage2.Text = dr(1)
            End If

        Else
            TabControl1.TabPages.Insert(0, TabPage1) 'Show male
            '   TabControl1.TabPages.Remove(TabPage2)
        End If
    End Sub

    ' variable del objeto DataView, se usa para poder realizar filtros dentro de la misma
    Private oVista As DataView
    ' variable (Flag) usada para indicar que si hay o no un Drag and Drop dentro del TreeView
    Private DragDropTreeView As Boolean
    ' variable que guarda el nodo arrastrado por el usuario.
    Private NodoOrigen As TreeNode
    ' variable del objeto DataView, se usa para poder realizar filtros dentro de la misma
    ' variable del objeto DataView, se usa para poder realizar filtros dentro de la misma
    Private oVista_agenda As DataView

    Private Sub cargar_arbol_agenda()
        Dim nodo As TreeNode

        ' crear conexión
        Dim oConexion As New MySqlConnection
        oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        ' crear los DataAdapter
        Dim oDAAdjuntos_agenda As New MySqlDataAdapter("SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(archivo, ' ', n), ' ', -1 ) AS archivo
            FROM (SELECT idreferencia, TRIM(archivo) archivo FROM medvitaltest.archivos) archivos
            JOIN  filas
              ON CHAR_LENGTH(archivo) 
                - CHAR_LENGTH(REPLACE(archivo, ' ', '')) 
                >= n - 1
             WHERE idreferencia='" & txtidcita.Text & "' AND idreferencia <> 0 ", oConexion)

        ' crear conjunto de datos
        Dim oDataSet As New DataSet

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAAdjuntos_agenda.Fill(oDataSet, "archivos")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaAdjuntos_agenda As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaAdjuntos_agenda = oDataSet.Tables("archivos")

        ' deshabilita la actualización en pantalla del control TreeView 
        TreeView2.BeginUpdate()

        ' defino variable del tipo DataRow
        Dim Registro As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
        nodo = TreeView2.Nodes.Add("Ordenes médicas")

        For Each Registro In oTablaAdjuntos_agenda.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView2.Nodes(0).Nodes.Add(Trim(Registro("archivo")))

            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' habilita la actualización en pantalla del control TreeView
        TreeView2.EndUpdate()

        ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
        TreeView2.AllowDrop = True

        ' modifico la propiedad Sorted a True para que los nodos estén ordenados
        TreeView2.Sorted = True
    End Sub

    Private Sub TreeView2_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView2.NodeMouseClick
        Dim loPSI As New ProcessStartInfo
        Dim loProceso As New Process

        Try
            'My.Computer.Network.DownloadFile(agendaftp & e.Node.Text, "C:\osiris\files\adjuntos_agenda\" & e.Node.Text, userftp_agenda, passftp_agenda, False, 500, True)
            If e.Node.Text <> "Ordenes médicas" Then
                Dim servidor As String = serverdb.Replace("""", "")
                Dim piStart As ProcessStartInfo =
                New ProcessStartInfo("Chrome.exe")
                Process.Start(piStart)
                piStart.Arguments = "http://" & servidor & "/foto/" & e.Node.Text
                Process.Start(piStart)

            End If
        Catch Exp As Exception
            'MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cargar_arbol_adjuntos()
        Dim nodo As TreeNode

        ' crear conexión
        Dim oConexion As New MySqlConnection
        oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        ' crear los DataAdapter
        Dim oDAAdjuntos As New MySqlDataAdapter("SELECT archivo from adjuntos WHERE idestudio=" & txtidestudio.Text, oConexion)

        ' crear conjunto de datos
        Dim oDataSet As New DataSet

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAAdjuntos.Fill(oDataSet, "adjuntos")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaAdjuntos As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaAdjuntos = oDataSet.Tables("adjuntos")

        ' deshabilita la actualización en pantalla del control TreeView 
        TreeView3.BeginUpdate()

        ' defino variable del tipo DataRow
        Dim Registro As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
        nodo = TreeView3.Nodes.Add("Ordenes médicas")

        For Each Registro In oTablaAdjuntos.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView3.Nodes(0).Nodes.Add(Trim(Registro("archivo")))

            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' habilita la actualización en pantalla del control TreeView
        TreeView3.EndUpdate()

        ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
        TreeView3.AllowDrop = True

        ' modifico la propiedad Sorted a True para que los nodos estén ordenados
        TreeView3.Sorted = True
    End Sub

    Private Sub TreeView3_NodeMouseClick_1(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView3.NodeMouseClick
        Dim loPSI As New ProcessStartInfo
        Dim loProceso As New Process

        Try
            'My.Computer.Network.DownloadFile(agendaftp & e.Node.Text, "C:\osiris\files\adjuntos_agenda\" & e.Node.Text, userftp_agenda, passftp_agenda, False, 500, True)
            If e.Node.Text <> "Ordenes médicas" Then
                Dim servidor As String = serverdb.Replace("""", "")
                loPSI.FileName = "Chrome.exe"
                loProceso = Process.Start(loPSI)
                loPSI.Arguments = "http://" & servidor & "/ordenesosiris/" & e.Node.Text
                loProceso = Process.Start(loPSI)

            End If
        Catch Exp As Exception
            'MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class