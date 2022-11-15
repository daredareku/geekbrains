#
from datetime import datetime
e=2.71828182845904523536028747135266249775724709369995
# Класс datetime.date(year, month, day) - стандартная дата. Атрибуты: year, month, day. Неизменяемый объект.

# Класс datetime.time(hour=0, minute=0, second=0, microsecond=0, tzinfo=None) - стандартное время, не зависит от даты. Атрибуты: hour, minute, second, microsecond, tzinfo.

# Класс datetime.timedelta - разница между двумя моментами времени, с точностью до микросекунд.

# Класс datetime.tzinfo - абстрактный базовый класс для информации о временной зоне (например, для учета часового пояса и / или летнего времени).

# Класс datetime.datetime(year, month, day, hour=0, minute=0, second=0, microsecond=0, tzinfo=None) - комбинация даты и времени.

def rand(seed):
    # Seed — это стартовое число, точка, с которой начинается последовательность псевдослучайных чисел.
    # Генератор псевдослучайных чисел использует единственное начальное значение, откуда и следует его псевдослучайность. 
    # Генератор истинных случайных чисел всегда имеет в начале высококачественную случайную величину, предоставленную различными источниками энтропии.
    t=datetime.now()
    return int(seed*t.microsecond%1000)

# Урок 3. Данные, функции и модули в Python
# 1. Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
def sum_odd(listm):
    sum=0
    for i in range(1,len(listm),2):
        sum+=listm[i]
    return sum
# Пример:

# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
# 2. Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]
def mult_pairs(list):
    mult=[]
    print('fibo='+str(list))
    for i in range(len(list)//2):
        mult.append(list[i]*list[-i-1])
    return mult
# 3. Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# Пример:

# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19
def mult3(list):
    max=0
    min=1
    for i in list:
        l=(i-int(i))
        if l>max:
            max=l 
        if l<min:
            min=l 
    return max-min
# 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10
def mult4(list):
    res=""
    while (list)>0: #1:
        o=list%2
        res=str(o)+res
        list=list//2
    return res
        
# 5. Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# Пример:

# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] 
# [Негафибоначчи](https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8#:~:text=%D0%92%20%D0%BC%D0%B0%D1%82%D0%B5%D0%BC%D0%B0%D1%82%D0%B8%D0%BA%D0%B5%2C%20%D1%87%D0%B8%D1%81%D0%BB%D0%B0%20%D0%BD%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8%20%E2%80%94%20%D0%BE%D1%82%D1%80%D0%B8%D1%86%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%20%D0%B8%D0%BD%D0%B4%D0%B5%D0%BA%D1%81%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5%20%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D1%8B%20%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8%20%D1%87%D0%B8%D1%81%D0%B5%D0%BB%20%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8.)

def fibo51(k):
    fibo=[0,1]
    for i in range(2,k+1):
        fibo.append(fibo[i-1]+fibo[i-2])
    return fibo

def fibo5(k):
    fibo=[0,1]
    for i in range(2,k+1):
        fibo.append(fibo[i-1]+fibo[i-2])
    fibom=[1, -1]
    for i in range(2,k):
        fibom.append(((-1)**i)*(abs(fibom[i-1])+abs(fibom[i-2])))
    return fibom[::-1]+fibo

print('1. Нечетные='+str(sum_odd(fibo51(8))))
print('2. Пары произведение='+str(mult_pairs(fibo51(8))))
print('3. Difference='+str(mult3([1.1, 1.2, 3.1, 5, 10.01])))
print('4. Двоичное представление='+str(mult4(45)))
print('5. NegaFibo='+str(fibo5(8)))