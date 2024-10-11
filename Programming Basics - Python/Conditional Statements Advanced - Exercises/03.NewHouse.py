flower_type = input()
quantity = int(input())
budget = float(input())

flower_price = 0
total = 0

if flower_type == 'Roses':
    flower_price = 5
    total = flower_price * quantity
    if quantity > 80:
        total *= 0.90

elif flower_type == 'Dahlias':
    flower_price = 3.80
    total = flower_price * quantity
    if quantity > 90:
        total *= 0.85

elif flower_type == 'Tulips':
    flower_price = 2.80
    total = flower_price * quantity
    if quantity > 80:
        total *= 0.85

elif flower_type == 'Narcissus':
    flower_price = 3
    total = flower_price * quantity
    if quantity < 120:
        total *= 1.15

elif flower_type == 'Gladiolus':
    flower_price = 2.50
    total = flower_price * quantity
    if quantity < 80:
        total *= 1.20

if budget >= total:
    print(f'Hey, you have a great garden with {quantity} {flower_type} and {budget - total:.2f} leva left.')
else:
    print(f'Not enough money, you need {total - budget:.2f} leva more.')