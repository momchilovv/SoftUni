animal = input()

type = 'unknown'

if animal == 'dog':
    type = 'mammal'

elif animal == 'crocodile' or animal == 'tortoise' or animal == 'snake':
    type = 'reptile'

print(type)