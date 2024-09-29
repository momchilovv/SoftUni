from math import pi

figure = input()

result = 0

if(figure == 'square'):
    side = float(input())
    result = side * side

elif(figure == 'rectangle'):
    sideA = float(input())
    sideB = float(input())
    result = sideA * sideB

elif(figure == 'circle'):
    radius = float(input())
    result = pi * radius * radius

elif(figure == 'triangle'):
    side = float(input())
    height = float(input())
    result = (side * height) / 2

print(round(result, 3))