<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
    </div>
    <div style="background-image: url('1832342.png');     background-repeat: no-repeat;
    width: 100%;
    height: 400px;
    background-position: center">
        Добро пожаловать в систему "Книги"!<br />
        Данная система предназначена для создания, редактирования, хранения списков книг, написанных одним автором.<br />
        Для начала работы в меню выберите необходимый пункт. 

      
    </div>
</asp:Content>