n = int(input())

min_number = None
max_number = None

for num in range(0, n):
    number = int(input())

    if min_number is None or number < min_number:
        min_number = number

    if max_number is None or number > max_number:
        max_number = number

print(f"Max number: {max_number}")
print(f"Min number: {min_number}")