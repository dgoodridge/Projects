<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSafety1stForm.aspx.cs" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" %>

<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:ListFormPageTitle ID="ListFormPageTitle1" runat="server"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server">
	<span class="die">
		<SharePoint:ListProperty Property="LinkTitle" runat="server" id="ID_LinkTitle"/>
	</span>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderId="PlaceHolderPageImage" runat="server">
	<img src="/_layouts/15/images/blank.gif?rev=23" width='1' height='1' alt="" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderId="PlaceHolderMain" runat="server">
<SharePoint:UIVersionedContent ID="UIVersionedContent1" UIVersion="4" runat="server">
	<ContentTemplate>
	<div style="padding-left:5px">
	</ContentTemplate>
</SharePoint:UIVersionedContent>
    <h1>Safety 1st Form</h1>
	<table class="ms-core-tableNoSpace" id="onetIDListForm">
	 <tr>
	  <td>
	 <WebPartPages:WebPartZone runat="server" FrameType="None" ID="Main" Title="loc:Main">
	 
	 <ZoneTemplate>
	 
	 </ZoneTemplate>
	 
	 </WebPartPages:WebPartZone>

          <!-- Begin Custom Form -->
          <!-- ikarstein: Insert such a structure for each field you want to show on you page --> 
                 <table id="agendaFormTable"  border="0"  width="100%"> 
                     <tr> 
                         <td  class="ms-toolbar"  nowrap="nowrap"> 
                            <SharePoint:FormToolBar ID="FormToolBar1"  runat="server"  ControlMode="New"  /> 
                         </td> 
                     </tr> 
                     <tr> 
                         <td> 
                             <span  id="part1">  <!-- ikarstein: This line is important for "Attachments" --> 
                                 <table  border="0"  cellspacing="0"  width="100%"> 
                                    
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Title<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Title"  ControlMode="Edit"  FieldName="Title"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Title_Description"  FieldName="Title" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                     
                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Agenda Order<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AgendaOrder"  ControlMode="Edit"  FieldName="AgendaOrder"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AgendaOrder_Description"  FieldName="AgendaOrder" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 

                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Presenter</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Presenter"  ControlMode="Edit"  FieldName="Presenter"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Presenter_Description"  FieldName="Presenter" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 

                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Owner</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Owner"  ControlMode="Edit"  FieldName="Owner"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Owner_Description"  FieldName="Owner" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 

                                     <tr>
                                        <td valign="top" colspan="2" class="ms-formlabel">
                                            Change Meeting for this Agenda:
                                        </td>
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Committee</nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Committee"  ControlMode="New" FieldName="Committee"   /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Committee_Description"  FieldName="Committee" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Committee Meetings</nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <asp:DropDownList ID="ddlCategories" runat="server" />
                                         </td> 
                                     </tr> 
                                    

                                    <tr class="invisible"> 
                                        <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                            <h3  class="ms-standardheader"> 
                                                <nobr> Meeting ID</nobr> 
                                        </h3> 
                                        </td> 
                                        <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_MeetingID"  ControlMode="New"  FieldName="CommitteeMeeting"  /> 
                                            
                                        </td> 
                                    </tr>
                                    

                                     <!-- ikarstein: Add this table for "Save" and "Cancel" buttons / BEGIN --> 
                                     <tr>
                                        <td colspace="2">
                                             <table  width="100%"  border="0"  cellspacing="0"> 
                                                 <tr> 
                                                     <td  width="99%"  class="ms-toolbar"  nowrap="nowrap"> 
                                                         <img  src="/_layouts/images/blank.gif"  width="1"  height="18"  /> 
                                                     </td> 
                                                     <td  class="ms-toolbar"  nowrap="nowrap"> 
                                                         <SharePoint:SaveButton  runat="server"  ControlMode="Edit"  ID="savebutton"  /> 
                                                    </td> 
                                                     <td  class="ms-separator"> 
                                                     </td> 
                                                     <td  class="ms-toolbar"  nowrap="nowrap"  align="right"> 
                                                         <SharePoint:GoBackButton  runat="server"  ControlMode="Edit"  ID="gobackbutton"  /> 
                                                     </td> 
                                                 </tr> 
                                         </table> 
                                        </td>
                                     </tr>
                                    
                                     
                             </span> 
                             <SharePoint:AttachmentUpload ID="AttachmentUpload1"  runat="server"  ControlMode="Edit"  /> 
                             <SharePoint:ItemHiddenVersion ID="ItemHiddenVersion1"  runat="server"  ControlMode="Edit"  /> 
                         </td> 
                     </tr> 
                 </table> 
	  </td>
	 </tr>
	</table>
<SharePoint:UIVersionedContent ID="UIVersionedContent2" UIVersion="4" runat="server">
	<ContentTemplate>
	</div>
	</ContentTemplate>
</SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
	<SharePoint:DelegateControl ID="DelegateControl1" runat="server" ControlId="FormCustomRedirectControl" AllowMultipleControls="true"/>
	<SharePoint:UIVersionedContent ID="UIVersionedContent3" UIVersion="4" runat="server"><ContentTemplate>
		<SharePoint:CssRegistration Name="forms.css" runat="server"/>
	</ContentTemplate></SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderId="PlaceHolderTitleLeftBorder" runat="server">
<table cellpadding="0" height="100%" width="100%" cellspacing="0">
 <tr><td class="ms-areaseparatorleft"><img src="/_layouts/15/images/blank.gif?rev=23" width='1' height='1' alt="" /></td></tr>
</table>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderId="PlaceHolderTitleAreaClass" runat="server">
<script type="text/javascript" id="onetidPageTitleAreaFrameScript">
    if (document.getElementById("onetidPageTitleAreaFrame") != null) {
        document.getElementById("onetidPageTitleAreaFrame").className = "ms-areaseparator";
    }
</script>
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderId="PlaceHolderBodyAreaClass" runat="server">
<SharePoint:StyleBlock ID="StyleBlock1" runat="server">
.ms-bodyareaframe {
	padding: 8px;
	border: none;
}
</SharePoint:StyleBlock>
</asp:Content>
<asp:Content ID="Content9" ContentPlaceHolderId="PlaceHolderBodyLeftBorder" runat="server">
<div class='ms-areaseparatorleft'><img src="/_layouts/15/images/blank.gif?rev=23" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ID="Content10" ContentPlaceHolderId="PlaceHolderTitleRightMargin" runat="server">
<div class='ms-areaseparatorright'><img src="/_layouts/15/images/blank.gif?rev=23" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ID="Content11" ContentPlaceHolderId="PlaceHolderBodyRightMargin" runat="server">
<div class='ms-areaseparatorright'><img src="/_layouts/15/images/blank.gif?rev=23" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ID="Content12" ContentPlaceHolderId="PlaceHolderTitleAreaSeparator" runat="server"/>
