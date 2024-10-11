budget = float(input())
season = input()

type = ''
destination = ''

if budget <= 100:
    destination = 'Bulgaria'
    if season == 'summer':
        budget *= 0.30
        type = 'Camp'
    elif season == 'winter':
        budget *= 0.70
        type = 'Hotel'

elif 100 < budget <= 1000:
    destination = 'Balkans'
    if season == 'summer':
        budget *= 0.40
        type = 'Camp'
    elif season == 'winter':
        budget *= 0.80
        type = 'Hotel'

elif budget > 1000:
    destination = 'Europe'
    type = 'Hotel'
    budget *= 0.90

print(f'Somewhere in {destination}')
print(f'{type} - {budget:.2f}')