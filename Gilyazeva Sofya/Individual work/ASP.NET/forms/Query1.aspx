﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="IIS.Книги.Query1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Здесь вы можете увидеть авторов, имеющих максимальное количество книг"></asp:Label>
    <br />
    <asp:Button ID="btFind" runat="server" OnClick="btFind_Click" Text="Найти" />
    <asp:BulletedList ID="blAuthors" runat="server">
    </asp:BulletedList>
        <br />
        <asp:Label ID="lbCount" runat="server" Text="Количество книг: " />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
