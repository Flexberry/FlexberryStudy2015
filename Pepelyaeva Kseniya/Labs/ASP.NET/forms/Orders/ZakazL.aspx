﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ZakazL.aspx.cs" Inherits="IIS.АСУСклад.ЗаказL" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.ListFormHeaderCssClass %>">Заказ</h2>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.ListFormControlsCssClass %>">
            <ac:WebObjectListView ID="WebObjectListView1" runat="server" Visible="true" />
        </div>
    </div>
</asp:Content>
