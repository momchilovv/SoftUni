number = int(input())

for num in range(1111, 10000):
    num_to_string = str(num)

    is_special = False

    for char in num_to_string:
        if int(char) != 0 and number % int(char) == 0:
            is_special = True
        else:
            is_special = False
            break
    if is_special:
        print(f"{num}", end=" ")

print()