movie_budget = float(input())
extras_count = int(input())
extras_clothing_cost = float(input())

decoration_budget = movie_budget * 0.10

if extras_count >= 150:
    extras_clothing_cost -= extras_clothing_cost * 0.10

total_cost = extras_count * extras_clothing_cost + decoration_budget

if movie_budget < total_cost:
    print('Not enough money!')
    print(f'Wingard needs {total_cost - movie_budget:.2f} leva more.')

else:
    print('Action!')
    print(f'Wingard starts filming with {movie_budget - total_cost:.2f} leva left.')