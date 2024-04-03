
type Cuisine =
    | Korean
    | Turkish


type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float 


let calculateBudget (activity: Activity) : float =
    match activity with
    | BoardGame | Chill -> 0.0
    | Movie genre ->
        match genre with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (km, chargePerKm) -> float km * chargePerKm


let valentinesDayPlan = [
    Movie RegularWithSnacks
    Restaurant Korean
    LongDrive (50, 0.2)
]

let totalBudget = valentinesDayPlan |> List.map calculateBudget |> List.sum

printfn "Total Budget for Valentine's Day: $%.2f" totalBudget
