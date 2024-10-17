name = input()

grade = 1
grades_sum = 0
times_failed= 0

while grade <= 12:
    mark = float(input())

    if mark < 4.00:
        times_failed += 1

        if times_failed == 2:
            print(f"{name} has been excluded at {grade} grade")
            exit()

    else:
        grade += 1
        grades_sum += mark

print(f"{name} graduated. Average grade: {(grades_sum / 12):.2f}")