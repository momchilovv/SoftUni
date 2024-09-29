from math import floor

pages = int(input())
pages_per_hour = int(input())
deadline = int(input())

hours_per_day = (pages / pages_per_hour) / deadline

print(floor(hours_per_day))