﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="PostuplenieE.aspx.cs" Inherits="IIS.Indiv_Bahtin.ПоступлениеE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Поступление</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlКоличетствоLabel" runat="server" Text="Количетство" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlКоличетство" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlТоварLabel" runat="server" Text="Товар" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlТовар" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlТоварValidator" runat="server" ControlToValidate="ctrlТовар"
ErrorMessage="Не указано: Товар" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlТовар_НаименованиеLabel" runat="server" Text="Наименование" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlТовар_Наименование" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlАвтомашинаLabel" runat="server" Text="Автомашина" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlАвтомашина" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlАвтомашинаValidator" runat="server" ControlToValidate="ctrlАвтомашина"
ErrorMessage="Не указано: Автомашина" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlАвтомашина_МаркаLabel" runat="server" Text="Марка" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlАвтомашина_Марка" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСкладLabel" runat="server" Text="Склад" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlСклад" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlСкладValidator" runat="server" ControlToValidate="ctrlСклад"
ErrorMessage="Не указано: Склад" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСклад_НазваниеLabel" runat="server" Text="Название" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlСклад_Название" runat="server" ReadOnly="true">
</asp:TextBox>

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
