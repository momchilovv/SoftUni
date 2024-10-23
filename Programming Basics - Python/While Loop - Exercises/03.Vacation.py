money_needed = float(input())
balance = float(input())

days = 0
spend_threshold = 0

while True:
    action_type = input()
    money = float(input())
    days += 1

    if action_type == "spend":
        spend_threshold += 1
        if spend_threshold == 5:
            break

        if money >= balance:
            balance = 0
        else:
            balance -= money

    elif action_type == "save":
        spend_threshold = 0
        balance += money

        if money_needed <= balance:
            print(f"You saved the money for {days} days.")
            exit()

print(f"You can't save the money.\n{days}")