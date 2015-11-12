<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
        <div class="mymenu">
            <asp:Table runat="server" Width="300" Height="200" >
                <asp:TableRow>
                    <asp:TableCell>
                        <a href="/forms/CHelovek/CHelovekL.aspx">
                            <asp:Image runat="server" ImageUrl="~/App_Themes/BaseTheme/Pages/MainPage/Images/chelovek.png" />
                        </a>
                    </asp:TableCell>
                    <asp:TableCell>
                        <a href="/forms/Postuplenie/PostuplenieL.aspx">
                            <asp:Image runat="server" ImageUrl="~/App_Themes/BaseTheme/Pages/MainPage/Images/postuplenie.png" />
                        </a>
                    </asp:TableCell>
                    <asp:TableCell>
                        <a href="/forms/Tovar/TovarL.aspx">
                            <asp:Image runat="server" ImageUrl="~/App_Themes/BaseTheme/Pages/MainPage/Images/tovar.png" />
                        </a>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table> 
        </div>
    </div>
</asp:Content>