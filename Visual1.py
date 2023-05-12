# --** coding: utf-8 **--
import pandas as pd
import matplotlib.pyplot as plt

#1.1. Load data from a CSV file located on a web server.
df = pd.read_csv('https://gbcdn.mrgcdn.ru/uploads/asset/4266730/attachment/08ec55854637add5247d22396d0f7456.csv')

#1.2. Plot a histogram of the distribution of prices.
# Set the x-axis label to 'Price, rubles.'
# Set the y-axis label to 'Number of listings.'
df['Price, rubles'].hist(bins=20, grid=True)
plt.xlabel('Price, rubles.')
plt.ylabel('Number of listings')
plt.title('Distribution of prices')
plt.show()
