'Namespace AWB.Plugins.SDKSoftware.Kingbotk.Components

Friend NotInheritable Class WPBiographySettings
    Implements GenericSettingsClass

    Private Const conLivingParm As String = "BioLivingPerson"
    Private Const conAutoStubParm As String = "BioAutoStub"
    Private Const conStubClassParm As String = "BioStubClass"
    Private Const conActivePolParm As String = "BioActivePol"
    Private Const conArtsEntsWGParm As String = "BioArtsEntsWG"
    Private Const conMilitaryWGParm As String = "BioMilitaryWG"
    Private Const conBritishRoyaltyWGParm As String = "BioBritishRoyaltyWG"
    Private Const conRoyaltyWGParm As String = "BioRoyaltyWG"
    Private Const conPoliticianWGParm As String = "BioPoliticianWG"
    Private Const conCategoryTalkParm As String = "BioCategoryTalk"
    Private Const conForcePriorityParm As String = "BioForcePriorityParm"
    Private Const conNonBioParm As String = "BioNonBio"

    ' UI:
    Private txtEdit As TextBox

    ' XML interface:
    Public Sub ReadXML(ByVal Reader As System.Xml.XmlTextReader)
        Living = PluginManager.XMLReadBoolean(Reader, conLivingParm, Living)
        AutoStub = PluginManager.XMLReadBoolean(Reader, conAutoStubParm, AutoStub)
        StubClass = PluginManager.XMLReadBoolean(Reader, conStubClassParm, StubClass)
        ActivePol = PluginManager.XMLReadBoolean(Reader, conActivePolParm, ActivePol)
        ArtsEntsWG = PluginManager.XMLReadBoolean(Reader, conArtsEntsWGParm, ArtsEntsWG)
        MilitaryWG = PluginManager.XMLReadBoolean(Reader, conMilitaryWGParm, MilitaryWG)
        RoyaltyWG = PluginManager.XMLReadBoolean(Reader, conRoyaltyWGParm, RoyaltyWG)
        PoliticianWG = PluginManager.XMLReadBoolean(Reader, conPoliticianWGParm, PoliticianWG)
        ForcePriorityParm = PluginManager.XMLReadBoolean(Reader, conForcePriorityParm, ForcePriorityParm)
        BritishRoyaltyWG = PluginManager.XMLReadBoolean(Reader, conBritishRoyaltyWGParm, BritishRoyaltyWG)
        NonBio = PluginManager.XMLReadBoolean(Reader, conNonBioParm, NonBio)
    End Sub
    Public Sub WriteXML(ByVal Writer As System.Xml.XmlTextWriter)
        With Writer
            .WriteAttributeString(conLivingParm, Living.ToString)
            .WriteAttributeString(conAutoStubParm, AutoStub.ToString)
            .WriteAttributeString(conStubClassParm, StubClass.ToString)
            .WriteAttributeString(conActivePolParm, ActivePol.ToString)
            .WriteAttributeString(conArtsEntsWGParm, ArtsEntsWG.ToString)
            .WriteAttributeString(conMilitaryWGParm, MilitaryWG.ToString)
            .WriteAttributeString(conRoyaltyWGParm, RoyaltyWG.ToString)
            .WriteAttributeString(conPoliticianWGParm, PoliticianWG.ToString)
            .WriteAttributeString(conForcePriorityParm, ForcePriorityParm.ToString)
            .WriteAttributeString(conBritishRoyaltyWGParm, BritishRoyaltyWG.ToString)
            .WriteAttributeString(conNonBioParm, NonBio.ToString)
        End With
    End Sub
    Public Sub Reset()
        Living = False
        AutoStub = False
        StubClass = False
        ActivePol = False
        ArtsEntsWG = False
        MilitaryWG = False
        RoyaltyWG = False
        PoliticianWG = False
        ForcePriorityParm = False
        BritishRoyaltyWG = False
        NonBio = False
    End Sub

    ' Properties:
    Public Property Living() As Boolean
        Get
            Return LivingCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            LivingCheckBox.Checked = value
        End Set
    End Property
    Public Property StubClass() As Boolean Implements GenericSettingsClass.StubClass
        Get
            Return StubClassCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            StubClassCheckBox.Checked = value
        End Set
    End Property
    Public Property ActivePol() As Boolean
        Get
            Return ActivePoliticianCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            ActivePoliticianCheckBox.Checked = value
        End Set
    End Property
    Public Property ArtsEntsWG() As Boolean
        Get
            Return ArtsEntsCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            ArtsEntsCheckBox.Checked = value
        End Set
    End Property
    Public Property MilitaryWG() As Boolean
        Get
            Return MilitaryCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            MilitaryCheckBox.Checked = value
        End Set
    End Property
    Public Property BritishRoyaltyWG() As Boolean
        Get
            Return BritishRoyaltyCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            BritishRoyaltyCheckBox.Checked = value
        End Set
    End Property
    Public Property RoyaltyWG() As Boolean
        Get
            Return RoyaltyCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            RoyaltyCheckBox.Checked = value
        End Set
    End Property
    Public Property PoliticianWG() As Boolean
        Get
            Return PoliticianCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            PoliticianCheckBox.Checked = value
        End Set
    End Property
    Public Property ForcePriorityParm() As Boolean
        Get
            Return ForcePriorityParmCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            ForcePriorityParmCheckBox.Checked = value
        End Set
    End Property
    Public Property AutoStub() As Boolean Implements GenericSettingsClass.AutoStub
        Get
            Return AutoStubCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            AutoStubCheckBox.Checked = value
        End Set
    End Property
    Public Property NonBio() As Boolean
        Get
            Return NonBiographyCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            NonBiographyCheckBox.Checked = value
        End Set
    End Property
    WriteOnly Property StubClassModeAllowed() As Boolean Implements GenericSettingsClass.StubClassModeAllowed
        Set(ByVal value As Boolean)
            StubClassCheckBox.Enabled = value
        End Set
    End Property
    Public WriteOnly Property EditTextBox() As TextBox Implements GenericSettingsClass.EditTextBox
        Set(ByVal value As TextBox)
            txtEdit = value
        End Set
    End Property
    Public ReadOnly Property TextInsertContextMenuStripItems() As ToolStripItemCollection _
    Implements GenericSettingsClass.TextInsertContextMenuStripItems
        Get
            Return TextInsertContextMenuStrip.Items
        End Get
    End Property

    ' Event handlers:
    Private Sub LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Template:WPBiography")
    End Sub
    Private Sub ActivePoliticianCheckBox_CheckedChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles ActivePoliticianCheckBox.CheckedChanged
        If ActivePoliticianCheckBox.Checked Then PoliticianCheckBox.Checked = True
    End Sub
    Private Sub AutoStubCheckBox_CheckedChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles AutoStubCheckBox.CheckedChanged
        If AutoStubCheckBox.Checked Then StubClassCheckBox.Checked = False
    End Sub
    Private Sub StubClassCheckBox_CheckedChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles StubClassCheckBox.CheckedChanged
        If StubClassCheckBox.Checked Then AutoStubCheckBox.Checked = False
    End Sub
    Private Sub BritishRoyaltyCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
    Handles BritishRoyaltyCheckBox.CheckedChanged
        If BritishRoyaltyCheckBox.Checked Then RoyaltyCheckBox.Checked = False
    End Sub
    Private Sub RoyaltyCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
    Handles RoyaltyCheckBox.CheckedChanged
        If RoyaltyCheckBox.Checked Then BritishRoyaltyCheckBox.Checked = False
    End Sub
#Region "TextInsertHandlers"
    Private Sub ArtsEntertainmentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArtsEntertainmentToolStripMenuItem.Click
        txtEdit.SelectedText = "|a&e-work-group=yes"
    End Sub
    Private Sub BritishRoyaltyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BritishRoyaltyToolStripMenuItem.Click
        txtEdit.SelectedText = "|british-royalty=yes"
    End Sub
    Private Sub MilitaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MilitaryToolStripMenuItem.Click
        txtEdit.SelectedText = "|military-work-group=yes"
    End Sub
    Private Sub PoliticsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PoliticsToolStripMenuItem.Click
        txtEdit.SelectedText = "|politician-work-group=yes"
    End Sub
    Private Sub RoyaltyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RoyaltyToolStripMenuItem.Click
        txtEdit.SelectedText = "|royalty-work-group=yes"
    End Sub
    Private Sub AttentionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AttentionToolStripMenuItem.Click
        txtEdit.SelectedText = "|attention=yes"
    End Sub
    Private Sub InfoboxToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InfoboxToolStripMenuItem.Click
        txtEdit.SelectedText = "|needs-infobox=yes"
    End Sub
    Private Sub CollabCandidateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CollabCandidateToolStripMenuItem.Click
        txtEdit.SelectedText = "|collaboration-candidate=yes"
    End Sub
    Private Sub PastCollabToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PastCollabToolStripMenuItem.Click
        txtEdit.SelectedText = "|past-collaboration=yes"
    End Sub
    Private Sub PeerReviewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PeerReviewToolStripMenuItem.Click
        txtEdit.SelectedText = "|peer-review=yes"
    End Sub
    Private Sub OldPeerReviewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OldPeerReviewToolStripMenuItem.Click
        txtEdit.SelectedText = "|old-peer-review=yes"
    End Sub
    Private Sub LivingPersonToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LivingPersonToolStripMenuItem.Click
        txtEdit.SelectedText = "|living=yes"
    End Sub
    Private Sub ActivePoliticianToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ActivePoliticianToolStripMenuItem.Click
        txtEdit.SelectedText = "|activepol=yes"
    End Sub
    Private Sub CoreArticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CoreArticleToolStripMenuItem.Click
        txtEdit.SelectedText = "|core=yes"
    End Sub
    Private Sub NonbiographyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NonbiographyToolStripMenuItem.Click
        txtEdit.SelectedText = "|non-bio=yes"
    End Sub
    Private Sub AutotaggedToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AutotaggedToolStripMenuItem.Click
        txtEdit.SelectedText = "|auto=yes"
    End Sub
    Private Sub WPBiographyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WPBiographyToolStripMenuItem.Click
        txtEdit.SelectedText = "{{WPBiography}}"
    End Sub
#End Region
End Class
'End Namespace

Namespace AWB.Plugins.SDKSoftware.Kingbotk
    Friend NotInheritable Class WPBiography
        Inherits PluginBase

        ' Regular expressions:
        Private Shared SkipRegex As New Regex("WPBeatles|\{\{KLF", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Private Shared BLPRegex As New Regex("\{\{\s*(template\s*:\s*|)\s*blp\s*\}\}[\s\n\r]*", _
           RegexOptions.IgnoreCase Or RegexOptions.Compiled Or RegexOptions.ExplicitCapture)
        Private Shared BritishRoyaltyRegex As New Regex("\{\{\s*(template\s*:\s*|)\s*broy\s*(\|[^\}])*\}\}[\s\n\r]*", _
           RegexOptions.IgnoreCase Or RegexOptions.Compiled Or RegexOptions.ExplicitCapture)

        ' Settings:
        Private OurTab As New TabPage("Biography")
        Private WithEvents OurSettingsControl As New WPBiographySettings
        Private Const conEnabled As String = "BioEnabled"
        Protected Friend Overrides ReadOnly Property conPluginShortName() As String
            Get
                Return "Biography"
            End Get
        End Property
        Protected Overrides ReadOnly Property PreferredTemplateNameWiki() As String
            Get
                Return "WPBiography"
            End Get
        End Property
        Protected Overrides ReadOnly Property ParameterBreak() As String
            Get
                Return Microsoft.VisualBasic.vbCrLf
            End Get
        End Property
        Protected Overrides Sub ImportanceParameter(ByVal Importance As Importance)
            Template.NewOrReplaceTemplateParm("priority", Importance.ToString, Me.Article, False)
        End Sub
        Protected Overrides ReadOnly Property OurTemplateHasAlternateNames() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Friend Overrides ReadOnly Property GenericSettings() As GenericSettingsClass
            Get
                Return OurSettingsControl
            End Get
        End Property
        Protected Overrides ReadOnly Property CategoryTalkClassParm() As String
            Get
                Return "Cat"
            End Get
        End Property
        Protected Overrides ReadOnly Property TemplateTalkClassParm() As String
            Get
                Return "Template"
            End Get
        End Property

        ' Initialisation:
        Protected Friend Sub New(ByVal Manager As PluginManager)
            MyBase.New(Manager)
            Const RegexpMiddle As String = "WPBiography|BioWikiProject"
            MainRegex = New Regex(conRegexpLeft & RegexpMiddle & conRegexpRight, conRegexpOptions)
            PreferredTemplateNameRegex = New Regex("[Ww]PBiography", RegexOptions.Compiled)
            SecondChanceRegex = New Regex(conRegexpLeft & RegexpMiddle & conRegexpRightNotStrict, conRegexpOptions)
        End Sub
        Protected Friend Overrides Sub Initialise(ByVal AWBPluginsMenu As ToolStripMenuItem, ByVal txt As TextBox)
            OurMenuItem = New ToolStripMenuItem("Biography Plugin")
            MyBase.InitialiseBase(AWBPluginsMenu, txt) ' must set menu item object first
            OurTab.UseVisualStyleBackColor = True
            OurTab.Controls.Add(OurSettingsControl)
        End Sub

        ' Article processing:
        Protected Overrides ReadOnly Property InspectUnsetParameters() As Boolean
            Get
                Return OurSettingsControl.ForcePriorityParm
            End Get
        End Property
        Protected Overrides Sub InspectUnsetParameter(ByVal Param As String)
            ' We only get called if InspectUnsetParameters is True
            If String.Equals(Param, "importance", StringComparison.CurrentCultureIgnoreCase) Then
                Template.NewTemplateParm("priority", "")
                Article.DoneReplacement("importance", "priority", True, conPluginShortName)
            End If
        End Sub
        Protected Overrides Function SkipIfContains() As Boolean
            ' Skip if contains {{WPBeatles}} or {{KLF}}
            Return (SkipRegex.Matches(Article.AlteredArticleText).Count > 0)
        End Function
        Protected Overrides Sub ProcessArticleFinish()
            Dim Living As Boolean = OurSettingsControl.Living

            With Article
                If (BLPRegex.Matches(.AlteredArticleText).Count > 0) Then
                    .AlteredArticleText = BLPRegex.Replace(.AlteredArticleText, "")
                    .DoneReplacement("{{[[Template:Blp|Blp]]}}", "living=yes", True, conPluginShortName)
                    Living = True
                    .ArticleHasAMinorChange()
                End If

                If (BritishRoyaltyRegex.Matches(.AlteredArticleText).Count > 0) Then
                    .AlteredArticleText = BritishRoyaltyRegex.Replace(.AlteredArticleText, "")
                    .DoneReplacement("{{[[Template:BRoy|BRoy]]}}", "british-royalty=yes", True, conPluginShortName)
                    Template.NewOrReplaceTemplateParm("british-royalty", "yes", Article, False)
                    .ArticleHasAMinorChange()
                End If
            End With

            If Living Then AddAndLogNewParamWithAYesValue("living")

            StubClass()

            With OurSettingsControl
                If .ActivePol Then AddAndLogNewParamWithAYesValue("activepol")
                If .NonBio Then AddAndLogNewParamWithAYesValue("non-bio")
                If .ArtsEntsWG Then AddAndLogNewParamWithAYesValue("a&e-work-group")
                If .MilitaryWG Then AddAndLogNewParamWithAYesValue("military-work-group")
                If .BritishRoyaltyWG Then AddAndLogNewParamWithAYesValue("british-royalty")
                If .RoyaltyWG Then AddAndLogNewParamWithAYesValue("royalty-work-group")
                If .PoliticianWG Then AddAndLogNewParamWithAYesValue("politician-work-group")
            End With
        End Sub
        Protected Overrides Sub TemplateFound()
            With Template
                If .Parameters.ContainsKey("importance") Then
                    If .Parameters.ContainsKey("priority") Then
                        Article.EditSummary += "rm importance param, has priority=, "
                        PluginSettingsControl.MyTrace.WriteArticleActionLine( _
                           "importance parameter removed, has priority=", conPluginShortName)
                    Else
                        .Parameters.Add("priority", _
                           New Templating.TemplateParametersObject("priority", _
                           .Parameters("importance").Value))
                        Article.DoneReplacement("importance", "priority", True, conPluginShortName)
                    End If
                    .Parameters.Remove("importance")
                    Article.ArticleHasAMinorChange()
                End If
            End With
        End Sub
        Protected Overrides Function CreateTemplateHeader(ByRef PutTemplateAtTop As Boolean) As String
            CreateTemplateHeader = "{{WPBiography" & Microsoft.VisualBasic.vbCrLf

            With Template
                If .Parameters.ContainsKey("living") Then
                    CreateTemplateHeader += "|living=" + .Parameters("living").Value + Microsoft.VisualBasic.vbCrLf

                    If .Parameters("living").Value = "yes" Then
                        PluginSettingsControl.MyTrace.WriteArticleActionLine1( _
       "Template contains living=yes, placing at top", conPluginShortName, True)
                        PutTemplateAtTop = True ' otherwise, leave as False
                    End If

                    .Parameters.Remove("living")
                End If
                CreateTemplateHeader += WriteOutClassHeader()

                If .Parameters.ContainsKey("priority") Then
                    CreateTemplateHeader += "|priority=" + .Parameters("priority").Value + _
                       Microsoft.VisualBasic.vbCrLf
                    .Parameters.Remove("priority")
                Else 'elseIf IsWorkGroupSupported Then ' adds too much code
                    CreateTemplateHeader += "|priority=" + Microsoft.VisualBasic.vbCrLf
                End If
                If .Parameters.ContainsKey("royalty-work-group") And .Parameters.ContainsKey("british-royalty") Then
                    If .Parameters("british-royalty").Value = "yes" Then
                        .Parameters.Remove("royalty-work-group")
                        Article.DoneReplacement("royalty-work-group", "british-royalty", True, conPluginShortName)
                    End If
                End If
            End With
        End Function

        'User interface:
        Protected Overrides Sub ShowHideOurObjects(ByVal Visible As Boolean)
            Manager.ShowHidePluginTab(OurTab, Visible)
        End Sub

        ' XML settings:
        Protected Friend Overrides Sub ReadXML(ByVal Reader As System.Xml.XmlTextReader)
            Dim blnNewVal As Boolean = PluginManager.XMLReadBoolean(Reader, conEnabled, Enabled)
            If Not blnNewVal = Enabled Then Enabled = blnNewVal ' Mustn't set if the same or we get extra tabs
            OurSettingsControl.ReadXML(Reader)
        End Sub
        Protected Friend Overrides Sub Reset()
            OurSettingsControl.Reset()
        End Sub
        Protected Friend Overrides Sub WriteXML(ByVal Writer As System.Xml.XmlTextWriter)
            Writer.WriteAttributeString(conEnabled, Enabled.ToString)
            OurSettingsControl.WriteXML(Writer)
        End Sub
    End Class
End Namespace