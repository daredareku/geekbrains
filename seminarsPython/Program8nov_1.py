# coding=UTF-8
# ���� 2. ���������� � Python. �����������
# 1. �������� ���������, ������� ��������� �� ���� ������������ ����� � ���������� ����� ��� ����.
#
# ������:
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