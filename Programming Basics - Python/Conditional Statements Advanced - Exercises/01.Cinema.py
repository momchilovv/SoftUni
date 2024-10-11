projection_type = input()
rows = int(input())
columns = int(input())

capacity = rows * columns

income = 0

if projection_type == 'Premiere':
    income = capacity * 12
elif projection_type == 'Normal':
    income = capacity * 7.50
elif projection_type == 'Discount':
    income = capacity * 5

print(f'{income:.2f}')
print('leva')