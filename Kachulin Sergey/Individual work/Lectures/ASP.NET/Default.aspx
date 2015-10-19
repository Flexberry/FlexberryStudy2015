<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
        С возвращением! Без вас здесь было скучно..
        <div id="counter">Счетчик: <span>0</span></div>
        <div id="game" onmousedown="return false" onselectstart="return false">
            <div id="gameBlock">
                Клик!<br />
                Клик!<br />
                Клик!
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder0">
    <script>
        var c = 0;

        $(document).on('click', '#gameBlock', function () {
            c++;            
            var position = $('#gameBlock').position();
            var l = position.left;
            var t = position.top;
            var w = $('#game').width();
            var h = $('#game').height();

            var r = Math.round(Math.random());

            // если 0 - вертикально, если 1 - горизонтально
            if (r) {
                // alert(r + ' ' + l + ' ' + w);
                if (l < 60) {
                    // сдвиг вправо
                    $("#gameBlock").css({ left: "+=50" });
                } else if (l > w - 90) {
                    // сдвиг влево
                    $("#gameBlock").css({ left: "-=50" });
                } else {
                    var rh = Math.round(Math.random());
                    if (rh) {
                        // сдвиг вправо
                        $("#gameBlock").css({ left: "+=50" });
                    } else {
                        // сдвиг влево
                        $("#gameBlock").css({ left: "-=50" });
                    }
                }
            } else {
                if (t < 60) {
                    // сдвиг вниз
                    $("#gameBlock").css({ top: "+=50" });
                } else if (l > h - 110) {
                    // сдвиг вверх
                    $("#gameBlock").css({ top: "-=50" });
                } else {
                    var rv = Math.round(Math.random());
                    if (rv) {
                        // сдвиг вниз
                        $("#gameBlock").css({ top: "+=50" });
                    } else {
                        // сдвиг вверх
                        $("#gameBlock").css({ top: "-=50" });
                    }
                }
            }

            $('#counter span').text(c);

        });
    </script>
</asp:Content>
