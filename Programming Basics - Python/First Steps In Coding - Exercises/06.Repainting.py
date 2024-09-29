nylon_needed = (int(input()) + 2) * 1.50
paint_needed = int(input())
thinner_needed = int(input()) * 5
hours_needed = int(input())

paint_needed += paint_needed * 0.10
paint_needed *= 14.50

total = nylon_needed + paint_needed + thinner_needed + 0.40

workers = hours_needed * (total * 0.30)

print(total + workers)