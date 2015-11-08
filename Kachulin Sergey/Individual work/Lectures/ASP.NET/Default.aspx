<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
        С возвращением! Без вас здесь было скучно..<br />
        <input type="button" id="startBtn" value="Поиграем?" />

        <div id="counts">
            <div id="timer">Время: <span>00 : 00</span></div>
            <div id="counter">Счетчик: <span>0</span></div>
            <div id="bestTime">Лучший результат: <span>0</span></div>
        </div>

        <div id="gameForm">
            <div id="game" onmousedown="return false" onselectstart="return false">
                <div id="gameBlock">
                    Клик!<br />
                    Клик!<br />
                    Клик!
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder0">
    <script>
        var count = 0;

        function setTimer(time) {
            var minutes = parseInt(time / 60);
            var seconds = parseInt(time - minutes * 60);

            if (minutes < 1) minutes = 0;
            if (minutes < 10) minutes = '0' + minutes;
            if (seconds < 10) seconds = '0' + seconds;

            $('#timer span').html(minutes + ' : ' + seconds);
            
            if (time > 0) {
                time--;
                timerId = setTimeout(function () { setTimer(time); }, 1000);
            } else {
                $('#gameForm').hide();
                $('#startBtn').removeAttr('disabled');
                if ($('#bestTime span').text() < count) { $('#bestTime span').text(count); }
            }
        }

        $(document).on('click', '#startBtn', function () {
            count = 0;
            $('#counter span').text(count);
            $(this).attr('disabled', true);
            $('#gameForm').show();
            setTimer(15);
        })

        $(document).on('click', '#gameBlock', function () {
            count++;

            var width = $('#game').width();
            var height = $('#game').height();

            var maxleft = Math.floor(width / 50);
            var maxtop = Math.floor(height / 50);

            curleft = 10 + 50 * Math.round(Math.random() * (maxleft - 1));
            curtop = 10 + 50 * Math.round(Math.random() * (maxtop - 1));

            $("#gameBlock").css({ left: curleft + "px", top: curtop + "px" });

            $('#counter span').text(count);
        });
    </script>
</asp:Content>
