﻿<%@ Page Title="" Language="C#" MasterPageFile="~/brdhc.master" AutoEventWireup="true" Theme="HealthTools" CodeFile="BillThankYou.aspx.cs" Inherits="BillThankYou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphSiteMasterBody" Runat="Server">
     <asp:Panel ID="pnlContent" CssClass="pnlContent" runat="server">
        <div class="bootContainer">
    <%-- Capture data in querystring and display message according to status --%>

    <asp:Label ID="lblData" runat="server" />
            </div>
         </asp:Panel>
</asp:Content>

