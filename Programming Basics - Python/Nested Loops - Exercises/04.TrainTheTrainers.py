n = int(input())
presentation = input()

presentations_count = 0
average = 0

while presentation != "Finish":
    average_grade = 0

    for num in range(0, n):
        average_grade += float(input())

    print(f"{presentation} - {average_grade / n:.2f}.")

    average += average_grade / n
    presentations_count += 1

    presentation = input()

print(f"Student's final assessment is {average / presentations_count:.2f}.")