from matplotlib import pyplot as plt

x = range(-10,10)
y = []

from i in range(0,len(x)):
    y.append(x[i]**2)

plt.plot(x,y)
plt.show()