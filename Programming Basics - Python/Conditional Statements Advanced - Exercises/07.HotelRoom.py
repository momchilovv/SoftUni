month = input()
duration = int(input())

studio_price = 0
apartment_price = 0

if month in ['May', 'October']:
    studio_price = 50
    apartment_price = 65

    if duration > 14:
        studio_price *= 0.70
        apartment_price *= 0.90

    elif duration > 7:
        studio_price *= 0.95

elif month in ['June', 'September']:
    studio_price = 75.20
    apartment_price = 68.70

    if duration > 14:
        studio_price *= 0.80
        apartment_price *= 0.90

elif month in ['July', 'August']:
    studio_price = 76
    apartment_price = 77

    if duration > 14:
        apartment_price *= 0.90

print(f'Apartment: {duration * apartment_price:.2f} lv.')
print(f'Studio: {duration * studio_price:.2f} lv.')