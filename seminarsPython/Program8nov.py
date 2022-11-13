# coding=UTF-8
debug = True
from numpy import append
import random
# Урок 2. Знакомство с Python. Продолжение
# 1. Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
#
# Пример:
#
# - 6782 -> 23
# - 0,56 -> 11
    
def sumNums(num):
    sum = 0
    for i in str(num):
        if i != ".":
            sum += int(i)
    return sum
    
def SumCyfr(b):
    if not b:
        b=float(input("1. Введите число: "))
    s=[]
    while b>=1:
        s+=[int(b%10)]
        b=b/10
    while b>1e-16:
        b=b*10
        s+=[int(b%10)]
        b=b-int(b%10)
    sum=0
    l=min(len(s),7)
    for i in range(0,l):
        sum=sum+int(s[i])
    print(sum)
   
   
# 2. Напишите программу, которая принимает на вход число N и выдает набор список произведений чисел от 1 до N.
#
# Пример:
#
# - пусть N = 4, тогда  (1, 1*2, 1*2*3, 1*2*3*4) --> [ 1, 2, 6, 24 ]
def Proizv1(a):
    if not a:
        a=int(input("2. Введите число: "))
    s=[]
    su=[]
    for i in range(1, a+1):
        sum=1
        s=[b for b in range(1, i+1)]
        print(s)
        for j in range(1, i+1):
            sum*=int(s[j-1])
        print(sum)
        su+=[int(sum)]
    print('su=', su)

    

def Proizv():
    a=int(input("2. Введите число: "))
    s=[]
    for b in range(1,a):
        for i in range(1,a+1):
            s+=[(b+1)*i]
    print(b)

    

# 3. Задайте список из n чисел последовательности $(1+\frac 1 n)^n$ и выведите на экран их сумму.
#
# Пример:
#
# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
def SumList(a):
    if not a:
        a=int(input("3. Введите число: "))
    b=0
    s=[]
    for i in range(1,a+1):
        s+=[(1+1/i)**i]
    print(s)
    for i in range(0, len(s)):
        b=b+s[i]
    print(b)
# 4. Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных позициях. Позиции хранятся в файле 
# file.txt - в одной строке одно число.

def List(a):
    b=[]
    b=[i for i in range(-a, a+1)]
    with open(".//file.txt", "r") as f:
        my=f.read().split("\n")
        if debug:
            print(my)
    z=1
    for i in range(0, len(my)):
        if my[i]:
            z*=int(b[int(my[i])])
    print(str(z))
    # print(str(z))
# # 18. Реализуйте алгоритм перемешивания списка. Перемешивание должно происходить в случайном порядке.
    for i in range(0, len(b)):
        h=random.randint(0, len(b)-1)
        k=b[i]
        b[i]=b[h]
        b[h]=k
    print(b)
    f.close()
    
    
#     Перемешивание
# Считайте элементы и сформируйте из него список. Реализуйте следующий алгоритм перемешивания списка: Необходимо пройтись по всем элемента от 0 до последнего один раз
# и каждый четный элемент поменять местами с предыдущим, каждый нечетный со следующим, если такое возможно.
def Mix():
    b=[]
    #b=[i for i in range(0, a)]
    v=input()
    while(v):
        b+=[int(v)] #input())]
        v=input()
    print(b)
    for i in range(0, len(b)):
        if i%2==0:
            if i!=len(b)-1:
                k=b[i]
                b[i]=b[i+1]
                b[i+1]=k
        else:
            if b[i+1] and i!=len(b)-1: #i!=0:
                k=b[i]
                b[i]=b[i-1]
                b[i-1]=k
    print(b)

#Mix()
        
        
    
# На easy
# На вход программе подаются два целых числа aa и bb. Напишите программу, которая выводит:
#
# сумму чисел aa и bb;
# разность чисел aa и bb;
# произведение чисел aa и bb;
# частное чисел aa и bb;
# целую часть от деления числа aa на bb;
# остаток от деления числа aa на bb;
# корень квадратный из суммы их 1010-х степеней: \sqrt{a^{10} + b^{10}}
# a
# 10
#  +b
# 10
def Easy():
    a=int(input("5. Введите число: "))
    b=int(input(" Введите число: "))
    print(a+b)
    print(a-b)
    print(a*b)
    print(a/b)
    print(a//b)
    print(a%b)
    print((a**10+b**10)**0.5)    
 
def Zodiac():
    y=[
    'Дракон',
    'Змея',
    'Лошадь',
    'Овца',
    'Обезьяна',
    'Петух',
    'Собака',
    'Свинья',
    'Крыса',
    'Бык',
    'Тигр',
    'Заяц']
    year=int(input("6. Введите год: "))
    diff=year-2000
    d=diff%12
    print(y[d]) 
    
# Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
# 2. Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
#
#     *Пример:*
#
#     - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
# 3. Напишите программу, в которой пользователь будет задавать две строки, а программа - определять количество вхождений одной строки в другой.
#     
def Sum():
    a=int(input("7. Введите число: "))
    b=0
    for i in range(1,a+1):
        b=b+(1+1/i)**i
        print(b)
    
def SubStr():
    a=input("8. Введите строку: ")
    b=input(" Введите строку: ")
    print(a.count(b))
            
def Dict():
    a=int(input("8. Введите число: "))
    b={}
    for i in range(1,a+1):
        b[i]=3*i+1
    print(b)

def Dict2():            
    number = int(input("Введите число: "))
    d = {i : 3*i + 1 for i in range(1,number+1)}
    print(f"Итоговая последовательность: {d}")


def Main():
    print("1. Сумма чисел")
    Sum()
    print("2. Словарь")
    Dict()
    print("3. Сумма чисел")
    SumList()
    print("4. Список")
    List()
    print("5. Простые операции")
    Easy()
    print("6. Знак зодиака")
    Zodiac()
    print("7. Подстрока")
    SubStr()
    
        
    
#Zodiac()    
#SumCyfr(6782)
Mix()
print(sumNums(6782))
Proizv1(4)
SumList(6)
List(5)    