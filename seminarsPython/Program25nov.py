# pythontutor.com/visualize.html#mode=edit

from sympy import *
from sympy.plotting import plot as plt
import matplotlib.pyplot as pl
init_printing(use_unicode=True)
plt.set_linestyle='dashed'

x=Symbol('x')
points={31:19310, 51:52150, 61:74570} #[]
x=[31, 51, 61]
y=[19310, 52150, 74570]
plt.plot(x,y)
plt.show()
plt.plot(points.keys(), points.values(), 'ro')

fx=a*31**2+b*31+c-19310
fx=a*51**2+b*51+c-52150
fx=a*61**2+b*61+c-74570
