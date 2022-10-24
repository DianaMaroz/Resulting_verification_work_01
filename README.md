# Resulting_verification_work_01
итоговая проверочная работа "Разработчик", 1 четверть
###**Итоговая проверочная работа**
#Выполнил(а): *Мороз Диана*

## **_Задача_**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых маньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте через выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

#Примеры
["hello", "2", "world", ":-)" ] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science" ] -> ["-2"]
["Russia", "Denmark", "Kazan" ] -> []

## **_Решение_**
1. Задать начальный массив:
*вручную;
*алгоритм пользовательского ввода(пользователь указывает размер массива n, потом вводит n строк);
*алгоритм рандомного создания массива(рандомно задается размер массива, рандомно составляется массив либо путем присвоения значений из массива или словаря, либо из случайных символов);
2. Определить длину нового массива:
* задать счетчик, присвоить нулевое значение;
* пройтись по всему списку, в случае если длина строки меньше либо равна 3 - увеличивать счетчик на один;
* если по завершения списка счетчик равен нулю - вывести пустые скобочки (согласно условию), иначе - переходим к следующему пункту.
3. Получить новый массив:
* создать пустой массив, длину определям по счетчику из пункта 2;
* задать счетчик значений нового массива, присвоить значение 0;
* пройтись по начальному массиву, проверяя длину строк: если длина строки меньше или равна трем - соответсвующему элементу нового массива присвоить значение из старому, увеличить счетчик значений нового массива на один;
* завершить цикл, когда будет заполнен весь новый массив; 
4. Вывести начальный массив.
5. Вывести конечный массив.
