number_unsatisfying_marks = int(input())

task = input()

total_score = 0
number_of_tasks = 0
unsatisfying_marks = 0

last_problem = None

while task != "Enough":
    score = int(input())

    last_problem = task
    total_score += score
    number_of_tasks += 1

    if score <= 4:
        unsatisfying_marks += 1
        if number_unsatisfying_marks == unsatisfying_marks:
            print(f"You need a break, {unsatisfying_marks} poor grades.")
            exit()

    task = input()

print(f"Average score: {total_score / number_of_tasks:.2f}")
print(f"Number of problems: {number_of_tasks}")
print(f"Last problem: {last_problem}")