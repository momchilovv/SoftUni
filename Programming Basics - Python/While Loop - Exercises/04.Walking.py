steps = input()

goal = 10_000

steps_for_today = 0

while steps != "Going home":
    steps_for_today += int(steps)

    if goal <= steps_for_today:
        print("Goal reached! Good job!")
        print(f"{steps_for_today - goal} steps over the goal!")
        exit()

    steps = input()

steps_for_today += int(input())

if goal <= steps_for_today:
    print("Goal reached! Good job!")
    print(f"{steps_for_today - goal} steps over the goal!")

else:
    print(f"{goal - steps_for_today} more steps to reach goal.")