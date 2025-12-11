type Employee =
    | HourlyEmployee of id: string * name: string * pay_rate: float * hours_worked: float
    | SalesEmployee  of id: string * name: string * commission_rate: float * sales_amount: float

let extra_pay (pay: float) (hours: float) : float =  // hourly pay incl. overtime
    match hours with 
    | x  when x <= 40 -> hours * pay 
    | x -> (40.0  * pay) +  ((hours - 40.0) * pay)
let print_employee (emp: Employee) : unit =  // print payroll info
    match emp with 
    | HourlyEmployee(id,name,pay_rate,hours_worked) -> printfn " %A, %A, %A, %A" id name pay_rate hours_worked
    | SalesEmployee(id,name,comm,sales) -> printfn " %A, %A, %A, %A" id name comm sales

