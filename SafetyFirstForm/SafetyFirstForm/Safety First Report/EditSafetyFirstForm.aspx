<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSafetyFirstForm.aspx.cs" Inherits="SafetyFirstForm.Layouts.SafetyFirstForm.EditSafetyFirstForm" MasterPageFile="~masterurl/default.master" %>

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
	<table class="ms-core-tableNoSpace" id="onetIDListForm">
	 <tr>
	  <td>
	 <WebPartPages:WebPartZone runat="server" FrameType="None" ID="Main" Title="loc:Main"><ZoneTemplate>
		
		</ZoneTemplate></WebPartPages:WebPartZone>

          <!-- Begin Custom Form -->
          <!-- ikarstein: Insert such a structure for each field you want to show on you page --> 
                 <table id="agendaFormTable"  border="0"  width="100%"> 
                     <tr> 
                         <td  class="ms-toolbar"  nowrap="nowrap"> 
                            <SharePoint:FormToolBar ID="FormToolBar1"  runat="server"  ControlMode="Edit"  /> 
                         </td> 
                     </tr> 
                     <tr> 
                         <td> 
                             <span  id="part1">  <!-- ikarstein: This line is important for "Attachments" --> 
                                 <table  border="0"  cellspacing="0"  width="100%"> 
                                    
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Incident Reporting Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="IncidentReportingDateField"  ControlMode="Display"  FieldName="IncidentReportingDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_IncidenceReportingDate_Description"  FieldName="IncidentReportingDate" /> 
                                         </td> 
                                     </tr> 
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Logged By</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="LoggedByField"  ControlMode="Display"  FieldName="LoggedBy"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LoggedBy_Description"  FieldName="LoggedBy" /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Job Title</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="JobTitleField"  ControlMode="Display"  FieldName="JobTitle"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_JobTitle_Description"  FieldName="JobTitle"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Department</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DepartmentField"  ControlMode="Display"  FieldName="ol_Department"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Department_Description"  FieldName="ol_Department"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Division/Work Location</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DivisionField"  ControlMode="Display"  FieldName="Division"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Division_Description"  FieldName="Division"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Primary Phone</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="PrimaryNumberField"  ControlMode="Display"  FieldName="PhoneNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_PrimaryNumber_Description"  FieldName="PhoneNumber"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Mobile Phone</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="CellPhoneField"  ControlMode="Display"  FieldName="CellPhone"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_CellPhone_Description"  FieldName="CellPhone"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>E-Mail</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="EMailField"  ControlMode="Display"  FieldName="EMail"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_EMail_Description"  FieldName="EMail"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Bus Number</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="BusNumberField"  ControlMode="Display"  FieldName="BusNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_BusNumber_Description"  FieldName="BusNumber"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Bus Route Number</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="BusRouteNumberField"  ControlMode="Display"  FieldName="BusRouteNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_BusRouteNumber_Description"  FieldName="BusRouteNumber"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Bus Garage</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="BusGarageField"  ControlMode="Display"  FieldName="BusGarage"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_BusGarage_Description"  FieldName="BusGarage"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Location, Vehicle and/or Equipment Referenced</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="LVEReferencedField"  ControlMode="Display"  FieldName="LVEReferenced"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LVEReferenced_Description"  FieldName="LVEReferenced" Visible="false"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Date of Incident</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="IncidentDateField"  ControlMode="Display"  FieldName="IncidentOccurenceDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_IncidentOccurenceDate_Description"  FieldName="IncidentOccurenceDate"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Hazard Description</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="HazardDescriptionField"  ControlMode="Display"  FieldName="HazardDescription"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_HazardDescription_Description"  FieldName="HazardDescription" Visible="false"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Employee Recommended Changes</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="EmployeeRecChangesField"  ControlMode="Display"  FieldName="EmployeeRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_EmployeeRecChanges_Description"  FieldName="EmployeeRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Resolution Status<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="ResolutionStatusField"  ControlMode="Display"  FieldName="ResolutionStatus" OnValueChanged="ResolutionStatusField_ValueChanged"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ResolutionStatus_Description"  FieldName="ResolutionStatus"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Supervisor</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="SupervisorField"  ControlMode="Display"  FieldName="Supervisor"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Supervisor_Description"  FieldName="Supervisor"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Supervisor Recommended Changes</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="SupervisorRecChangesField"  ControlMode="Display"  FieldName="SupervisorRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_SupervisorRecChanges"  FieldName="SupervisorRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Supervisor/Employee Initial Contact</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="InitialContactField"  ControlMode="Display"  FieldName="InitialContact"  /> <asp:panel ID="ConditionalBreak" runat="server" visible="true"></br></asp:panel> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_InitialContact_Description"  FieldName="InitialContact"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <asp:Panel ID="pnlComplete" runat="server" Visible="false">
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Resolution Complete Discussion</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="ResolutionCompleteDiscussionField"  ControlMode="Display"  FieldName="ResolutionCompleteDiscussion"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ResolutionCompleteDiscussion_Description"  FieldName="ResolutionCompleteDiscussion"  /> 
                                         </td>
                                     </tr>
                                             </asp:Panel>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Director</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DirectorField"  ControlMode="Display"  FieldName="Director"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Director_Description"  FieldName="Director"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Director Recommended Changes</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DirectorRecChangesField"  ControlMode="Display"  FieldName="DirectorRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DirectorRecChanges_Description"  FieldName="DirectorRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>AGM</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="AGMField"  ControlMode="Display"  FieldName="AGM"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AGM_Description"  FieldName="AGM"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>AGM Recommended Changes</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="AGMRecChangesField"  ControlMode="Display"  FieldName="AGMRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AGMRecChanges_Description"  FieldName="AGMRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Delegated Resource</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DelegatedResourceField"  ControlMode="Display"  FieldName="DelegatedResource"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DelegatedResource_Description"  FieldName="DelegatedResource"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Delegated Resource Recommended Changes</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="DelegatedRecChangesField"  ControlMode="Display"  FieldName="DelegatedRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DelegatedRecChanges_Description"  FieldName="DelegatedRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Pre-Hira Code</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="PreHIRACodeField"  ControlMode="Display"  FieldName="PreHIRACode"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_PreHIRACode_Description"  FieldName="PreHIRACode"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Post-HIRA Code</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="PostHIRACodeField"  ControlMode="Display"  FieldName="PostHIRACode"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_PostHIRACode_Description"  FieldName="PostHIRACode"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>HIRA Chart</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <asp:Image ID="imgHIRAChart" runat="server" ImageUrl="<% $SPUrl:~sitecollection/SiteAssets/HIRAChart.png %>" /> 
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
