<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
    </div>
    <div>
        <h2>
            Главная страница фирмы с отделами
        </h2>
        <p>
            Здесь находится информация о фирме
        </p>
        <p>
            Самое странное, что информацию никто не видит!
        </p>
    </div>
</asp:Content>