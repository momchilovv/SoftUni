package com.company;

import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        float firstNumber;
        float secondNumber;
        Scanner scan = new Scanner(System.in);
        firstNumber = Float.parseFloat(scan.nextLine());
        secondNumber = Float.parseFloat(scan.nextLine());
        float sum = firstNumber + secondNumber;
        System.out.println(sum);
    }
}
