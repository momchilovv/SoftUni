days = int(input())
room_type = input()
feedback = input()

room_prices = {
    'room for one person': 18,
    'apartment': 25,
    'president apartment': 35
}

nights = days - 1

total_price = 0

total_price += nights * room_prices[room_type]

if room_type == 'apartment':
    if nights < 10:
        total_price -= total_price * 0.30
    elif 10 <= nights <= 15:
        total_price -= total_price * 0.35
    elif nights > 15:
        total_price -= total_price * 0.50

elif room_type == 'president apartment':
    if nights < 10:
        total_price -= total_price * 0.10
    elif 10 <= nights <= 15:
        total_price -= total_price * 0.15
    elif nights > 15:
        total_price -= total_price * 0.20

if feedback == 'positive':
    total_price += total_price * 0.25
else:
    total_price -= total_price * 0.10

print(f'{total_price:.2f}')