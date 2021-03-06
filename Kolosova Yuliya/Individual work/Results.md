# 09.11.2015
*Задание №3 - Вариант №7*
1) вывести все товары на складе в указанном диапазоне цен; 2) вывести все товары, которые не покупались в прошлом месяце;
3) вывести все товары, цена которых на протяжении последних трех месяцев снижается; 4) вывести топ-10 товаров, 
пользующихся спросом (по количеству); 5) вывести товар, который принес максимальную прибыль за полгода.

## Плюсы
1. Все запросы реализованы. 4 запроса из пяти работают правильно.

## Недостатки
1.  Запрос №1.
  * Если не вводить диапазон цен, и нажать кнопку выполнения запроса, то нет никаких результатов (должно быть сообщение об ошибке с просьбой ввести диапазон).
  * Таблица с результатами прижата вплотную к полям ввода диапазона цен.
  * В behind-коде странная логика: по клику введенный цены пишутся в сессию, и делается редирект на эту же страницу, для того что бы снова вызвать метод onload, в котором значения достаются из сессии. Можно было всю логику написать в обработчике клика и не хитрить таким образом, или написать все в onload внутри условия if (IsPostBack) {...}, т.к. на странице всего одна кнопка приводящая к postback-у.
  * Вместо try {Convert.ToDouble(str)} catch() {...} лучше использовать Double.TryParse)(str, out convertedDouble).
  * Сравнивать товары на равенство по их наименованию - некорректно, нужно стравнивать первичные ключи.

2.  Запрос №2.
  * Не стоит вычислять нужный месяц таким образом: myDate.Month - 1 (так можно получить и отрицательные значения), лучше делать так, как это реализовано в остальных запросах (myDate.AddMonth(-1)), и в самом запросе сравнивать не месяц на равенство, а дату на >=.
  * Опять же сравнивать товары по их наименованию - некорректно, нужно сравнивать первичные ключи.
  * Вторым запросом не нужно вычитывать все товары, это может быть очень большой объем данных. Нужно первым запросом вычитать продажи за прошлый месяц и сформировать список первичных ключей проданных товаров, а вторым запросом вычитать только те товары, ключи которых не сожержатся в этом списке.

3.  Запрос №3.
  * После выполнения предварительного запроса с группировкой по товарам, не стоит городить перебор циклами с неочевидной логикой. Лучше сформировать из полученного словаря <Товар, Поступления Товара Отсоритрованные По Дате Поступления> словарь <Товар, List<Цена товара за ед. при поступлении>>, а затем выбрать из этого словаря только те товары, у которых список цен при поступлении упорядочен по убыванию. Это можно сделать при помощи Linq.

4.  Запрос 4.
  * Сами платежки вызитавать необязательно. Можно сразу вычитать строки платежек и сгруппировать их по товарам, получив слоарь <Товар, List<Строка платежки>>. А затем, с помощью того же linq сформироват из него <Товар, Суммарное проданное количество>, отсортировать по убыванию проданного количества, и взять первые 10 товаров.

5.  Запрос № 5.
  * Работает неверно: если в системе имеются данные о продажах за текущий месяц, предположим на несколько позиций одного товара на 10000, другого на 20000, и за прошлый месяц - одна позиция на 2000, то в результатах выводится товар проданный в прошлом месяце на 2000 (хотя макс. прибыль принес товар проданный на 20000 в тек. месяце).
  * Указанная ошибка возникает из-за хтрой логики в циклах, перебирающих результаты предварительно вычитанные из базы.
Опять же, по аналогии с предыдущим запросом, после вычитки плаьежек за нужный период, можно сформировать словарь <Товар, List<Строка платежки>>, и преобразовать его в <Товар, Суммарная стоимость всего проданного товара>, отсортировать по суммарной стоимости, и взять первый элемент.
  * Вместо "" лучше использовать string.Empty.
  * Не стоит делать конкатенацию строк через оператор +, лучше использовать string.Format.

## Замечания (для справки, в данном задании исправлять не обязательно).
1. Linq-првайдер не умеет, накладывать ограничения на сгруппированные данные (GroupBy), т.е. у вас сначала вычитывается из базы в память вся куча товаров, а потом уже выполнается группировка, и накладываются ограничения на вычитанную коллекцию.
В реальной системе это очень кретично, и так делать нельзя. Т.к. группировки используются в основном в отчетах, то используются специальные подсистемы отчетов, например на Stimulfoft, либо используется напрямую ADO.NET ([рукми формируем SQL запрос и посылаем его через IDbConnection](http://wiki.flexberry.ru/CaseberrySQLQuery.ashx)).

## Результат
Требуется переделать запрос №5, т.к. он неверно работает. Желательно исправить замечания к коду.

# 21.10.2015
*Задание №2 - Вариант №7*
В электронном магазине имеется информация о складе, где хранятся товары. О каждом товаре известно его название, 
количество и стоимость всего товара. При поступлении товара поступившее количество добавляется к имеющемуся и их 
стоимости суммируются. Продажная цена товара определяется делением стоимости на его количество.

Ведётся ежемесячный учёт продаж каждого товара: название, сколько продано и по какой цене. При продаже 
корректируется количество товара и его стоимость.

## Плюсы
1. Все требования к кастомизации тем выполнены, переопределены темы Default и Spring.
2. Переопределенные стили находятся в одном месте, привязаны к соответствующим темам, нет никаких неочевидностей 
   в их подключении к страницам.
3. Переопределенные темы ведут себы одинаково во всех браузерах.

## Недостатки
1. Сущность подразумевающая поступление товара на склад называется "Склад", что вводит в заблуждение, и с учетом остальной модели создает впечатление, что предлагается хранить на складе всего один товар.
   
2. Не продемонстровано никаких красивостей на JavaScript (хотя по условиям задания это не обязательно).

## Замечания (для справки, исправлять не обязательно).
1. При переопределении стилей серверных контролов (таких как TreeView) лучше не привязываться к идентификаторам, 
   т.к. они генерируются в серверной части приложения, и могут возникать ситуации, когда значение идентификатора,
   пришедшее на клиент в разметке, будет отличаться от ожидаемого, и стили посыпятся.
   Лучше привязываться к именам классов.

## Результат
Требуется выполнить доработку модели и перегенерировать приложение.
