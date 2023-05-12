# Replace 'Price, rubles' with the correct column name
df['Price'].hist(bins=20, grid=True)
plt.xlabel('Price, rubles.')
plt.ylabel('Number of listings')
plt.title('Distribution of prices')
plt.show()

# Replace 'Price, rubles' with the correct column name
df.plot.scatter(x='Area, sq. m.', y='Price', alpha=0.5)
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