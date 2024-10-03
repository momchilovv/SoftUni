fruits = ['banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes']
vegetables = ['tomato', 'cucumber', 'pepper', 'carrot']

product = input()

if fruits.__contains__(product):
    print('fruit')
elif vegetables.__contains__(product):
    print('vegetable')
else:
    print('unknown')