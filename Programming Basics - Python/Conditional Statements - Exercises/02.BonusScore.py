initial_points = int(input())

additional_points = 0

if initial_points <= 100:
    additional_points += 5

elif initial_points > 1000:
    additional_points += initial_points * 0.10

elif initial_points > 100:
    additional_points += initial_points * 0.20

if initial_points % 2 == 0:
    additional_points += 1

elif initial_points % 10 == 5:
    additional_points += 2

print(additional_points)
print(initial_points + additional_points)