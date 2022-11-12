# coding=UTF-8
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

    print(sum)
    return sum
   
sumNums(input())