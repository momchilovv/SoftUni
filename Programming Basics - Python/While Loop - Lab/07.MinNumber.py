number = input()

min_number = None

while number != "Stop":
    parsed = int(number)

    if min_number is None or parsed < min_number:
        min_number = parsed

    number = input()

print(min_number)