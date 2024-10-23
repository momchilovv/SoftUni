wanted_book = input()

found = False

checked_books = 0

while True:
    current_book = input()

    if wanted_book == current_book:
        print(f"You checked {checked_books} books and found it.")
        exit()

    if current_book == "No More Books":
        print("The book you search is not here!")
        print(f"You checked {checked_books} books.")
        exit()

    checked_books += 1