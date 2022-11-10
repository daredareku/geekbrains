#
from numpy import append
import random
# Урок 2. Знакомство с Python. Продолжение
# 1. Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
#
# Пример:
#
# - 6782 -> 23
# - 0,56 -> 11
    
def SumCyfr():
    b=float(input("1. Введите число: "))
    s=[]
    # while a>1:
    #     b=a%10
    #     #print(b)
    #     s+=#append(int((a-a%10)%10))
    #     #print(int((a-a%10)%10))
    #     a=a/10
    # #b=a%10
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
    #print(s)
    print(sum)
    
    
# 2. Напишите программу, которая принимает на вход число N и выдает набор список произведений чисел от 1 до N.
#
# Пример:
#
# - пусть N = 4, тогда  (1, 1*2, 1*2*3, 1*2*3*4) --> [ 1, 2, 6, 24 ]
def Proizv1():
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
    #print(su)
    

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
def SumList():
    a=int(input("3. Введите число: "))
    b=0
    s=[]
    for i in range(1,a+1):
        #b=b
        s+=[(1+1/i)**i]
        #print(b)
    print(s)
    for i in range(0, len(s)):
        b=b+s[i]
    print(b)
# 4. Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных позициях. Позиции хранятся в файле 
# file.txt - в одной строке одно число.

def List():
    a=int(input("4. Введите число: "))
    b=[]
    b=[i for i in range(-a, a+1)]
    #   b.append(i)
    f=open(".//file.txt", "w")
    #for i in range(0, len(b)):
    #    f.write(str(i)+"\n")
    #f.write(" ".join(int(b)))
    xy=[]
    xy[0]=[random.randint(-a, a+1)]
    xy[1]=[random.randint(-a, a+1)]
    for i in range(0, len(xy)):
        f.write(str(xy[i])+"\n")
    
    f.close()
    with open(".//file.txt", "r") as f:
        my=f.read().split("\n")
    myy=f.read()
    z=b[myx]*b[myy]
    print(z)
# # 18. Реализуйте алгоритм перемешивания списка. Перемешивание должно происходить в случайном порядке.
#def main18():    
    for i in range(0, len(b)):
        #print(b[i])
        h=random.randint(0, len(b)-1)
        k=b[i]
        b[i]=b[h]
        b[h]=k
    print(b)
    f.closed()
        
        
    
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
#SumCyfr()
Proizv1()
SumList()
List()    