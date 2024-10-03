fruit = input()
day = input()
quantity = float(input())

price = 0

if day != 'Monday' and day != 'Tuesday' and day != 'Wednesday' and day != 'Thursday' and day != 'Friday' and day != 'Saturday' and day != 'Sunday':
    print('error')
    exit()

if fruit == 'banana':
    if day == 'Saturday' or day == 'Sunday':
        price = 2.70
    else:
        price = 2.50

elif fruit == 'apple':
    if day == 'Saturday' or day == 'Sunday':
        price = 1.25
    else:
        price = 1.20

elif fruit == 'orange':
    if day == 'Saturday' or day == 'Sunday':
        price = 0.90
    else:
        price = 0.85

elif fruit == 'grapefruit':
    if day == 'Saturday' or day == 'Sunday':
        price = 1.60
    else:
        price = 1.45

elif fruit == 'kiwi':
    if day == 'Saturday' or day == 'Sunday':
        price = 3.00
    else:
        price = 2.70

elif fruit == 'pineapple':
    if day == 'Saturday' or day == 'Sunday':
        price = 5.60
    else:
        price = 5.50

elif fruit == 'grapes':
    if day == 'Saturday' or day == 'Sunday':
        price = 4.20
    else:
        price = 3.85

else:
    print('error')
    exit()

print(f'{(price * quantity):.2f}')