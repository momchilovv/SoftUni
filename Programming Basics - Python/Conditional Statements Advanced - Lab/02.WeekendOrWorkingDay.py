day = input()

output = 'Error'

if day == 'Monday' or day == 'Tuesday' or day == 'Wednesday' or day == 'Thursday' \
        or day == 'Friday':
    output = 'Working day'

if day == 'Saturday' or day == 'Sunday':
    output = 'Weekend'

print(output)