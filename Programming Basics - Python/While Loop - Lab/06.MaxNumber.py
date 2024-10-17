number = input()

max_number = None

while number != "Stop":
    parsed = int(number)

    if max_number is None or parsed > max_number:
        max_number = parsed

    number = input()

print(max_number)