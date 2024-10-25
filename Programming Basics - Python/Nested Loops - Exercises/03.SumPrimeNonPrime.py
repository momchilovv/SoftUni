prime_sum = 0
non_prime_sum = 0

while True:
    entry = input()

    if entry == "stop":
        print(f"Sum of all prime numbers is: {prime_sum}")
        print(f"Sum of all non prime numbers is: {non_prime_sum}")
        exit()

    number = int(entry)

    if number < 0:
        print("Number is negative.")
        continue

    if number <= 1:
        non_prime_sum += number
        continue

    is_prime = True
    for i in range(2, number):
        if number % i == 0:
            is_prime = False
            break

    if is_prime:
        prime_sum += number
    else:
        non_prime_sum += number