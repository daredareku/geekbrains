# --** coding: utf-8 **--
import pandas as pd
import matplotlib.pyplot as plt

#1.1. Load data from a CSV file located on a web server.
df = pd.read_csv('https://gbcdn.mrgcdn.ru/uploads/asset/4266730/attachment/08ec55854637add5247d22396d0f7456.csv')

# Replace 'Price, rubles' with the correct column name
df['price'].hist(bins=20, grid=True)
plt.xlabel('Price, rubles.')
plt.ylabel('Number of listings')
plt.title('Distribution of prices')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.plot.scatter(x='area, sq. m.', y='price', alpha=0.5)
plt.xlabel('Area, sq. m.')
plt.ylabel('Price, rubles')
plt.title('Relationship between area and price')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.plot.scatter(x='Number of rooms', y='Price', alpha=0.5)
plt.xlabel('Number of rooms')
plt.ylabel('Price, rubles')
plt.title('Relationship between the number of rooms and price')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.plot.scatter(x='District name', y='Price', alpha=0.5)
plt.xlabel('District name')
plt.ylabel('Price, rubles')
plt.title('Relationship between district and price')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.boxplot(column='Price', by='District name')
plt.xlabel('District name')
plt.ylabel('Price, rubles')
plt.title('Relationship between price and district name')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.boxplot(column='Price', by='House type')
plt.xlabel('House type')
plt.ylabel('Price, rubles')
plt.title('Relationship between price and house type')
plt.show()



#1.2. Plot a histogram of the distribution of prices.
# Set the x-axis label to 'Price, rubles.'
# Set the y-axis label to 'Number of listings.'
df['Price, rubles'].hist(bins=20, grid=True)
plt.xlabel('Price, rubles.')
plt.ylabel('Number of listings')
plt.title('Distribution of prices')
plt.show()

#1.3. Plot a histogram of the distribution of areas.
#Set the x-axis label to 'Area, sq. m.'
#Set the y-axis label to 'Number of listings.'
df['Area, sq. m.'].hist(bins=20, grid=True)
plt.xlabel('Area, sq. m.')
plt.ylabel('Number of listings')
plt.title('Distribution of areas')
plt.show()

#2.1.4. Plot a histogram of the distribution of the number of rooms.
#Set the x-axis label to 'Number of rooms.'
#Set the y-axis label to 'Number of listings.'
df['Number of rooms'].hist(bins=20, grid=True)
plt.xlabel('Number of rooms')
plt.ylabel('Number of listings')
plt.title('Distribution of the number of rooms')
plt.show()

#2.1. Plot a bar chart of the distribution of the district names.
#Set the x-axis label to 'District name.'
#Set the y-axis label to 'Number of listings.'
df['District name'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('District name')
plt.ylabel('Number of listings')
plt.title('Distribution of district names')
plt.show()

#2.2. Plot a bar chart of the distribution of the house types.
#Set the x-axis label to 'House type.'
#Set the y-axis label to 'Number of listings.'
df['House type'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('House type')
plt.ylabel('Number of listings')
plt.title('Distribution of house types')
plt.show()

#2.3. Plot a bar chart of the distribution of the renovation types.
#Set the x-axis label to 'Renovation type.'
#Set the y-axis label to 'Number of listings.'
df['Renovation type'].value_counts().plot(kind='bar', rot=0)
plt.xlabel('Renovation type')
plt.ylabel('Number of listings')
plt.title('Distribution of renovation types')
plt.show()

#3. Analyze the relationships between variables by plotting scatter plots and box plots.
#3.1. Plot a scatter plot of the relationship between the area and price of the listings.
df.plot.scatter(x='Area, sq. m.', y='Price, rubles', alpha=0.5)
plt.xlabel('Area, sq. m.')
plt.ylabel('Price, rubles')
plt.title('Relationship between area and price')
plt.show()

#3.2. Plot a scatter plot of the relationship between the number of rooms and price of the listings.
df.plot.scatter(x='Number of rooms', y='Price, rubles', alpha=0.5)
plt.xlabel('Number of rooms')
plt.ylabel('Price, rubles')
plt.title('Relationship between the number of rooms and price')
plt.show()

#3.3. Plot a scatter plot of the relationship between the district and price of the listings.
df.plot.scatter(x='District name', y='Price, rubles', alpha=0.5)
plt.xlabel('District name')
plt.ylabel('Price, rubles')
plt.title('Relationship between district and price')
plt.show()

#3.4. Plot a box plot of the relationship between the price and the district name.
df.boxplot(column='Price, rubles', by='District name')
plt.xlabel('District name')
plt.ylabel('Price, rubles')
plt.title('Relationship between price and district name')
plt.show()

#3.5. Plot a box plot of the relationship between the price and the house type.
df.boxplot(column='Price, rubles', by='House type')
plt.xlabel('House type')
plt.ylabel('Price, rubles')
plt.title('Relationship between price and house type')
plt.show()
