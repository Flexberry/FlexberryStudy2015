﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="ZakazE.aspx.cs" Inherits="IIS.АСУ_Склад.ЗаказE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Заказ</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlСтатусLabel" runat="server" Text="Статус" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlСтатус" CssClass="descTxt" runat="server">
	<asp:ListItem>Новый</asp:ListItem>
<asp:ListItem>Оплаченный</asp:ListItem>
<asp:ListItem>Отмененный</asp:ListItem>

</asp:DropDownList>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаОтгрузкиLabel" runat="server" Text="Дата отгрузки" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаОтгрузки" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаОплатыLabel" runat="server" Text="Дата оплаты" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаОплаты" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЦенаLabel" runat="server" Text="Цена" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlЦена" runat="server">
</ac:DecimalTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlНомерLabel" runat="server" Text="Номер" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlНомер" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаЗаполненияLabel" runat="server" Text="Дата заполнения" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаЗаполнения" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКладовщикLabel" runat="server" Text="Кладовщик" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlКладовщик" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlКладовщикValidator" runat="server" ControlToValidate="ctrlКладовщик"
ErrorMessage="Не указано: Кладовщик" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКладовщик_ФамилияLabel" runat="server" Text="Фамилия" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlКладовщик_Фамилия" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<asp:ScriptManager ID="ScriptManager1" runat="server" >
</asp:ScriptManager>

<div style="clear: left">
	<ac:AjaxGroupEdit ID="ctrlСтрокаЗаказа" runat="server" ReadOnly="false" />
</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
