
let timeComponents elapsedSecs =    
    let secsPerHour = 3600

    let hrs = elapsedSecs / secsPerHour
    let remainingSecs = elapsedSecs % secsPerHour

    let secsPerMinute = 60
    let mins = remainingSecs / secsPerMinute
    let secs = remainingSecs % secsPerMinute
    hrs, mins, secs

let elapsedSeconds = 12345
printfn "The number of elapsed seconds is %d" elapsedSeconds
let hours, minutes, seconds = timeComponents elapsedSeconds
printfn "\nThis is %d hours, %d minutes, and %d seconds" hours minutes seconds

