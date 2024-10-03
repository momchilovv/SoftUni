age = float(input())
gender = input()

title = ''

if age >= 16:
    if gender == 'f':
        title = 'Ms.'
    elif gender == 'm':
        title = 'Mr.'
else:
    if gender == 'f':
        title = 'Miss'
    elif gender == 'm':
        title = 'Master'

print(title)