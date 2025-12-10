(*
 * File: employee_payroll.fsx
 * Author: Franz Zbinden García 841-22-0855
 * Course: COTI 4039-VH1
 * Date: 12/9/2025
 * Purpose: This program calculates the salary of different employees and prints them
 *)

type Employee =
    | HourlyEmployee of id: string * name: string * pay_rate: float        * hours_worked: float
    | SalesEmployee  of id: string * name: string * commission_rate: float * sales_amount: float

// Auxiliar function that calculates extra pay for hourly employee
let extra_pay pay hours =
    match hours with
    | h when h > 40.0 -> hours * pay * 1.5 
    | _ -> hours * pay 

// Print employees & calculate salary
let print_employee = function
    | HourlyEmployee(id,name,pay_rate, hours_worked) -> 
        printf "Id: %A\n Name: %A\n PayRate: %A\n Hours Worked: %A\n Weekly Salary %A\n\n"
            id name pay_rate hours_worked (extra_pay pay_rate hours_worked)
    | SalesEmployee(id,name,comm_rate,sales_amount) -> 
        printf "Id: %A\n Name: %A\n PayRate: %A\n Sales Ammount: %A\n Weekly Salary %A\n\n" 
            id name comm_rate sales_amount (comm_rate * sales_amount )

// initialize employees
let employees : Employee list = 
    [HourlyEmployee("0001", "Juan", 30.0, 40.0);
    HourlyEmployee("0002", "Alberto", 45.0, 40.0);
    SalesEmployee("0003", "Franz", 0.10, 5000.0);
    SalesEmployee("0004", "Pedro", 0.08, 3000.0);
    SalesEmployee("0005", "Pepe", 0.05, 4000.0)]

for emp in employees do
    print_employee emp

