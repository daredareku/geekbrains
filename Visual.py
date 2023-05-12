# --** coding: utf-8 **--
import pandas as pd
import matplotlib.pyplot as plt

# 1.1. ��������� ������ �� ������ � ����������� ���������� ��� ������ � csv ������� � ��� ������������
df = pd.read_csv('https://gbcdn.mrgcdn.ru/uploads/asset/4266730/attachment/08ec55854637add5247d22396d0f7456.csv')

# 1.2. ������ ��������� ������������ � �������� �����������.
# ������� ������ '��������� ������������'
# �� ��� x - '���������, ���.���'
# �� ��� y - '���������� ������������'
df['���������, ���.���.'].hist(bins=20, grid=True)
plt.xlabel('���������, ���.���')
plt.ylabel('���������� ������������')
plt.title('��������� ������������')
plt.show()

# 1.3. ������ ������������� ���������� ����� � �������� �����������.
# ������� ������ '���������� ����� ������������'
# �� ��� x - '����������, ��. �����'
# �� ��� y - '���������� ������������'
df['��������'].hist(bins=20, grid=True)
plt.xlabel('����������, ��. �����')
plt.ylabel('���������� ������������')
plt.title('���������� ����� ������������')
plt.show()

# 2.1.4. ������ ������������� ���� ��������� � �������� �����������.
# ������� ������ '��� ���������'
# �� ��� x - '��� ���������'
# �� ��� y - '���������� ������������'
df['��� ���������'].hist(bins=20, grid=True)
plt.xlabel('��� ���������')
plt.ylabel('���������� ������������')
plt.title('��� ���������')
plt.show()

# 2.1. ������ ������������� ����� �� ������� ���� �� ���������� � �������� ���������.
# ������� ������ '������������� ����� �� ������� ���� �� ����������'
# �� ��� x - '������� ���� �� ����������'
# �� ��� y - '���������� �����'
df['��� �� ����������'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('������� ���� �� ����������')
plt.ylabel('���������� �����')
plt.title('������������� ����� �� ������� ���� �� ����������')
plt.show()

# 2.2. ������ ������������� ������ ����� � �������� ���������.
# ������� ������ '������������� ������ �����'
# �� ��� x - '�����'
# �� ��� y - '���������� �����'
df['���������'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('�����')
plt.ylabel('���������� �����')
plt.title('������������� ������ �����')
plt.show()

# 2.3. ������ ������������� ��������� ����� � �������� ���������.
# ������� ������ '������������� ��������� �����'
# �� ��� x - '���������'
# �� ��� y - '���������� �����'
df['���������'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('���������')
plt.ylabel('���������� �����')
plt.title('������������� ��������� �����')
plt.show()

# 3. ���������, ����� �������������� ������������ ������ �� ��������� ������������, � ������� ���������� ��������.
# 3.1. ������ ����������� ��������� �� ���������� ����� ������������ � �������� ���������.
df.plot.scatter(x='��������', y='���������, ���.���.', alpha=0.5)
plt.xlabel('����������, ��. �����')
plt.ylabel('���������, ���.���.')
plt.title('����������� ��������� �� ���������� ����� ������������')
plt.show()

# 3.2. ������ ����������� ��������� �� ���� ��������� � �������� ���������.
df.plot.scatter(x='��� ���������', y='���������, ���.���.', alpha=0.5)
plt.xlabel('��� ���������')
plt.ylabel('���������, ���.���.')
plt.title('����������� ��������� �� ���� ���������')
plt.show()

# 3.3. ������ ����������� ��������� �� ��������� � �������� ���������.
df.plot.scatter(x='���������', y='���������, ���.���.', alpha=0.5)
plt.xlabel('���������')
plt.ylabel('���������, ���.���.')
plt.title('����������� ��������� �� ���������')
plt.show()

# 3.4. ������ ����������� ��������� �� ������� ���� �� ���������� � �������� ���������.
df.boxplot(column='���������, ���.���.', by='��� �� ����������')
plt.xlabel('������� ���� �� ����������')
plt.ylabel('���������, ���.���.')
plt.title('����������� ��������� �� ������� ���� �� ����������')
plt.show()

# 3.5. ������ ����������� ��������� �� ��������� ����� � �������� ���������.
df.boxplot(column='���������, ���.���.', by='���������')
plt.xlabel('���������')
plt.ylabel('���������, ���.���.')
plt.title('����������� ��������� �� ��������� �����')
plt.show()