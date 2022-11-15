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
    lst = list(map(int, input("Введите числа через пробел:\n").split()))
    print(f"Исходный список: {lst}")
    new_lst = []
    [new_lst.append(i) for i in lst if i not in new_lst]
    print(f"Список из неповторяющихся элементов: {new_lst}")

def NonRepeating1():
    b=sorted(a,key=lambda x: a.count(x)) # sort
    for i in range(len(b)): #-1):
        if b[i]==b[i+1]:
            #b.remove(b[i]) # remove last element from list, both elements
            continue
        else:
            print(b[i])
    
# 4. Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.

# Пример:

# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
class cl4:
    def FilePoly(k):
        k=k%100
        a=[random.randint(1,100)  for i in range(0, k) ] # for i in range]
        f=open("polynom.txt", "w")
        for i in a:
            f.write(str(i)+"\n")
        f.close()

    import random

    def write_file(st):
        with open('file44.txt', 'w') as data:
            data.write(st)

    def rnd():
        return random.randint(0,101)

    def create_mn(k):
        lst = [cl4.rnd() for i in range(k+1)]
        return lst
        
    def create_str(sp):
        lst= sp[::-1]
        wr = ''
        if len(lst) < 1:
            wr = 'x = 0'
        else:
            for i in range(len(lst)):
                if i != len(lst) - 1 and lst[i] != 0 and i != len(lst) - 2:
                    wr += f'{lst[i]}x^{len(lst)-i-1}'
                    if lst[i+1] != 0:
                        wr += ' + '
                elif i == len(lst) - 2 and lst[i] != 0:
                    wr += f'{lst[i]}x'
                    if lst[i+1] != 0:
                        wr += ' + '
                elif i == len(lst) - 1 and lst[i] != 0:
                    wr += f'{lst[i]} = 0'
                elif i == len(lst) - 1 and lst[i] == 0:
                    wr += ' = 0'
        return wr
    
# 5. Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.
class cl5:
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
        
    import random

    # запись в файл
    def write_file(name,st):
        with open(name, 'w') as data:
            data.write(st)

    # создание случайного числа от 0 до 100
    def rnd():
        return random.randint(0,101)

    # создание коэффициентов многочлена
    def create_mn(k):
        lst = [cl5.rnd() for i in range(k+1)]
        return lst
        
    # создание многочлена в виде строки 
    def create_str(sp):
        lst= sp[::-1]
        wr = ''
        if len(lst) < 1:
            wr = 'x = 0'
        else:
            for i in range(len(lst)):
                if i != len(lst) - 1 and lst[i] != 0 and i != len(lst) - 2:
                    wr += f'{lst[i]}x^{len(lst)-i-1}'
                    if lst[i+1] != 0 or lst[i+2] != 0:
                        wr += ' + '
                elif i == len(lst) - 2 and lst[i] != 0:
                    wr += f'{lst[i]}x'
                    if lst[i+1] != 0 or lst[i+2] != 0:
                        wr += ' + '
                elif i == len(lst) - 1 and lst[i] != 0:
                    wr += f'{lst[i]} = 0'
                elif i == len(lst) - 1 and lst[i] == 0:
                    wr += ' = 0'
        return wr

    # получение степени многочлена
    def sq_mn(k):
        if 'x^' in k:
            i = k.find('^')
            num = int(k[i+1:])
        elif ('x' in k) and ('^' not in k):
            num = 1
        else:
            num = -1
        return num

    # получение коэффицента члена многочлена
    def k_mn(k):
        if 'x' in k:
            i = k.find('x')
            num = int(k[:i])
        return num

    # разбор многочлена и получение его коэффициентов
    def calc_mn(st):
        st = st[0].replace(' ', '').split('=')
        st = st[0].split('+')
        lst = []
        l = len(st)
        k = 0
        if cl5.sq_mn(st[-1]) == -1:
            lst.append(int(st[-1]))
            l -= 1
            k = 1
        i = 1 # степень
        ii = l-1 # индекс
        while ii >= 0:
            if cl5.sq_mn(st[ii]) != -1 and cl5.sq_mn(st[ii]) == i:
                lst.append(cl5.k_mn(st[ii]))
                ii -= 1
                i += 1
            else:
                lst.append(0)
                i += 1
            
        return lst
        
    def create_mn_double():
        # создание двух файлов

        k1 = int(input("Введите натуральную степень для первого файла k = "))
        k2 = int(input("Введите натуральную степень для второго файла k = "))
        koef1 = cl5.create_mn(k1)
        koef2 = cl5.create_mn(k2)
        cl5.write_file("file34_1.txt", cl5.create_str(koef1))
        cl5.write_file("file34_2.txt", cl5.create_str(koef2))

    def create_sum():
        # нахождение суммы многочлена

        with open('file34_1.txt', 'r') as data:
            st1 = data.readlines()
        with open('file34_2.txt', 'r') as data:
            st2 = data.readlines()
        print(f"Первый многочлен {st1}")
        print(f"Второй многочлен {st2}")
        lst1 = cl5.calc_mn(st1)
        lst2 = cl5.calc_mn(st2)
        ll = len(lst1)
        if len(lst1) > len(lst2):
            ll = len(lst2)
        lst_new = [lst1[i] + lst2[i] for i in range(ll)]
        if len(lst1) > len(lst2):
            mm = len(lst1)
            for i in range(ll,mm):
                lst_new.append(lst1[i])
        else:
            mm = len(lst2)
            for i in range(ll,mm):
                lst_new.append(lst2[i])
        cl5.write_file("file34_res.txt", cl5.create_str(lst_new))
        with open('file34_res.txt', 'r') as data:
            st3 = data.readlines()
        print(f"Результирующий многочлен {st3}")

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
        
print(round(Precision1(1e-5), 6))
print("Список множителей")
print(Factor(int(48)))
print(NonRepeating(6))
k = int(input("Введите натуральную степень k = "))
koef = cl4.create_mn(k)
cl4.write_file(cl4.create_str(koef))
cl5.create_mn_double()
cl5.create_sum()
#main()