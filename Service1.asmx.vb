Imports System.Web.Services
Imports Registro
Imports System.Data.SqlClient

<System.Web.Services.WebService(Namespace := "http://tempuri.org/wsIdentifyFinger/Service1")> _
Public Class Service1
    Inherits System.Web.Services.WebService
    Dim DS As New DSIdentify
    Dim NumeroDoDedo As Integer

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
    Public Function CadastraFinger(ByVal codUsuario As String, ByVal template1 As Byte(), ByVal template2 As Byte(), ByVal template3 As Byte(), ByVal codDedo As Integer, ByVal cartaoFormatado As String, ByVal codPrestador As String) As String
        Try
            SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")

            NumeroDoDedo = codDedo

            Dim templateBin1 As New TTemplate : templateBin1.tpt = template1
            Dim templateBin2 As New TTemplate : templateBin2.tpt = template2
            Dim templateBin3 As New TTemplate : templateBin3.tpt = template3

            Dim UsuarioJaExiste As Boolean = False
            Dim DataSetIdentify As New DSIdentify

            cartaoFormatado = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

            UsuarioJaExiste = VerificaSeUsuarioExiste(cartaoFormatado)

            If (UsuarioJaExiste) Then
                '''Consulta dados do usu�rio no banco de dados (xml)
                LeDadosDoUsuarioNoBancoDeDados(cartaoFormatado, DataSetIdentify)
            Else
                '''Consulta dados do usu�rio no autorizador da Dual
                LeDadosDoUsuarioNoAutorizador(cartaoFormatado, DataSetIdentify)
            End If


            If (UsuarioJaExiste) Then
                If (DataSetIdentify.BiometriaDP(0).IsTemplate1Null) = True Then 'Existe o registro, mas ainda n�o existe a biometria cadastrada
                    If (GravaTeplatesNoBanco(cartaoFormatado, templateBin1, templateBin2, templateBin3, codPrestador)) Then
                        insertlog(cartaoFormatado, DateTime.Now, "Impress�o Digital Cadastrada com Sucesso.", True, codDedo, codPrestador)
                        Return "/ok"
                    Else
                        insertlog(cartaoFormatado, DateTime.Now, "Erro ao Cadastrar Impress�o Digital.", False, codDedo, codPrestador)
                        Return "/erro Erro ao cadastrar Impress�o Digital."
                    End If
                Else
                    insertlog(cartaoFormatado, DateTime.Now, "Impress�o Digital j� cadastrada.", False, codDedo, codPrestador)
                    Return "/erro Impress�o Digital j� cadastrada."
                End If
            Else
                If (GravaNovosTemplatesDoUsuarioNoBanco(cartaoFormatado, templateBin1, templateBin2, templateBin3, DataSetIdentify, codPrestador)) Then
                    insertlog(cartaoFormatado, DateTime.Now, "Impress�o Digital Cadastrada com Sucesso.", True, codDedo, codPrestador)
                    Return "/ok"
                Else
                    insertlog(cartaoFormatado, DateTime.Now, "Erro ao Cadastrar Impress�o Digital.", False, codDedo, codPrestador)
                    Return "/erro Erro ao cadastrar Impress�o Digital."
                End If
            End If

        Catch ex As Exception
            insertlog(cartaoFormatado, DateTime.Now, "Erro: " & ex.Message, False, codDedo, codPrestador)
            Return "/erro Comunique erro " & ex.Message
        End Try

    End Function

    <WebMethod()> _
    Public Function validaFinger(ByVal codUsuario As String, ByVal template As Byte(), ByVal codDedo As Integer, ByVal cartaoFormatado As String, ByVal codPrestador As String) As String
        Try
            SqlConnection1.ConnectionString = Misc.GetDadoWebConfig("conexaoBiometria")

            cartaoFormatado = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

            Dim templateBin_recebido As New TTemplate

            templateBin_recebido.tpt = template

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

            If Misc.GetDadoWebConfig("layout") <> "stacasasauderiopreto" Then
                SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = cartaoFormatado.Substring(0, 15) & "%"
            Else
                SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = cartaoFormatado & "%"
            End If

            SqlDataAdapter1.SelectCommand.Parameters("@Dedo").Value = codDedo
            SqlDataAdapter1.Fill(DS)

            '!!!###SE VERIFICAR E NAO ESTIVER CADASTRADO, AVISAR PARA CADASTRAR###!!!
            '!!!###SE TEMPLATE FOR NULO, AVISAR PARA CADASTRAR###!!!

            'verifica se esta vazio, nulo
            If (DS.BiometriaDP.Rows.Count = 0) Then
                'Biometria n�o existe, grava no log
                insertlog(cartaoFormatado, DateTime.Now, "C�digo do usu�rio n�o cadastrado.", False, codDedo, codPrestador)
                Return "/erro C�digo do usu�rio n�o cadastrado."
                Exit Function
            End If

            If DS.BiometriaDP(0).IsTemplate1Null = True Or DS.BiometriaDP(0).Template1 Is Nothing = True Then
                'Biometria n�o existe, grava no log
                insertlog(cartaoFormatado, DateTime.Now, "Impress�o Digital n�o cadastrada.", False, codDedo, codPrestador)
                Return "/erro Impress�o Digital n�o cadastrada."
            Else
                Dim GrFinger As GrFingerXLib.GrFingerXCtrl
                Dim SensibilidadeDeVerificacao As Integer = CInt(Misc.GetDadoWebConfig("SensibilidadeDeVerificacao"))

                'O valor m�ximo permitido � 200, e o valor m�nimo permitido � 10
                If (SensibilidadeDeVerificacao < 10) Or _
                   (SensibilidadeDeVerificacao > 200) Then
                    SensibilidadeDeVerificacao = 25 'Valor default = 25
                End If

                Dim Resultado_de_Parametrizacao As Integer

                templateGravado1 = DS.BiometriaDP(0).Template1
                templateGravado2 = DS.BiometriaDP(0).Template2
                templateGravado3 = DS.BiometriaDP(0).Template3

                Dim resultado, score1, score2, score3 As Integer

                GrFinger = New GrFingerXLib.GrFingerXCtrl
                GrFinger.Initialize()
                Resultado_de_Parametrizacao = GrFinger.SetVerifyParameters(SensibilidadeDeVerificacao, 180, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                resultado = GrFinger.Verify _
                                   (templateBin_recebido.tpt, templateGravado1, score1, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                'Verifica��o com sucesso! Grava no log e retorna /ok
                If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                    'insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso(1o. template), score: " & score1.ToString, True, codDedo, codPrestador)
                    insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo, codPrestador)
                    Return "/ok "
                End If

                'Impress�o digital n�o reconhecida, verificar novamente com 2o. template
                If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                    'Registrando no LOG que n�o foi poss�vel verifica��o na 1a. tentativa
                    'insertlog(cartaoFormatado, DateTime.Now, "ERRO: 1a. Verifica��o incompat�vel com score: " & score1.ToString, False, codDedo, codPrestador)

                    'n�o passou na primeira, tentando 2a.
                    resultado = GrFinger.Verify(templateBin_recebido.tpt, templateGravado2, score2, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                    'Verifica��o com sucesso! Grava no log e retorna /ok
                    If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                        'insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso(2o. template), score: " & score2.ToString, True, codDedo, codPrestador)
                        insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo, codPrestador)
                        Return "/ok "
                    End If

                    'Impress�o digital n�o reconhecida, verificar novamente com 3o. template
                    If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                        'Registrando no LOG que n�o foi poss�vel verifica��o na 2a. tentativa
                        'insertlog(cartaoFormatado, DateTime.Now, "ERRO: 2a. Verifica��o incompat�vel com score: " & score2.ToString, False, codDedo, codPrestador)

                        'n�o passou na segunda, tentando 3a. e �ltima
                        resultado = GrFinger.Verify(templateBin_recebido.tpt, templateGravado3, score3, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)

                        'Verifica��o com sucesso! Grava no log e retorna /ok
                        If (resultado = GrFingerXLib.GRConstants.GR_MATCH) Then
                            'insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso (3o. template), score: " & score3.ToString, True, codDedo, codPrestador)
                            insertlog(cartaoFormatado, DateTime.Now, "Biometria Verificada com Sucesso", True, codDedo, codPrestador)
                            Return "/ok "
                        End If

                        'Impress�o digital n�o reconhecida na 3a. tentativa, grava no log e retorna /erro
                        If (resultado = GrFingerXLib.GRConstants.GR_NOT_MATCH) Then
                            insertlog(cartaoFormatado, DateTime.Now, "Biometria Incompativel.(score1=" & score1.ToString & "),(score2=" & score2.ToString & "),(score3=" & score3.ToString & ")", False, codDedo, codPrestador)
                            Return "/erro Digital Incompativel."
                        End If
                    End If
                End If

                If (resultado <> GrFingerXLib.GRConstants.GR_NOT_MATCH) And (resultado <> GrFingerXLib.GRConstants.GR_MATCH) Then
                    Dim a As GrFingerXLib.GRConstants
                    a = resultado
                    'Grava no Log
                    insertlog(cartaoFormatado, DateTime.Now, "Erro Desconhecido: " & a, False, codDedo, codPrestador)
                    Return "/erro Digital nao Capturada com Sucesso. Detalhes do erro: " & a.ToString
                End If
            End If
            Exit Function
        Catch ex As Exception
            'Grava no Log
            insertlog(cartaoFormatado, DateTime.Now, "Erro ao Verificar Biometria: " & ex.Message, False, codDedo, codPrestador)
            Return "/erro " & ex.Message
        End Try

        'Grava no Log
        insertlog(cartaoFormatado, DateTime.Now, "Falha de Verificacao de Biometria.", False, codDedo, codPrestador)
        Return "/erro Falha de Verificacao de Biometria."
    End Function

    <WebMethod()> _
    Public Function insertlog(ByVal codUsuario As String, ByVal dthr As Date, ByVal desc As String, ByVal verificOK As Boolean, ByVal dedo As Integer, ByVal codPrestador As String)
        Try
            Dim ComandoSQL As String
            Dim cartaoFormatado As String = Misc.AjustaCartao(codUsuario, Registro.Misc.GetDadoWebConfig("AjusteCartao"), False)

            ComandoSQL = "INSERT INTO BiometriaDPLogs(Codigo, DataHora, Descricao, VerificacaoOK, CodDedo, CodigoPrestador) VALUES (@Codigo, @DataHora, @Descricao, @VerificacaoOK, @CodDedo, @CodigoPrestador)"
            Dim myConnection As SqlConnection = New SqlConnection(Misc.GetDadoWebConfig("conexaoBiometria"))
            Dim myCommand As SqlCommand = New SqlCommand(ComandoSQL, myConnection)

            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataHora", System.Data.SqlDbType.DateTime, 8, "DataHora"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descricao", System.Data.SqlDbType.VarChar, 200, "Descricao"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VerificacaoOK", System.Data.SqlDbType.Int, 4, "VerificacaoOK"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodDedo", System.Data.SqlDbType.Int, 4, "CodDedo"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoPrestador", System.Data.SqlDbType.VarChar, 100, "CodigoPrestador"))

            myCommand.Parameters("@Codigo").Value = cartaoFormatado
            myCommand.Parameters("@DataHora").Value = dthr
            myCommand.Parameters("@Descricao").Value = desc
            myCommand.Parameters("@VerificacaoOK").Value = verificOK
            myCommand.Parameters("@CodDedo").Value = dedo
            myCommand.Parameters("@CodigoPrestador").Value = codPrestador

            myCommand.Connection.Open()
            myCommand.ExecuteNonQuery()
            myCommand.Connection.Close()

            Return True
        Catch ex As Exception
            Return "/Parametros Invalidos" & ex.Message
        End Try
    End Function

#Region " Fun��es usadas pela WebMethod CadastraFinger "

    'LeDadosDoUsuarioNoAutorizador
    '=============================
    'Esta fun��o foi criada para fazer a intega��o com o Autorizador do Plano de Sa�de que deve responder com
    'os dados do usu�rio pesquisado. Estes dados ser�o gravados na coluna DATABIN da Tabela BiometriaDP em 
    'formato XML (XMLBIN)

    Function LeDadosDoUsuarioNoAutorizador(ByVal cartaoFormatado As String, ByRef DataSetIdentify As DSIdentify) As Boolean
        Dim WEBService As New WebReference.Autorizador : WEBService.Url = Misc.GetDadoWebConfig("UrlWebService")
        Dim NomeDoUsuario, DataDeNascimento, SexoDoUsuario, NomeDaMaeDoUsuario, CPF_DoUsuario, RG_DoUsuario As String
        Dim dtNascimento As Date
        Dim IdadeDoUsuario As Integer
        Dim Dados_do_Usuario As String
        Dim dsDados As New dsDadosUsuario

        '***** Dados do Usu�rio HB: *****

        'PES,\"LEANDRO MATEUS ARAUJO MEDINA\",\"10/05/1979\",\"M\",
        '\"SOLANGE ARAUJO MEDINA\",\"28225242890\",\"333068142\"\n"



        '***** Dados do Usu�rio Santa Casa: *****

        '"<dsDadosUsuario xmlns=\"http://tempuri.org/dsDadosUsuario.xsd\">\n  <DadosUsuario>\n    <Nome>EMERSON DA         'SILVA MOREIRA</Nome>\n    <DataNasc>17/8/1973 00:00:00</DataNasc>\n    <Sexo>Masculino</Sexo>\n            '<CPF>VILMA RODRIGUES DO CARMO</CPF>\n    <RG>2016560-4</RG>\n  </DadosUsuario>\n</dsDadosUsuario>"


        '''Para Santa Casa o cart�o deve ir com 17 d�gitos
        If Misc.GetDadoWebConfig("layout") = "uninet" Then
            Dados_do_Usuario = WEBService.Autoriza(9, cartaoFormatado.Remove(cartaoFormatado.Length - 1, 1).PadLeft(16, "0"), 0, 0, 0, 0, 0, "", "", "", "", Misc.GetDadoWebConfig("Prototipo"))
        ElseIf Misc.GetDadoWebConfig("layout") = "stacasasauderiopreto" Then
            Dados_do_Usuario = WEBService.Autoriza(9, cartaoFormatado, 0, 0, 0, 0, 0, "", "", "", "", Misc.GetDadoWebConfig("Prototipo"))
        End If

        DataSetIdentify.Clear()

        If (Dados_do_Usuario.Trim <> "") Then
            Try
                If Misc.GetDadoWebConfig("layout") = "uninet" Then
                    '''Separar (split) os campos separados c/ v�rgula que chegam do layout --> HB
                    NomeDoUsuario = Dados_do_Usuario.Split(",")(1).Replace("""", "")
                    DataDeNascimento = Dados_do_Usuario.Split(",")(2).Replace("""", "")
                    SexoDoUsuario = Dados_do_Usuario.Split(",")(3).Replace("""", "")
                    NomeDaMaeDoUsuario = Dados_do_Usuario.Split(",")(4).Replace("""", "")
                    CPF_DoUsuario = Dados_do_Usuario.Split(",")(5).Replace("""", "")
                    RG_DoUsuario = Dados_do_Usuario.Split(",")(6).Replace("""", "")

                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(13) & Chr(10), "")
                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(13), "")
                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(10), "")

                ElseIf Misc.GetDadoWebConfig("layout") = "stacasasauderiopreto" Then
                    '''Santa Casa os dados vem em XML
                    Misc.LoadXML(dsDados, Dados_do_Usuario)
                    NomeDoUsuario = dsDados.DadosUsuario(0).Nome
                    dtNascimento = dsDados.DadosUsuario(0).DataNasc
                    SexoDoUsuario = dsDados.DadosUsuario(0).Sexo
                    NomeDaMaeDoUsuario = dsDados.DadosUsuario(0).NomeMae
                    CPF_DoUsuario = dsDados.DadosUsuario(0).CPF
                    RG_DoUsuario = dsDados.DadosUsuario(0).RG

                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(13) & Chr(10), "")
                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(13), "")
                    RG_DoUsuario = RG_DoUsuario.Replace(Chr(10), "")
                End If

                'Adicionando no dataset a linha databin passando os parametros que chegaram do layout
                If Misc.GetDadoWebConfig("layout") <> "stacasasauderiopreto" Then
                    IdadeDoUsuario = getIdade(CDate(DataDeNascimento))
                    DataSetIdentify.DataBin.AddDataBinRow(NomeDoUsuario, SexoDoUsuario, DataDeNascimento, "", "", NomeDaMaeDoUsuario, CPF_DoUsuario, RG_DoUsuario, IdadeDoUsuario)
                Else
                    IdadeDoUsuario = getIdade(dtNascimento)
                    DataSetIdentify.DataBin.AddDataBinRow(NomeDoUsuario, SexoDoUsuario, dtNascimento, "", "", NomeDaMaeDoUsuario, CPF_DoUsuario, RG_DoUsuario, IdadeDoUsuario)
                End If

                Return True

            Catch ex As Exception
                insertlog(cartaoFormatado, DateTime.Now, "ERRO: Resposta do autorizador inv�lida, Erro=" & ex.Message, False, NumeroDoDedo, "")
                Return False
            End Try
        Else
            insertlog(cartaoFormatado, DateTime.Now, "ERRO: Resposta do autorizador est� vazia", False, NumeroDoDedo, "")
            Return False
        End If
    End Function

    Function CarregaDatasetDoUsuario(ByVal codigoUsuario As String, ByRef ds As DSIdentify) As Boolean
        Try
            ds.Clear()
            SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM BiometriaDP WHERE (Codigo like @Codigo) and (Dedo = @Dedo)"
            SqlDataAdapter1.SelectCommand.Parameters.Clear()
            SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
            SqlDataAdapter1.SelectCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))

            If Misc.GetDadoWebConfig("layout") <> "stacasasauderiopreto" Then
                SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = codigoUsuario.Substring(0, 15) & "%"
            Else
                SqlDataAdapter1.SelectCommand.Parameters("@Codigo").Value = codigoUsuario & "%"
            End If

            SqlDataAdapter1.SelectCommand.Parameters("@Dedo").Value = NumeroDoDedo
            SqlDataAdapter1.Fill(ds)

            Return True
        Catch
            Return False
        End Try
    End Function

    Function VerificaSeUsuarioExiste(ByVal codigoUsuario As String) As Boolean
        If (CarregaDatasetDoUsuario(codigoUsuario, DS)) Then
            If (DS.BiometriaDP.Rows.Count) > 0 Then Return True Else Return False
        Else
            Return False
        End If
    End Function

    Function LeDadosDoUsuarioNoBancoDeDados(ByVal codigoUsuario As String, ByRef DataSetIdentify As DSIdentify) As Boolean
        Return (CarregaDatasetDoUsuario(codigoUsuario, DataSetIdentify))
    End Function

    Function GravaTeplatesNoBanco(ByVal CodigoUsuario As String, ByVal TemplateBin1 As TTemplate, ByVal TemplateBin2 As TTemplate, ByVal TemplateBin3 As TTemplate, ByVal codPrestador As String) As Boolean
        'Atualizar dados, pq j� existe o c�digo gravado no banco
        Try
            Dim ComandoSQL As String
            ComandoSQL = "UPDATE BiometriaDP set Template1 = @Template1, Template2 = @Template2, Template3 = @Template3 WHERE (Codigo = @Codigo) and (Dedo = @Dedo)"
            Dim myConnection As SqlConnection = New SqlConnection(Misc.GetDadoWebConfig("conexaoBiometria"))
            Dim myCommand As SqlCommand = New SqlCommand(ComandoSQL, myConnection)

            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template1", System.Data.SqlDbType.VarBinary, 2147483647, "Template1"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template2", System.Data.SqlDbType.VarBinary, 2147483647, "Template2"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Template3", System.Data.SqlDbType.VarBinary, 2147483647, "Template3"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
            myCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dedo", System.Data.SqlDbType.Int, 4, "Dedo"))

            myCommand.Parameters("@Template1").Value = TemplateBin1.tpt
            myCommand.Parameters("@Template2").Value = TemplateBin2.tpt
            myCommand.Parameters("@Template3").Value = TemplateBin3.tpt
            myCommand.Parameters("@Codigo").Value = CodigoUsuario
            myCommand.Parameters("@Dedo").Value = NumeroDoDedo

            Dim QtdeItens As Integer
            myCommand.Connection.Open()
            QtdeItens = myCommand.ExecuteNonQuery()
            myCommand.Connection.Close()

            If QtdeItens = 0 Then Return False

            Return True
        Catch ex As Exception
            insertlog(CodigoUsuario, DateTime.Now, "ERRO ao gravar templates no Bando de Dados: " & ex.Message, False, NumeroDoDedo, codPrestador)
            Return False
        End Try
    End Function

    Public Function GravaNovosTemplatesDoUsuarioNoBanco(ByVal CodigoUsuario As String, ByVal TemplateBin1 As TTemplate, ByVal TemplateBin2 As TTemplate, ByVal TemplateBin3 As TTemplate, ByVal dataSetIdentify As DSIdentify, ByVal codPrestador As String) As Boolean
        Try
            'Grava os templates no Banco de Dados
            SqlInsertCommand1.CommandText = "INSERT INTO BiometriaDP(Codigo, Dedo, DataBin, Template1, Template2, Template3) VALUES (@Codigo, @Dedo, @DataBin, @Template1, @Template2, @Template3)"

            SqlInsertCommand1.Parameters("@Codigo").Value = CodigoUsuario
            SqlInsertCommand1.Parameters("@Dedo").Value = NumeroDoDedo
            'pegar o xml do databin que chega no dataset
            SqlInsertCommand1.Parameters("@DataBin").Value = dataSetIdentify.GetXml

            SqlInsertCommand1.Parameters("@Template1").Value = TemplateBin1.tpt
            SqlInsertCommand1.Parameters("@Template2").Value = TemplateBin2.tpt
            SqlInsertCommand1.Parameters("@Template3").Value = TemplateBin3.tpt

            Dim QtdeItens As Integer
            SqlInsertCommand1.Connection.Open()
            QtdeItens = SqlInsertCommand1.ExecuteNonQuery()
            SqlInsertCommand1.Connection.Close()

            If QtdeItens > 0 Then
                insertlog(CodigoUsuario, DateTime.Now, "Biometria Cadastrada com Sucesso", True, NumeroDoDedo, codPrestador)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            insertlog(CodigoUsuario, DateTime.Now, "ERRO ao gravar novo usu�rio no Bando de Dados: " & ex.Message, False, NumeroDoDedo, codPrestador)
            Return False
        End Try
    End Function

    Function getIdade(ByVal DataNascimento As Date) As Integer
        Dim AnoAtual, MesAtual, DiaAtual, Anos, Meses, Dias As Integer

        AnoAtual = Date.Now.Year
        MesAtual = Date.Now.Month
        DiaAtual = Date.Now.Day

        Anos = 0
        Meses = 0
        Dias = 0

        If AnoAtual >= DataNascimento.Year Then
            Anos = AnoAtual - DataNascimento.Year
            If MesAtual < DataNascimento.Month & Anos > 0 Then
                Anos = Anos - 1
                MesAtual = MesAtual + 12
            End If
        End If

        If MesAtual > DataNascimento.Month Then
            Meses = MesAtual - DataNascimento.Month
        End If

        If DiaAtual < DataNascimento.Day & Meses > 0 Then
            Meses = Meses - 1
            DiaAtual = DiaAtual + 30
        End If

        If DiaAtual > DataNascimento.Day Then
            Dias = DiaAtual - DataNascimento.Day
        End If

        If Anos >= 1 Then
            Return Anos
        Else
            Return 0
        End If

    End Function

#End Region

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