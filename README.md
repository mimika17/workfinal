# **Итоговая проверочная работа.** #

## Задача: ##
 
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 ### *Пример вывода программы:* ###

 [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Решение задачи ##

1. Вводим размер массива

2. С помощью метода *FillArray*:
    
    * Пользователь указывает размер первоначального массива  

    * Вводим и заполняем построчно массив  

    * создаем массив из строк

3. С помощью метода *Chair3Array*:

    * создаем новый массив 
    
    * создаем цикл с двумя счетчиками один для первого массива, а другой для нового
    
    * проверяем каждое значение массива на соответсвие условию: **длина строки <=3**.
    
    * Если строка соответсвует условию переносим её в новый массив

    *  Измениям размер нового массива равный счетчику нового массива

4. Вывод в консоль новый массив.
