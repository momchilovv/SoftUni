function getTicketPrice(day, age) {
    let price;

    if (age >= 0 && age <= 18) {
        if (day == "Weekday") {
            price = "12$";
        }
        else if (day == "Weekend") {
            price = "15$";
        }
        else {
            price = "5$";
        }
    }
    else if (age >= 19 && age <= 64) {
        if (day == "Weekday") {
            price = "18$";
        }
        else if (day == "Weekend") {
            price = "20$";
        }
        else {
            price = "12$";
        }
    }
    else if (age >= 65 && age <= 122) {
        if (day == "Weekday") {
            price = "12$";
        }
        else if (day == "Weekend") {
            price = "15$";
        }
        else {
            price = "10$";
        }
    }
    else {
        price = "Error!";
    }

    console.log(price);
}