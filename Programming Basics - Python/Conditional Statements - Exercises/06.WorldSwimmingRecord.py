from math import floor

record = float(input())
distance = float(input())
time = float(input())

additional_time = floor((distance / 15)) * 12.5

total = time * distance + additional_time

if total < record:
    print(f'Yes, he succeeded! The new world record is {total:.2f} seconds.')

else:
    print(f'No, he failed! He was {total - record:.2f} seconds slower.')