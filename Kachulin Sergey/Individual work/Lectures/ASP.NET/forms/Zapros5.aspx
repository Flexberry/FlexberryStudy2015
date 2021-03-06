﻿<%--flexberryautogenerated="true"--%>

<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Zapros5.aspx.cs" Inherits="IIS.Lectures.Запрос5" Title="Untitled Page" %>

<%@ Import Namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
    Тетради с самыми долгими предметами
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.ListFormHeaderCssClass %>">Тетради с самыми долгими предметами
    </h2>
    <div>
        <asp:Label runat="server" ID="label5" CssClass="userLable" Text="Количество предметов, которые будут выведены:" />
        <ac:AlphaNumericTextBox runat="server" ID="textBox5" CssClass="userTextBox" Text="1"/>
        <asp:Button runat="server" Text="Поиск" ID="button5" CssClass="userButton" OnClick="button5_Click" />
    </div>
    <div>
        <asp:Table runat="server" CssClass="userTable" ID="table5">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text="Номер п/п" CssClass="tNum" />
                <asp:TableHeaderCell Text="Название предмета" CssClass="tName" />
                <asp:TableHeaderCell Text="Количество семестров" CssClass="tSNum" />
                <asp:TableHeaderCell Text="Название тетради" CssClass="tName" />
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
