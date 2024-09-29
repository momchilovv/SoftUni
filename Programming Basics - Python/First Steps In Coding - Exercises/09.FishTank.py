length = int(input())
width = int(input())
height = int(input())
percent = float(input()) / 100

liters = (length * height * width) * 0.001

print(liters * (1 - percent))