﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="AvtomashinaE.aspx.cs" Inherits="IIS.Indiv_Bahtin.АвтомашинаE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Автомашина</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlМаркаLabel" runat="server" Text="Марка" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlМарка" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlГрузоподъемностьLabel" runat="server" Text="Грузоподъемность" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlГрузоподъемность" runat="server">
</ac:DecimalTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlВладелецАвтомашиныLabel" runat="server" Text="Владелец автомашины" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlВладелецАвтомашины" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlВладелецАвтомашиныValidator" runat="server" ControlToValidate="ctrlВладелецАвтомашины"
ErrorMessage="Не указано: ВладелецАвтомашины" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlВладелецАвтомашины_ФамилияLabel" runat="server" Text="Фамилия" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlВладелецАвтомашины_Фамилия" runat="server" ReadOnly="true">
</asp:TextBox>

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
