hour = int(input())
day = input()

state = ''

if 10 <= hour <= 18:
    if day == 'Monday':
        state = 'open'
    elif day == 'Tuesday':
        state = 'open'
    elif day == 'Wednesday':
        state = 'open'
    elif day == 'Thursday':
        state = 'open'
    elif day == 'Friday':
        state = 'open'
    elif day == 'Saturday':
        state = 'open'
    else:
        state = 'closed'
else:
    state = 'closed'

print(state)