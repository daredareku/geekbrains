#
import random
# Урок 4. Данные, функции и модули в Python. Продолжение
# 1. Вычислить число c заданной точностью d

# Пример:

# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$
def calc_pi(eps=1.0e-5):
    s=0
    d=1
    sgn=1
    while True:
        a=4/d
        s=s+sgn*a
        if a<eps:
            return s
        sgn=-sgn
        d=d+2

def Precision1(d):
    #d=float(input("4. Введите точность: "))
    return calc_pi(d)
    
# 2. Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
def Factor(n):
    Ans = []
    d = 2
    while d * d <= n:
        if n % d == 0:
            Ans.append(d)
            n //= d
        else:
            d += 1
    if n > 1:
        Ans.append(n)
    return Ans
#print(Factor(int(input())))

def Simple2():
    d=float(input("2. Задайте натуральное: "))
    a=[i for i in range(2, d) if d%i==0]
    
    
    return d
    
    pass
    
# 3. Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
def NonRepeating(a):
    b=sorted(a,key=lambda x: a.count(x))
    for i in range(len(b)-1):
        if b[i]==b[i+1]:
            continue
        else:
            print(b[i])
    
# 4. Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.

# Пример:

# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
def FilePoly(k):
    k=k%100
    a=[random.randint(1,100)  for i in range(0, k) ] # for i in range]
    f=open("polynom.txt", "w")
    for i in a:
        f.write(str(i)+"\n")
    f.close()
    
# 5. Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.
def FileSumPolynom():
    f1=open("polynom1.txt", "r")
    f2=open("polynom2.txt", "r")
    f3=open("polynom_out.txt", "w")
    for line in f1:
        a=line.split()
        for i in a:
            f3.write(i+" ")
        f3.write("\n")
        for line in f2:
            a=line.split()
        for i in a:
                f3.write(i+" ")
        f3.write("\n")
    f3.close()
    
# 1. Задайте строку из набора чисел. Напишите программу, которая покажет большее и меньшее число. В качестве символа-разделителя используйте пробел.
def MaxMin(): 
    print("1. Введите строку из чисел: ")
    b=[int(i) for i in input().split(' ')]
    
    print("Максимальное число: ", max(b))
    print("Минимальное число: ", min(b))
# 2. Найдите корни квадратного уравнения Ax² + Bx + C = 0 двумя способами:
    
#     1) с помощью математических формул нахождения корней квадратного уравнения
    
#     2) с помощью дополнительных библиотек Python
import numpy as np

def QuadraticEquation():
    a=int(input("2. Введите A: "))
    b=int(input("Введите B: "))
    c=int(input("Введите C: "))
    D=b**2-4*a*c
    if D>0:
        x1=(-b+D**0.5)/(2*a)
        x2=(-b-D**0.5)/(2*a)
        print("x1=", x1)
        print("x2=", x2)
    elif D==0:
        x1=-b/(2*a)
        print("x1=x2=", x1)
    else:
        print("Корней нет")
    print(np.roots([a,b,c]))
    
    
# 3. Задайте два числа. Напишите программу, которая найдёт НОК (наименьшее общее кратное) этих двух чисел.
def main():
    a=int(input("3. Введите первое число: "))
    b=int(input("Введите второе число: "))
    if a>b:
        a,b=b,a
    for i in range(1,b+1):
        if (a*i)%b==0:
            print("НОК: ", a*i)
            break
        
print(Precision1(1e-5))
print(Factor(int(48)))
print(NonRepeating(6))
#main()