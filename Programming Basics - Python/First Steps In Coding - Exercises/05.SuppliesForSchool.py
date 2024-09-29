pen_price = 5.80
marker_price = 7.20
cleaner_price = 1.20

pen_quantity = int(input())
marker_quantity = int(input())
cleaner_quantity = int(input())
discount = int(input()) / 100

total = ((pen_quantity * pen_price) + (marker_quantity * marker_price) + (cleaner_quantity * cleaner_price))

print(total - (total * discount))
