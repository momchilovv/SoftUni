first_number = int(input())
second_number = int(input())

for num in range(first_number, second_number + 1):
    even_sum = 0
    odd_sum = 0

    str_num = str(num)

    for digit in range(0, len(str(num))):
        if digit % 2 == 0:
            even_sum += int(str_num[digit])
        else:
            odd_sum += int(str_num[digit])

    if even_sum == odd_sum:
        print(f"{num}", end=" ")