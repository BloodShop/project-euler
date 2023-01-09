# 1
num = 0
for x in range(1, 1000):
    num += (x ** x)
num = str(num)
print(num[-10:])

# 2
print(str(sum([i**i for i in range(1,1001)]))[-10:])
