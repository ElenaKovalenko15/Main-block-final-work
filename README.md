# Main-block-final-work
Итоговая контрольная работа по основному блоку

__Ход и логика решения задачи:__

1. Просим пользователя ввести количество элементов массива, считываем введенное число, которое присваиваем длинам двух объявленных нами строковых массивов. 
2. Первый массив заполняем методом __*FillArray*__ и методом __*PrintArray*__ выводим в консоль. Это первоначальным массив, из которого мы будем отбирать элементы, удовлетворяющие условию задачи, во второй вспомогательный массив.
3. Метод __*Elementscuter*__ принимает два массива: первоначальный и вспомогательный. Проверяет каждый элемент главного массива на количество символов (<= 3). Если условие выполняется - элемент записывается во второй дополнительный массив.
4. Методом __*PrintArray*__ выводим в консоль результат.
