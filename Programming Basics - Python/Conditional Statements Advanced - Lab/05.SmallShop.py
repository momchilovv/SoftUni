product = input()
city = input()
quantity = float(input())

product_price = 0

if product == 'coffee':
    if city == 'Sofia':
        product_price = 0.50
    elif city == 'Plovdiv':
        product_price = 0.40
    elif city == 'Varna':
        product_price = 0.45

elif product == 'water':
    if city == 'Sofia':
        product_price = 0.80
    elif city == 'Plovdiv' or city == 'Varna':
        product_price = 0.70

elif product == 'beer':
    if city == 'Sofia':
        product_price = 1.20
    elif city == 'Plovdiv':
        product_price = 1.15
    elif city == 'Varna':
        product_price = 1.10

elif product == 'sweets':
    if city == 'Sofia':
        product_price = 1.45
    elif city == 'Plovdiv':
        product_price = 1.30
    elif city == 'Varna':
        product_price = 1.35

elif product == 'peanuts':
    if city == 'Sofia':
        product_price = 1.60
    elif city == 'Plovdiv':
        product_price = 1.50
    elif city == 'Varna':
        product_price = 1.55

print(product_price * quantity)