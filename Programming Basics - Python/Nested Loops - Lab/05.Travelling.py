money_saved = 0
destination = input()

while destination != "End":

    budget = float(input())

    while money_saved != str():
        money_saved = input()

        budget -= float(money_saved)

        if budget <= 0:
            print(f"Going to {destination}!")
            break

    destination = input()