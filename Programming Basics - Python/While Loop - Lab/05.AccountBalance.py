total_money = 0

money = input()

while money != "NoMoreMoney":

    if float(money) < 0:
        print("Invalid operation!")
        break

    total_money += float(money)
    print(f"Increase: {float(money):.2f}")

    money = input()

print(f"Total: {total_money:.2f}")