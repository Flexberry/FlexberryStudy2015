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
        var c = 0;

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
                if ($('#bestTime span').text() < c) { $('#bestTime span').text(c); }
            }
        }

        $(document).on('click', '#startBtn', function () {
            c = 0;
            $('#counter span').text(c);
            $(this).attr('disabled', true);
            $('#gameForm').show();
            setTimer(15);
        })

        $(document).on('click', '#gameBlock', function () {
            c++;

            // 1 вариант - появление в рандомном месте
            var w = $('#game').width();
            var h = $('#game').height();

            var maxl = Math.floor(w / 50);
            var maxt = Math.floor(h / 50);

            l = 10 + 50 * Math.round(Math.random() * (maxl - 1));
            t = 10 + 50 * Math.round(Math.random() * (maxt - 1));

            $("#gameBlock").css({ left: l + "px", top: t + "px" });

            // 2 вариант - сдвиг на рандомную клетку рядом            
            /*
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
            */

            $('#counter span').text(c);
        });
    </script>
</asp:Content>
