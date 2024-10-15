import math

tournaments = int(input())
initial_points = int(input())

points = 0

tournaments_won = 0

for i in range(0, tournaments):
    stage = input()

    if stage == "W":
        points += 2000
        tournaments_won += 1

    elif stage == "F":
        points += 1200

    elif stage == "SF":
        points += 720

print(f"Final points: {initial_points + points}")
print(f"Average points: {math.floor(points  / tournaments)}")
print(f"{(tournaments_won / tournaments) * 100:.2f}%")