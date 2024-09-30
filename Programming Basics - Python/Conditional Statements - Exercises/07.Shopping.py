budget = float(input())
gpus = int(input())
cpus = int(input())
rams = int(input())

gpus_cost = 250 * gpus
cpus_cost = (gpus_cost * 0.35) * cpus
rams_cost = (gpus_cost * 0.10) * rams

total_cost = gpus_cost + cpus_cost + rams_cost

if gpus > cpus:
    total_cost -= total_cost * 0.15

if budget >= total_cost:
    print(f'You have {budget - total_cost:.2f} leva left!')

else:
    print(f'Not enough money! You need {total_cost - budget:.2f} leva more!')