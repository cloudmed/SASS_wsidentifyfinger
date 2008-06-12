Imports System.Web.Services
imports Registro 

<System.Web.Services.WebService(Namespace := "http://tempuri.org/wsIdentifyFinger/Service1")> _
Public Class Service1
    Inherits System.Web.Services.WebService
    Dim ds As New dsidentify

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""ELIEZER-NB"";packet size=4096;user id=sa;data source=""SERVIDOR\PBS" & _
        "QLDESENV"";persist security info=True;initial catalog=Biometria;password=planobe"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT sequencial, Codigo, DataHora, Descricao, VerificacaoOK, CodDedo FROM Biome" & _
        "triaDPLogs"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO BiometriaDPLogs(Codigo, DataHora, Descricao, VerificacaoOK, CodDedo) " & _
        "VALUES (@Codigo, @DataHora, @Descricao, @VerificacaoOK, @CodDedo); SELECT sequen" & _
        "cial, Codigo, DataHora, Descricao, VerificacaoOK, CodDedo FROM BiometriaDPLogs W" & _
        "HERE (sequencial = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataHora", System.Data.SqlDbType.DateTime, 8, "DataHora"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descricao", System.Data.SqlDbType.VarChar, 200, "Descricao"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VerificacaoOK", System.Data.SqlDbType.Int, 4, "VerificacaoOK"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodDedo", System.Data.SqlDbType.Int, 4, "CodDedo"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE BiometriaDPLogs SET Codigo = @Codigo, DataHora = @DataHora, Descricao = @D" & _
        "escricao, VerificacaoOK = @VerificacaoOK, CodDedo = @CodDedo WHERE (sequencial =" & _
        " @Original_sequencial) AND (CodDedo = @Original_CodDedo) AND (Codigo = @Original" & _
        "_Codigo) AND (DataHora = @Original_DataHora) AND (Descricao = @Original_Descrica" & _
        "o) AND (VerificacaoOK = @Original_VerificacaoOK); SELECT sequencial, Codigo, Dat" & _
        "aHora, Descricao, VerificacaoOK, CodDedo FROM BiometriaDPLogs WHERE (sequencial " & _
        "= @sequencial)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataHora", System.Data.SqlDbType.DateTime, 8, "DataHora"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descricao", System.Data.SqlDbType.VarChar, 200, "Descricao"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VerificacaoOK", System.Data.SqlDbType.Int, 4, "VerificacaoOK"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodDedo", System.Data.SqlDbType.Int, 4, "CodDedo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sequencial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sequencial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodDedo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodDedo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataHora", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataHora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descricao", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descricao", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VerificacaoOK", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerificacaoOK", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sequencial", System.Data.SqlDbType.Int, 4, "sequencial"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM BiometriaDPLogs WHERE (sequencial = @Original_sequencial) AND (CodDed" & _
        "o = @Original_CodDedo) AND (Codigo = @Original_Codigo) AND (DataHora = @Original" & _
        "_DataHora) AND (Descricao = @Original_Descricao) AND (VerificacaoOK = @Original_" & _
        "VerificacaoOK)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sequencial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sequencial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodDedo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodDedo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataHora", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataHora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descricao", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descricao", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VerificacaoOK", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerificacaoOK", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BiometriaDPLogs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("sequencial", "sequencial"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("DataHora", "DataHora"), New System.Data.Common.DataColumnMapping("Descricao", "Descricao"), New System.Data.Common.DataColumnMapping("VerificacaoOK", "VerificacaoOK"), New System.Data.Common.DataColumnMapping("CodDedo", "CodDedo")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Dedo, DataBin, Template1, Template2, Template3 FROM BiometriaDP"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO BiometriaDP(Codigo, Dedo, DataBin, Template1, Template2, Template3) V" & _
        "ALUES (@Codigo, @Dedo, @DataBin, @Template1, @Template2, @Template3); SELECT Cod" & _
        "igo, Dedo, DataBin, Template1, Template2, Template3 FROM BiometriaDP WHERE (Codi" & _
        "go = @Codigo) AND (Dedo = @Dedo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataBin", System.Data.SqlDbType.NVarChar, 1073741823, "DataBin"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template1", System.Data.SqlDbType.VarBinary, 2147483647, "Template1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template2", System.Data.SqlDbType.VarBinary, 2147483647, "Template2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template3", System.Data.SqlDbType.VarBinary, 2147483647, "Template3"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE BiometriaDP SET Codigo = @Codigo, Dedo = @Dedo, DataBin = @DataBin, Templa" & _
        "te1 = @Template1, Template2 = @Template2, Template3 = @Template3 WHERE (Codigo =" & _
        " @Original_Codigo) AND (Dedo = @Original_Dedo); SELECT Codigo, Dedo, DataBin, Te" & _
        "mplate1, Template2, Template3 FROM BiometriaDP WHERE (Codigo = @Codigo) AND (Ded" & _
        "o = @Dedo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataBin", System.Data.SqlDbType.NVarChar, 1073741823, "DataBin"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template1", System.Data.SqlDbType.VarBinary, 2147483647, "Template1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template2", System.Data.SqlDbType.VarBinary, 2147483647, "Template2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template3", System.Data.SqlDbType.VarBinary, 2147483647, "Template3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dedo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dedo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM BiometriaDP WHERE (Codigo = @Original_Codigo) AND (Dedo = @Original_D" & _
        "edo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dedo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dedo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BiometriaDP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Dedo", "Dedo"), New System.Data.Common.DataColumnMapping("DataBin", "DataBin"), New System.Data.Common.DataColumnMapping("Template1", "Template1"), New System.Data.Common.DataColumnMapping("Template2", "Template2"), New System.Data.Common.DataColumnMapping("Template3", "Template3")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    <WebMethod()> _
    Public Function CadastraFinger(ByVal codUsuario As String, ByVal template1 As Byte(), ByVal template2 As Byte(), ByVal template3 As Byte(), ByVal codDedo As Integer, ByVal cartaoFormatado As String) As String
        Try
            SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")

            Dim templateBin1 As New TTemplate
            Dim templateBin2 As New TTemplate
            Dim templateBin3 As New TTemplate

            templateBin1.tpt = template1
            templateBin2.tpt = template2
            templateBin3.tpt = template3

            cartaoFormatado = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)
            '!!!###WEB SERVICE###!!! referencia o web service c/ os dados do usu�rioss
            Dim webservice As New WebReference.Autorizador
            webservice.Url = Misc.GetDadoWebConfig("UrlWebService")

            'string com os dados do web service (usu�rio)
            Dim dadosdousuario As String = webservice.Autoriza(9, cartaoFormatado.Remove(cartaoFormatado.Length - 1, 1).PadLeft(16, "0"), 0, 0, 0, 0, 0, "", "", "", "", Misc.GetDadoWebConfig("Prototipo"))
            'Dim dadosdousuario As String = "/PES,""JEAN PAULO ORLANDO SILVA"",""04/12/1978"","""",""M"""
            'dadosdousuario = "PES"
            'dadosdousuario = "JEAN PAULO ORLANDO SILVA"
            'dadosdousuario = "04/12/1978"
            'dadosdousuario = ""
            'dadosdousuario = "M"
            'come�ando com...
            'If dadosdousuario.IndexOf(",") = -1 Then
            '    Return "/erro " & dadosdousuario
            'End If

            'separar (split) os campos separados c/ v�rgula que chegam do layout
            Dim nome As String = dadosdousuario.Split(",")(1).Replace("""", "")
            Dim datanasc As String = dadosdousuario.Split(",")(2).Replace("""", "")
            Dim sexo As String = dadosdousuario.Split(",")(4).Replace("""", "")

            '!!##LAYOUT DOS DADOS DO USU�RIO##!!: /PES,"JEAN PAULO ORLANDO SILVA","04/12/1978","","M"
            Dim dsDados As New DSIdentify
            'adiciona no data set a linha databin passando os parametros que chegam do layout
            dsDados.DataBin.AddDataBinRow(nome, sexo, datanasc, "", "")

            'Carregando templates do Banco de Dados
            SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM BiometriaDP WHERE (Codigo like @Codigo) and (Dedo = @Dedo)"
            SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
            SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))

            SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = cartaoFormatado.Substring(0, 15) & "%"
            SqlDataAdapter1.SelectCommand.Parameters("@Dedo").Value = codDedo
            SqlDataAdapter1.Fill(ds)

            'Verificando se j� existe
            If ds.BiometriaDP.Rows.Count > 0 Then
                If ds.BiometriaDP(0).IsTemplate1Null = True Or ds.BiometriaDP(0).Template1 Is Nothing = True Or ds.BiometriaDP(0).Template1.Length <> 0 Then
                    '!!!###GRAVANDO LOG###!!!
                    insertlog(cartaoFormatado, DateTime.Now, "Biometria ja cadastrada", False, codDedo)
                    Return "/erro Biometria ja Cadastrada"
                End If
            Else
                'Grava os templates no Banco de Dados
                SqlInsertCommand1.CommandText = "INSERT INTO BiometriaDP(Codigo, Dedo, DataBin, Template1, Template2, Template3) VALUES (@Codigo, @Dedo, @DataBin, @Template1, @Template2, @Template3)"

                SqlInsertCommand1.Parameters("@Codigo").Value = cartaoFormatado
                SqlInsertCommand1.Parameters("@Dedo").Value = codDedo
                'pegar o xml do databin que chega no dataset
                SqlInsertCommand1.Parameters("@DataBin").Value = dsDados.GetXml

                SqlInsertCommand1.Parameters("@Template1").Value = templateBin1.tpt
                SqlInsertCommand1.Parameters("@Template2").Value = templateBin2.tpt
                SqlInsertCommand1.Parameters("@Template3").Value = templateBin3.tpt

                SqlInsertCommand1.Connection.Open()
                SqlInsertCommand1.ExecuteNonQuery()
                SqlInsertCommand1.Connection.Close()

                'Adiciona ao Logs
                insertlog(cartaoFormatado, DateTime.Now, "Biometria Cadastrada com Sucesso", True, codDedo)
                Return "/ok"
            End If
            Exit Function
        Catch ex As Exception
            '!!!###GRAVANDO LOG###!!!
            insertlog(cartaoFormatado, DateTime.Now, "Erro ao Cadastrar Biometria", False, codDedo)
            Return "/erro " & ex.Message

        End Try
    End Function

    <WebMethod()> _
    Public Function validaFinger(ByVal codUsuario As String, ByVal template As Byte(), ByVal codDedo As Integer, ByVal cartaoFormatado As String) As String
        Try
            SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")
            cartaoFormatado = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

            Dim templateBin_recebido As New TTemplate

            templateBin_recebido.tpt = template

            'Dim templateVerify As System.Object = templateBin_recebido

            '-----------------------------------------------------------
            ' Lendo template binario gravado no banco de dados
            '-----------------------------------------------------------
            Dim templateGravado1 As Byte()
            Dim templateGravado2 As Byte()
            Dim templateGravado3 As Byte()

            'Carregando templates do Banco de Dados
            SqlDataAdapter1.SelectCommand.CommandText = _
               "SELECT * FROM BiometriaDP WHERE (Codigo like @Codigo) and (Dedo = @Dedo)"

            SqlDataAdapter1.SelectCommand.Parameters.Add _
               (New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))

            SqlDataAdapter1.SelectCommand.Parameters.Add _
               (New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))

            SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = cartaoFormatado.Substring(0, 15) & "%"
            SqlDataAdapter1.SelectCommand.Parameters("@Dedo").Value = codDedo
            SqlDataAdapter1.Fill(ds)

            '!!!###SE VERIFICAR E NAO ESTIVER CADASTRADO, AVISAR PARA CADASTRAR###!!!
            '!!!###SE TEMPLATE FOR NULO, AVISAR PARA CADASTRAR###!!!

            'verifica se esta vazio, nulo
            If (ds.BiometriaDP.Rows.Count = 0) Then
                'Biometria n�o existe, grava no log
                insertlog(cartaoFormatado, DateTime.Now, "Biometria nao cadastrada", False, codDedo)
                Return "/erro Biometria nao Cadastrada"
                Exit Function
            End If

            If ds.BiometriaDP(0).IsTemplate1Null = True Or ds.BiometriaDP(0).Template1 Is Nothing = True Then
                'Biometria n�o existe, grava no log
                insertlog(cartaoFormatado, DateTime.Now, "Biometria nao cadastrada", False, codDedo)
                Return "/erro Biometria nao Cadastrada"
            Else
                templateGravado1 = ds.BiometriaDP(0).Template1
                templateGravado2 = ds.BiometriaDP(0).Template2
                templateGravado3 = ds.BiometriaDP(0).Template3

                Dim resultado, score As Integer

                Dim GrFinger As GrFingerXLib.GrFingerXCtrl
                GrFinger = New GrFingerXLib.GrFingerXCtrl
                GrFinger.Initialize()

                resultado = GrFinger.Verify _
                   (templateBin_recebido.tpt, templateGravado1, score, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                'Verifica��o com sucesso! Grava no log e retorna /ok
                If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                    insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo)
                    Return "/ok "
                End If

                'Impress�o digital n�o reconhecida, verificar novamente com 2o. template
                If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                    'n�o passou na primeira, tentando 2a.
                    resultado = GrFinger.Verify(templateBin_recebido.tpt, templateGravado2, score, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                    'Verifica��o com sucesso! Grava no log e retorna /ok
                    If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                        insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo)
                        Return "/ok "
                    End If

                    'Impress�o digital n�o reconhecida, verificar novamente com 3o. template
                    If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                        'n�o passou na segunda, tentando 3a. e �ltima
                        resultado = GrFinger.Verify(templateBin_recebido.tpt, templateGravado3, score, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                        'Verifica��o com sucesso! Grava no log e retorna /ok
                        If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                            insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo)
                            Return "/ok "
                        End If

                        'Impress�o digital n�o reconhecida na 3a. tentativa, grava no log e retorna /erro
                        If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                            insertlog(cartaoFormatado, DateTime.Now, "Biometria Incompativel", False, codDedo)
                            Return "/erro Digital Incompativel."
                        End If
                    End If
                End If

                If (resultado <> GrFingerXLib.GRConstants.GR_NOT_MATCH) And (resultado <> GrFingerXLib.GRConstants.GR_MATCH) Then
                    Dim a As GrFingerXLib.GRConstants
                    a = resultado

                    'Grava no Log
                    insertlog(cartaoFormatado, DateTime.Now, "Erro Desconhecido" & a, False, codDedo)
                    Return "/erro Erro Desconhecido." & a.ToString
                End If
            End If
            Exit Function

        Catch ex As Exception
            'Grava no Log
            insertlog(cartaoFormatado, DateTime.Now, "Erro ao Verificar Biometria", False, codDedo)
            Return "/erro " & ex.Message

        End Try

        'Grava no Log
        insertlog(cartaoFormatado, DateTime.Now, "Erro ao Verificar Biometria", False, codDedo)
        Return "/erro Falha de Verificacao de Biometria"

    End Function

    Public Function insertlog(ByVal codUsuario As String, ByVal dthr As Date, ByVal desc As String, ByVal verificOK As Boolean, ByVal dedo As Integer)

        Try 'se caso os parametros forem inv�lidos, nulos
            SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")
            Dim cartaoFormatado As String = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

            '!!!###GRAVANDO LOG NO BANCO###!!!
            SqlDataAdapter2.InsertCommand.CommandText = "INSERT INTO BiometriaDPLogs(Codigo, DataHora, Descricao, VerificacaoOK, CodDedo) VALUES (@Codigo, @DataHora, @Descricao, @VerificacaoOK, @CodDedo)"
            SqlDataAdapter2.InsertCommand.Parameters("@Codigo").Value = cartaoFormatado
            SqlDataAdapter2.InsertCommand.Parameters("@DataHora").Value = dthr
            SqlDataAdapter2.InsertCommand.Parameters("@Descricao").Value = desc
            SqlDataAdapter2.InsertCommand.Parameters("@VerificacaoOK").Value = verificOK
            SqlDataAdapter2.InsertCommand.Parameters("@CodDedo").Value = dedo

            SqlDataAdapter2.InsertCommand.Connection.Open()
            SqlDataAdapter2.InsertCommand.ExecuteNonQuery()
            SqlDataAdapter2.InsertCommand.Connection.Close()

        Catch ex As Exception
            Return "/Parametros Invalidos" & ex.Message
        End Try
    End Function


    '<WebMethod()> _ 
    ' Esta Function cont�m rotinas de valida��o usando drivers da Digital Persona
    'Public Function validaFinger(ByVal codUsuario As String, ByVal template As Byte(), ByVal Size As Integer, ByVal codDedo As Integer, ByVal cartaoFormatado As String) As String
    '    Try
    '        SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")
    '        cartaoFormatado = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

    '        '-----------------------------------------------------------
    '        ' template = Variavel string recebida como par�metro
    '        '            Convertendo de StringB64 para byte array
    '        '            Depois de convertido, jogo numa variavel tipo Object
    '        '-----------------------------------------------------------
    '        'Dim templateBin As Byte() = System.Convert.FromBase64String(template)
    '        Dim templateBin As TTemplate

    '        templateBin.tpt = template
    '        templateBin.Size = Size

    '        Dim templateVerify As System.Object = templateBin

    '        '-----------------------------------------------------------
    '        ' Lendo template binario gravado no banco de dados
    '        '-----------------------------------------------------------
    '        Dim templateGravado As Byte()

    '        '!!!###POR ARQUIVO###!!!
    '        'Dim fileName As String = "D:\Inetpub\wwwroot\wsIdentifyFinger\" + codUsuario + ".bin"
    '        'Dim oFs As System.IO.FileStream = New System.IO.FileStream(fileName, System.IO.FileMode.Open)
    '        'ReDim templateGravado(oFs.Length - 1)
    '        'oFs.Read(templateGravado, 0, oFs.Length)
    '        'oFs.Close()

    '        '!!!###LENDO TEMPLATE DO BANCO###!!!
    '        SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM BiometriaDP WHERE (Codigo like @Codigo) and (Dedo = @Dedo)"

    '        SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
    '        SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))

    '        SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = cartaoFormatado.Substring(0, 15) & "%"
    '        SqlDataAdapter1.SelectCommand.Parameters("@Dedo").Value = codDedo
    '        SqlDataAdapter1.Fill(ds)

    '        '!!!###SE VERIFICAR E NAO ESTIVER CADASTRADO, AVISAR PARA CADASTRAR###!!!
    '        '!!!###SE TEMPLATE FOR NULO, AVISAR PARA CADASTRAR###!!!

    '        'verifica se esta vazio, nulo
    '        If ds.BiometriaDP(0).IsTemplate1Null = True Or ds.BiometriaDP(0).Template1 Is Nothing = True Then
    '            '!!!###GRAVANDO LOG###!!!
    '            insertlog(cartaoFormatado, DateTime.Now, "Biometria nao cadastrada", False, codDedo)
    '            Return "/erro Biometria nao Cadastrada"
    '        Else

    '            templateGravado = ds.BiometriaDP(0).Template1
    '            Dim templateRegistration As System.Object = templateGravado

    '            '-----------------------------------
    '            ' Valida��o
    '            '   * Declarando vari�veis
    '            '-----------------------------------

    '            Dim verifyOK As Boolean = False
    '            Dim score As Object = 0
    '            Dim theshold As Object = 0
    '            Dim tture As Boolean = True

    '            Dim SecureMode As DpSdkEngLib.AISecureModeMask = New DpSdkEngLib.AISecureModeMask
    '            Dim VerifClass As DpSdkEngLib.FPVerifyClass = New DpSdkEngLib.FPVerifyClass

    '            '-----------------------------------
    '            ' Valida��o
    '            '   * Carregando template recebido no parametro
    '            '-----------------------------------

    '            Dim VerifyTemplate As DpSdkEngLib.FPTemplate = New DpSdkEngLib.FPTemplate
    '            VerifyTemplate.Import(templateVerify)

    '            '-----------------------------------
    '            ' Valida��o
    '            '   * Carregando template gravado no banco
    '            '-----------------------------------

    '            Dim RegTemplate As DpSdkEngLib.FPTemplateClass = New DpSdkEngLib.FPTemplateClass
    '            System.Threading.Thread.CurrentThread.Sleep(1000)
    '            RegTemplate.Import(templateRegistration)

    '            '-----------------------------------
    '            ' Valida��o
    '            '   * Comparando templates
    '            '-----------------------------------

    '            VerifClass.Compare(RegTemplate, VerifyTemplate, verifyOK, score, theshold, tture, SecureMode)

    '            If (verifyOK = True) Then
    '                '!!!###GRAVANDO LOG###!!!
    '                insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo)
    '                Return "/ok"
    '            Else
    '                '!!!###GRAVANDO LOG###!!!
    '                insertlog(cartaoFormatado, DateTime.Now, "Biometria Incompativel", False, codDedo)
    '                Return "/erro Digital Incompativel."
    '            End If
    '        End If

    '        Exit Function
    '    Catch ex As Exception
    '        '!!!###GRAVANDO LOG###!!!
    '        insertlog(cartaoFormatado, DateTime.Now, "Erro ao Verificar Biometria", False, codDedo)
    '        Return "/erro " & ex.Message

    '    End Try
    '    '!!!###GRAVANDO LOG###!!!
    '    insertlog(cartaoFormatado, DateTime.Now, "Erro ao Verificar Biometria", False, codDedo)
    '    Return "/erro Falha de Verificacao de Biometria"

    'End Function


End Class