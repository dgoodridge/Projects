<%@ Page language="C#" MasterPageFile="~masterurl/default.master"    Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %> <%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:EncodedLiteral runat="server" text="<%$Resources:wss,multipages_homelink_text%>" EncodeMethod="HtmlEncode"/> - <SharePoint:ProjectProperty Property="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server"><img src="/_layouts/15/images/blank.gif?rev=23" width='1' height='1' alt="" /></asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server">
		Diagrams <SharePoint:FieldValue id="PageTitle" FieldName="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleAreaClass" runat="server">
<SharePoint:UIVersionedContent runat="server" UIVersion="<=3">
	<ContentTemplate>
		<style type="text/css">
		td.ms-titleareaframe, .ms-pagetitleareaframe {
			height: 10px;
		}
		div.ms-titleareaframe {
			height: 100%;
		}
		.ms-pagetitleareaframe table {
			background: none;
			height: 10px;
		}
		</style>
	</ContentTemplate>
</SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
	<meta name="CollaborationServer" content="SharePoint Team Web Site" />
<SharePoint:StyleBlock runat="server">
.s4-nothome {
	display:none;
}
</SharePoint:StyleBlock>
	<SharePoint:ScriptBlock runat="server">
	var navBarHelpOverrideKey = "WSSEndUser";
	</SharePoint:ScriptBlock>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderSearchArea" runat="server">
	<SharePoint:DelegateControl runat="server"
		ControlId="SmallSearchInputBox" />
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderLeftActions" runat="server" />
<asp:Content ContentPlaceHolderId="PlaceHolderPageDescription" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyAreaClass" runat="server">
<SharePoint:StyleBlock runat="server">
.ms-bodyareaframe {
	padding: 0px;
}
</SharePoint:StyleBlock>
</asp:Content>
<asp:Content ID="Content12" runat="server" ContentPlaceHolderID="PlaceHolderMain">

   <table border="0" cellpadding="4" cellspacing="0" width="100%">
        <tr>
            <td id="tlc" height="100%" name="_invisibleIfEmpty" valign="top" style="width:50%">
                <WebPartPages:WebPartZone ID="TopLeftColumn" runat="server" FrameType="TitleBarOnly" Title="Top Left Column"></WebPartPages:WebPartZone></td>
            <td id="trc" height="100%" name="_invisibleIfEmpty" valign="top" style="width:50%">
                <WebPartPages:WebPartZone ID="TopRightColumn" runat="server" FrameType="TitleBarOnly" Title="Top Right Column"></WebPartPages:WebPartZone></td>
        </tr>
        <tr>
            <td id="blc" height="100%" name="_invisibleIfEmpty" valign="top" style="width:50%">
                <WebPartPages:WebPartZone ID="BottomLeftColumn" runat="server" FrameType="TitleBarOnly" Title="Bottom Left Column"></WebPartPages:WebPartZone></td>
            <td id="brc" height="100%" name="_invisibleIfEmpty" valign="top" style="width:50%">
                <WebPartPages:WebPartZone ID="BottomRightColumn" runat="server" FrameType="TitleBarOnly" Title="Bottom Right Column"></WebPartPages:WebPartZone></td>
        </tr>
        <SharePoint:ScriptBlock ID="ScriptBlock1" runat="server">if(typeof(MSOLayout_MakeInvisibleIfEmpty) == "function") {MSOLayout_MakeInvisibleIfEmpty();}</SharePoint:ScriptBlock>
    </table>
</asp:Content>