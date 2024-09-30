vacation_price = float(input())
puzzles_quantity = int(input())
dolls_quantity = int(input())
teddy_bears_quantity = int(input())
minions_quantity = int(input())
trucks_quantity = int(input())

total_price = ((puzzles_quantity * 2.60) + (dolls_quantity * 3) + (teddy_bears_quantity * 4.10) +
                (minions_quantity * 8.20) + (trucks_quantity * 2))

total_toys_sold = puzzles_quantity + dolls_quantity + teddy_bears_quantity + minions_quantity + trucks_quantity

if total_toys_sold >= 50:
    total_price -= total_price * 0.25

profit = total_price - (total_price * 0.10)

if vacation_price <= profit:
    print(f'Yes! {profit - vacation_price:.2f} lv left.')

else:
    print(f'Not enough money! {vacation_price - profit:.2f} lv needed.')