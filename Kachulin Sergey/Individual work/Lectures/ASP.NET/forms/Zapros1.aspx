﻿<%--flexberryautogenerated="false"--%>

<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Zapros1.aspx.cs" Inherits="IIS.Lectures.Запрос1" Title="Untitled Page" %>

<%@ Import Namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
    Поиск тетрадей по предмету
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.ListFormHeaderCssClass %>">Поиск тетрадей по предмету</h2>
    <div>
        <asp:Label runat="server" ID="label1" CssClass="userLable" Text="Введите предмет" />
        <asp:DropDownList runat="server" ID="dropDownList1" EnableViewState="true" />
        <asp:Button runat="server" Text="Поиск" ID="button1" CssClass="userButton" OnClick="button1_Click" />
    </div>
    <div>
        <asp:Table runat="server" CssClass="userTable" ID="table1">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text="Номер п/п" CssClass="tNum" />
                <asp:TableHeaderCell Text="Название" CssClass="tName" />
                <asp:TableHeaderCell Text="Цвет обложки" CssClass="tColor" />
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>