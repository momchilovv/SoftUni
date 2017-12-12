package com.company;

public class CalculateExpression {
    public static void main(String[] args){
        double expr = (30 + 21) * 1.0/2 * (35 - 12 - 1.0/2);
        double result = Math.pow(expr, 2);
        System.out.println(result);
    }
}
