# coding=UTF-8
# 2. �������� ���������, ������� ��������� �� ���� ����� N � ������ ����� ������ ������������ ����� �� 1 �� N.
#
# ������:
#
# - ����� N = 4, �����  (1, 1*2, 1*2*3, 1*2*3*4) --> [ 1, 2, 6, 24 ]
def Proizv1(a):
    #if not a:
        #a=int(input("2. ������� �����: "))
    s=[]
    su=[]
    for i in range(1, a+1):
        sum=1
        s=[b for b in range(1, i+1)]
        #print(s)
        for j in range(1, i+1):
            sum*=int(s[j-1])
        print(sum)
        su+=[int(sum)]
    #print(su)

Proizv1(int(input()))