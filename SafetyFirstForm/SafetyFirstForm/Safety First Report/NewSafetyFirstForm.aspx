<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSafetyFirstForm.aspx.cs" Inherits="SafetyFirstForm.Layouts.SafetyFirstForm.NewSafetyFirstForm" MasterPageFile="~masterurl/default.master" %>

<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>


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
  <%-- <SharePoint:ScriptLink ID="ScriptLink1" language="javascript" name=".js" OnDemand="true" runat="server" Localizable="false" />--%>
<SharePoint:UIVersionedContent ID="UIVersionedContent1" UIVersion="4" runat="server">
	<ContentTemplate>
	<div style="padding-left:5px">
	</ContentTemplate>
</SharePoint:UIVersionedContent>
	<table class="ms-core-tableNoSpace" id="onetIDListForm">
	 <tr>
	  <td>
	 <WebPartPages:WebPartZone runat="server" FrameType="None" ID="Main" Title="loc:Main">
	 <ZoneTemplate>
     </ZoneTemplate>
</WebPartPages:WebPartZone> 
          <script type="text/javascript" src="../../SiteAssets/jquery.js"></script>
          
          <script type="text/javascript" src="../../SiteAssets/jquery-vsdoc.js"></script>
          
          <script type="text/javascript">
              
              $(document).ready(function () {
                  //Hide print button until necessary
                  $("input[id*='printButton']").hide();

                  $("input[id*='field_AnonymousReporting']").click(function() {
                      if ($("input[id*='field_AnonymousReporting']").is(':checked')) {
                          //alert("Box checked");
                          $("input[id*='printButton']").show();
                          $("input[id*='savebutton']").hide();
                          $('.anonymousSubmission').hide();
                      } else {
                          //alert("Box unchecked");
                          $("input[id*='printButton']").hide();
                          $("input[id*='savebutton']").show();
                          $('.anonymousSubmission').show();
                      }
                  });
              });

        </script>

          <!-- Begin Custom Form -->
          <!-- ikarstein: Insert such a structure for each field you want to show on you page --> 
          <div id="PrintForm">      
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
                                             <SharePoint:FormField  runat="server"  ID="field_IncidentReportingDate"  ControlMode="New"  FieldName="IncidentReportingDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_IncidentReportingDate_Description"  FieldName="IncidentReportingDate" /> 
                                         </td> 
                                     </tr> 
                                         
                                     <tr id="loggedByRow" class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Logged By<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_LoggedBy"  ControlMode="New"  FieldName="LoggedBy"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LoggedBy_Description"  FieldName="LoggedBy" /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Job Title</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_JobTitle"  ControlMode="New"  FieldName="JobTitle"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_JobTitle_Description"  FieldName="JobTitle"  /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Department</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Department"  ControlMode="New"  FieldName="ol_Department"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Department_Description"  FieldName="ol_Department"  /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Division/Work Location</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Division"  ControlMode="New"  FieldName="Division"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Division_Description"  FieldName="Division"  /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Primary Phone<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_PrimaryNumber"  ControlMode="New"  FieldName="PhoneNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_PrimaryNumber_Description"  FieldName="PhoneNumber"  /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Mobile Phone</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_CellPhone"  ControlMode="New"  FieldName="CellPhone"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_CellPhone_Description"  FieldName="CellPhone"  /> 
                                         </td>
                                     </tr>
                                     <tr class="anonymousSubmission">
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>E-Mail<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_EMail"  ControlMode="New"  FieldName="EMail"  /> 
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
                                             <SharePoint:FormField  runat="server"  ID="field_BusNumber"  ControlMode="New"  FieldName="BusNumber"  /> 
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
                                             <SharePoint:FormField  runat="server"  ID="field_BusRouteNumber"  ControlMode="New"  FieldName="BusRouteNumber"  /> 
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
                                             <SharePoint:FormField  runat="server"  ID="field_BusGarage"  ControlMode="New"  FieldName="BusGarage"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_BusGarage_Description"  FieldName="BusGarage"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Location, Vehicle and/or Equipment Referenced<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_LVEReferenced"  ControlMode="New"  FieldName="LVEReferenced"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LVEReferenced_Description"  FieldName="LVEReferenced"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Date of Incident<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_IncidentDate"  ControlMode="New"  FieldName="IncidentOccurrenceDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_IncidentOccurrenceDate_Description"  FieldName="IncidentOccurrenceDate"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Hazard Description<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_HazardDescription"  ControlMode="New"  FieldName="HazardDescription"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_HazardDescription_Description"  FieldName="HazardDescription"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Employee Recommended Changes<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_EmployeeRecChanges"  ControlMode="New"  FieldName="EmployeeRecChanges"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_EmployeeRecChanges_Description"  FieldName="EmployeeRecChanges"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Resolution Status</nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_ResolutionStatus"  ControlMode="Display"  FieldName="ResolutionStatus"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ResolutionStatus_Description"  FieldName="ResolutionStatus"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Supervisor<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Supervisor"  ControlMode="New"  FieldName="Supervisor"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Supervisor_Description"  FieldName="Supervisor"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Director<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Director"  ControlMode="New"  FieldName="Director"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Director_Description"  FieldName="Director"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>AGM<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AGM"  ControlMode="New"  FieldName="AGM"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AGM_Description"  FieldName="AGM"  /> 
                                         </td>
                                     </tr>
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Anonymous Reporting<span class="ms-formvalidation"> *</span></nobr> 
                                             </h3> 
                                         </td>
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AnonymousReporting"  ControlMode="New"  FieldName="AnonymousReporting" /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AnonymousReporting_Description"  FieldName="AnonymousReporting" /> 
                                         </td>
                                     </tr> 
                                     
              </div>
                                     

                                     <!-- ikarstein: Add this table for "Save" and "Cancel" buttons / BEGIN --> 
                                     <tr>
                                        <td colspace="2">
                                             <table  width="100%"  border="0"  cellspacing="0"> 
                                                 <tr> 
                                                     <td  width="99%"  class="ms-toolbar"  nowrap="nowrap"> 
                                                         <img  src="/_layouts/images/blank.gif"  width="1"  height="18"  /> 
                                                     </td> 
                                                      <td  class="ms-toolbar"  nowrap="nowrap"> 
                                                         <asp:Button ID="printButton" Text="Print" runat="server" OnClick="printbutton_Click" /> 
                                                    </td> 
                                                     <td  class="ms-toolbar"  nowrap="nowrap"> 
                                                         <SharePoint:SaveButton  runat="server"  ControlMode="Edit"  ID="savebutton"   /> 
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
