width = int(input())
length = int(input())
height = int(input())

cubic_meters_available = width * length * height

boxes = input()

cubic_meters_used = 0

while boxes != "Done":
    cubic_meters_used += int(boxes)

    if cubic_meters_available < cubic_meters_used:
        print(f"No more free space! You need {cubic_meters_used - cubic_meters_available} Cubic meters more.")
        exit()

    boxes = input()

print(f"{cubic_meters_available - cubic_meters_used} Cubic meters left.")