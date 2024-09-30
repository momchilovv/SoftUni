from math import ceil

series_name = input()
length = int(input())
break_length = int(input())

actual_time = break_length - ((break_length / 8) + (break_length / 4))

if actual_time >= length:
    print(f'You have enough time to watch {series_name} and left with {ceil(actual_time - length):.0f} minutes free time.')

else:
    print(f'You don\'t have enough time to watch {series_name}, you need {ceil(length - actual_time):.0f} more minutes.')