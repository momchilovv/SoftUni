width = int(input())
length = int(input())

total_pieces = width * length

pieces = input()

while pieces != "STOP":
    total_pieces -= int(pieces)

    if total_pieces < 0:
        print(f"No more cake left! You need {abs(total_pieces)} pieces more.")
        exit()

    pieces = input()

print(f"{total_pieces} pieces are left.")