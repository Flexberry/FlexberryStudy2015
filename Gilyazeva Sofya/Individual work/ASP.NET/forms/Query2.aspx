﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query2.aspx.cs" Inherits="IIS.Книги.Query2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><asp:Label ID="Label1" runat="server" Text="Здесь вы можете посмотреть названия книг, которые написали максимальное количество авторов"></asp:Label>
    <br />
    <asp:Button ID="btFind" runat="server" OnClick="btFind_Click" Text="Найти" />
    <asp:BulletedList ID="blBooks" runat="server">
    </asp:BulletedList>
        <br />
    <asp:Label ID="lbCount" runat="server" Text="Количество авторов: " />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
