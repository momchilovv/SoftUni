age = int(input())
washing_machine_price = float(input())
toy_price = int(input())

total_money_saved = 0

for i in range(1, age + 1):
    if i % 2 == 1:
        total_money_saved += toy_price
    elif i % 2 == 0:
        total_money_saved += ((i / 2) * 10) - 1

if washing_machine_price <= total_money_saved:
    print(f"Yes! {total_money_saved - washing_machine_price:.2f}")
else:
    print(f"No! {washing_machine_price - total_money_saved:.2f}")