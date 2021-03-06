﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/brdhc.master" Theme="Theme" CodeFile="approveAppointment.aspx.cs" Inherits="approveAppointment" %>

<%@ MasterType VirtualPath="~/brdhc.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphSiteMasterBody" runat="Server">
    <%--REquired--%>
    <asp:Panel ID="pnlContainer" Style="display: inline-block; width: 79%;" runat="server">
        <asp:Panel ID="pnlHead" CssClass="pnlHead" runat="server">
            <asp:Label ID="lblDashboard" CssClass="lblDashboard" runat="server" />
            <%-- Dashboard Menu button for mobile version --%>
            <asp:LinkButton ID="mnuToggle" CssClass="dashboardMenuBtn btn" PostBackUrl="#" runat="server" Text="DASHBOARD MENU" />
        </asp:Panel>
        <asp:Panel ID="pnlDashboard" CssClass="pnlDashboard fullWidth" runat="server">
            <asp:Panel ID="pnlContent" CssClass="pnlContent fullWidth " runat="server">
                <asp:Panel ID="pnlEmpty" runat="server">
                    <asp:Label ID="lblEmpty" runat="server" Text="You have no appointments" />
                </asp:Panel>
                <asp:Panel ID="pnlApp" runat="server">
                    <%-- DataList to show all appointment status --%>
                        <asp:DataList ID="dlApp" runat="server" OnItemDataBound="dlApp_ItemDataBound" OnItemCommand="dlApp_ItemCommand">
                            <HeaderTemplate>
                                <tr>
                                    <td>Patient Name</td>
                                    <td>Date</td>
                                    <td>Time </td>
                                    <td>Reason</td>
                                    <td>Request Status</td>
                                </tr>
                            </HeaderTemplate>
                            <%-- appointment info from the brdhc_PatientsAppointment table--%>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:HiddenField ID="hdfPID" runat="server" Value='<%#Eval("PatientUserId") %>' /> 
                                        <%#Eval("PatientName") %> 
                                    </td>
                                    <td>
                                        <%#Eval("AppointmentDate", "{0:d}") %>
                                    </td>
                                    <td>
                                        <%#Eval("AppointmentTime") %>
                                    </td>
                                    <td>
                                        <%#Eval("Reason") %>
                                    </td>
                                    <td>
                                        <%#Eval("approvalStatus") %>
                                        <br />
                                        <%-- HiddenField to get all current approval status --%>
                                        <asp:HiddenField ID="hdfStatus" runat="server" Value='<%#Eval("approvalStatus") %>' />
                                        <%-- radio button will be selected according to approvalStatus --%>
                                        <asp:RadioButtonList ID="rbApprove" runat="server" ValidationGroup='<%#Eval("AppointmentId") %>'>
                                            <asp:ListItem Value="Accept">Accept</asp:ListItem>
                                            <asp:ListItem Value="Reject">Reject</asp:ListItem>
                                            <asp:ListItem Value="Pending">Pending</asp:ListItem>
                                        </asp:RadioButtonList>
                                        <%-- AppointmentId is used as the validation group so that the validation group is different for every row --%>
                                        <asp:RequiredFieldValidator ValidationGroup='<%#Eval("AppointmentId") %>' Text="Select option to send response" ControlToValidate="rbApprove" runat="server" Display="Static" />
                                        <asp:Button ID="btnResponse" runat="server" Text="Send Response" CommandArgument='<%#Eval("AppointmentId") %>' CommandName="select" ValidationGroup='<%#Eval("AppointmentId") %>' />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:DataList>
                    
                </asp:Panel>


            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>

