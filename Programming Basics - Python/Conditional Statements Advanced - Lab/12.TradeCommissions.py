city = input()
sale = float(input())

commission = 0

if sale < 0 or city != 'Sofia' and city != 'Varna' and city != 'Plovdiv':
    print('error')
    exit()

if 0 <= sale <= 500:
    if city == 'Sofia':
        commission = sale * 0.05
    elif city == 'Varna':
        commission = sale * 0.045
    elif city == 'Plovdiv':
        commission = sale * 0.055

elif 500 < sale <= 1000:
    if city == 'Sofia':
        commission = sale * 0.07
    elif city == 'Varna':
        commission = sale * 0.075
    elif city == 'Plovdiv':
        commission = sale * 0.08

elif 1000 < sale <= 10000:
    if city == 'Sofia':
        commission = sale * 0.08
    elif city == 'Varna':
        commission = sale * 0.10
    elif city == 'Plovdiv':
        commission = sale * 0.12

elif sale > 10000:
    if city == 'Sofia':
        commission = sale * 0.12
    elif city == 'Varna':
        commission = sale * 0.13
    elif city == 'Plovdiv':
        commission = sale * 0.145

print(f'{commission:.2f}')