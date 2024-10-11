first_number = int(input())
second_number = int(input())
operation = input()

if second_number == 0 and operation in ['/', '%']:
    print(f'Cannot divide {first_number} by zero')
    exit()

result = eval(f'{first_number} {operation} {second_number}')

print(f'{first_number} {operation} {second_number} = ', end='')

if operation in ['+', '-', '*']:
    print(f"{result} - {'even' if result % 2 == 0 else 'odd'}")

elif operation == '/':
    print(f'{result:.2f}')

elif operation == '%':
    print(f'{result}')