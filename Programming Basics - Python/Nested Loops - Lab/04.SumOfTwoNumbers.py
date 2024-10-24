start = int(input())
end = int(input())
magic_number = int(input())

number_of_combination = 0

for first_number in range(start, end + 1):
    for second_number in range(start, end + 1):
        number_of_combination += 1

        if first_number + second_number == magic_number:
            print(f"Combination N:{number_of_combination} ({first_number} + {second_number} = {magic_number})")
            exit()

print(f"{number_of_combination} combinations - neither equals {magic_number}")