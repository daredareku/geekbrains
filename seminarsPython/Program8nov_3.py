# coding=UTF-8
# 3. ������� ������ �� n ����� ������������������ $(1+\frac 1 n)^n$ � �������� �� ����� �� �����.
#
# ������:
#
# - ��� n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
def SumList(a):
    #if not a:
        #a=int(input("3. ������� �����: "))
    b=0
    s=[]
    for i in range(1,a+1):
        s+=[(1+1/i)**i]
    #print(s)
    for i in range(0, len(s)):
        b=b+s[i]
    print(b)


SumList(int(input()))