number = int(input())

biggest_number = 0
total_sum = 0

for num in range(0, number):
    n = int(input())

    if biggest_number < n:
        biggest_number = n

    total_sum += n

if biggest_number == total_sum - biggest_number:
    print("Yes")
    print(f"Sum = {biggest_number}")

else:
    print("No")
    print(f"Diff = {abs(biggest_number - (total_sum - biggest_number))}")