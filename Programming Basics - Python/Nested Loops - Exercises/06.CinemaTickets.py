student_tickets = 0
standard_tickets = 0
kid_tickets = 0
total_tickets_sold = 0

movie = input()

while movie != "Finish":
    capacity = int(input())
    taken_seats = 0

    while taken_seats < capacity:
        visitor_type = input()

        if visitor_type == "End":
            break

        if visitor_type == "student":
            student_tickets += 1
        elif visitor_type == "standard":
            standard_tickets += 1
        elif visitor_type == "kid":
            kid_tickets += 1

        taken_seats += 1
        total_tickets_sold += 1

    print(f"{movie} - {(taken_seats / capacity) * 100:.2f}% full.")
    movie = input()

print(f"Total tickets: {total_tickets_sold}")
print(f"{(student_tickets / total_tickets_sold) * 100:.2f}% student tickets.")
print(f"{(standard_tickets / total_tickets_sold) * 100:.2f}% standard tickets.")
print(f"{(kid_tickets / total_tickets_sold) * 100:.2f}% kids tickets.")