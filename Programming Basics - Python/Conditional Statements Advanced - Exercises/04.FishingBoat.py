budget = float(input())
season = input()
fishermen = int(input())

rent = 0
discount = 0

if season == 'Spring':
    rent = 3000
elif season == 'Summer' or season == 'Autumn':
    rent = 4200
elif season == 'Winter':
    rent = 2600

if fishermen <= 6:
    discount = 0.10
elif 7 <= fishermen <= 11:
    discount = 0.15
elif fishermen >= 12:
    discount = 0.25

total = rent - (rent * discount)

if season != 'Autumn' and fishermen % 2 == 0:
    total *= 0.95

if budget >= total:
    print(f'Yes! You have {budget - total:.2f} leva left.')
else:
    print(f'Not enough money! You need {total - budget:.2f} leva.')