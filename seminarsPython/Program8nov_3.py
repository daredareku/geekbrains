# coding=UTF-8
# 3. Задайте список из n чисел последовательности $(1+\frac 1 n)^n$ и выведите на экран их сумму.
#
# Пример:
#
# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
def SumList(a):
    #if not a:
        #a=int(input("3. Введите число: "))
    b=0
    s=[]
    for i in range(1,a+1):
        s+=[(1+1/i)**i]
    #print(s)
    for i in range(0, len(s)):
        b=b+s[i]
    print(b)


SumList(int(input()))