greening_area = float(input())
price = greening_area * 7.61
discount = price * 0.82

print(f'The final price is: {round(discount, 2)} lv.')
print(f'The discount is: {round(price - discount, 2)} lv.')