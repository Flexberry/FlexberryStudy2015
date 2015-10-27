﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="PredmetVSemestreE.aspx.cs" Inherits="IIS.Lectures.ПредметВСеместреE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Предмет в семестре</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСеместрLabel" runat="server" Text="Семестр" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlСеместр" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlСеместрValidator" runat="server" ControlToValidate="ctrlСеместр"
ErrorMessage="Не указано: Семестр" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПредметLabel" runat="server" Text="Предмет" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlПредмет" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlПредметValidator" runat="server" ControlToValidate="ctrlПредмет"
ErrorMessage="Не указано: Предмет" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
