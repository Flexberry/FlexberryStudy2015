﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query5.aspx.cs" Inherits="IIS.Книги.Query5" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Здесь вы можете посмотреть названия книг, количество страниц в которых больше среднего"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Найти" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Результаты поиска"></asp:Label>
    </div>
    <div>
        <ac:WebObjectListView runat="server" ID="WOLV" />
        <asp:Label ID="lbAver" runat="server" Text="Среднее значение: "></asp:Label>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
