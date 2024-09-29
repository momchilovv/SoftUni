deposit_amount = float(input())
deposit_period = int(input())
annual_interest = float(input())

interest_for_month = (deposit_amount * annual_interest / 100) / 12

total_amount = deposit_amount + (deposit_period * interest_for_month)

print(total_amount)