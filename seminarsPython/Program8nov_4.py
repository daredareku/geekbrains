# coding=UTF-8
# 4. ������� ������ �� N ���������, ����������� ������� �� ���������� [-N, N]. ������� ������������ ��������� �� ��������� ��������. ������� �������� � ����� 
# file.txt - � ����� ������ ���� �����.
debug=False

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

List(int(input()))
