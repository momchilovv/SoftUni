n = int(input())

musala_count = 0
monblan_count = 0
kilimandjaro_count = 0
k2_count = 0
everest_count = 0

total_people = 0

for i in range(0, n):
    group_number = int(input())
    total_people += group_number

    if group_number <= 5:
        musala_count += group_number

    elif 6 <= group_number <= 12:
        monblan_count += group_number

    elif 13 <= group_number <= 25:
        kilimandjaro_count += group_number

    elif 26 <= group_number <= 40:
        k2_count += group_number

    elif group_number >= 41:
        everest_count += group_number

print(f"{(musala_count / total_people) * 100:.2f}%")
print(f"{(monblan_count / total_people) * 100:.2f}%")
print(f"{(kilimandjaro_count / total_people) * 100:.2f}%")
print(f"{(k2_count / total_people) * 100:.2f}%")
print(f"{(everest_count / total_people) * 100:.2f}%")