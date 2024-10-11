exam_hour = int(input())
exam_minute = int(input())
arrival_hour = int(input())
arrival_minute = int(input())

exam_time = exam_hour * 60 + exam_minute
arrival_time = arrival_hour * 60 + arrival_minute

time_difference = exam_time - arrival_time

if time_difference == 0:
    print('On time')
else:
    abs_difference = abs(time_difference)
    difference_hours = abs_difference // 60
    difference_minutes = abs_difference % 60

    if time_difference > 0:
        if abs_difference <= 30:
            print('On time')
            print(f'{difference_minutes} minutes before the start')
        else:
            print('Early')
            if difference_hours > 0:
                print(f'{difference_hours}:{difference_minutes:02d} hours before the start')
            else:
                print(f'{difference_minutes} minutes before the start')
    else:
        print('Late')
        if abs_difference < 60:
            print(f'{difference_minutes} minutes after the start')
        else:
            if difference_hours > 0:
                print(f'{difference_hours}:{difference_minutes:02d} hours after the start')
            else:
                print(f'{difference_minutes} minutes after the start')