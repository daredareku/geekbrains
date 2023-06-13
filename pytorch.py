import torch
import numpy as np

# Creating a random FloatTensor of size 3x4x5
x = torch.randn(3, 4, 5)

# Printing the shape of the tensor
print(x.shape)

# Reshaping the tensor to size 6x10
x = x.view(6, 10)

# Creating a random IntTensor of size 10
y = torch.randint(0, 10, (10,))

# Elementwise multiplication of FloatTensor and IntTensor
z = x * y

# Matrix multiplication of the tensor with itself
w = torch.matmul(x, x.t())

# Computing the derivative of the function y = x**3 + z - 75t at (1, 0.5, 2)
x = torch.tensor([1.0, 0.5, 2.0], requires_grad=True)
t = torch.tensor(75.0)
z = torch.sum(x ** 3) + t
z.backward()
print(x.grad)

# Creating an identity tensor of size 5x6
a = torch.eye(5, 6)

# Converting to numpy format
b = a.numpy()