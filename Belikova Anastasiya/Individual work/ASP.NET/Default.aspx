<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
    </div>

    <h2 align="center">АСУ "Склад"</h2>
    <p>АСУ Склад предназначена для регистрации поставок товаров на склад и учета товаров на складе.</p>
    <div id="flipcountdownbox1"></div>

</asp:Content>

<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <script type="text/javascript" src="/scripts/jquery.min.js"></script>
    <script type="text/javascript" src="/scripts/jquery.flipcountdown.js"></script>
    <link rel="stylesheet" type="text/css" href="/css/jquery.flipcountdown.css" />

    <script type="text/javascript">

        //Отображение времени с помощью плагина "jquery.flipcountdown.js"
        jQuery(function () {
            jQuery('#flipcountdownbox1').flipcountdown();
        })
        jQuery("#flipcountdownbox1").flipcountdown({
            size: "lg"
        });

        $(document).on('ready', function () {
            if(new Date().getHours() < 9 && new Date().getHours() > 18)
                $('#pageBlockContent').append('<p>Все склады Открыты.</p>');
            else
                $('#pageBlockContent').append('<p>Все склады еще закрыты. Склады работают с 9.00 до 18.00.</p>');
        });
    </script>
</asp:Content>


