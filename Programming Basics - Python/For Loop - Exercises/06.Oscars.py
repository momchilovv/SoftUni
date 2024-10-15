actor_name = input()
points = float(input())
n = int(input())

for i in range(0, n):
    name = input()
    given_points = float(input())

    points += (len(name) * given_points) / 2

    if points >= 1250.5:
        print(f"Congratulations, {actor_name} got a nominee for leading role with {points:.1f}!")
        exit()

print(f"Sorry, {actor_name} you need {abs(points - 1250.5):.1f} more!")