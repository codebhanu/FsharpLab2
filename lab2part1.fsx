
type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}


let coaches_and_stats = [
    { Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = false }; Stats = { Wins = 59; Losses = 16 } }
    { Name = "Cleveland Cavaliers"; Coach = { Name = "J.B. Bickerstaff"; FormerPlayer = true }; Stats = { Wins = 46; Losses = 30 } }
    { Name = "Denver Nuggets"; Coach = { Name = "Michael Malone"; FormerPlayer = false }; Stats = { Wins = 53; Losses = 23 } }
    { Name = "San Antonio Spurs"; Coach = { Name = "Gregg Popovich"; FormerPlayer = true }; Stats = { Wins = 18; Losses = 58 } }
    { Name = "Utah Jazz"; Coach = { Name = "Will Hardy"; FormerPlayer = false }; Stats = { Wins = 29; Losses = 47 } }
]


let successful_teams = coaches_and_stats |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)


let success_percentage = successful_teams |> List.map (fun team ->
    let wins = float team.Stats.Wins
    let losses = float team.Stats.Losses
    let percentage = (wins / (wins + losses)) * 100.0
    (team.Name, percentage)
)


printfn "Successful Teams:"
successful_teams |> List.iter (fun team -> printfn "%s" team.Name)


printfn "\nSuccess Percentage of Successful Teams:"
success_percentage |> List.iter (fun (name, percentage) -> printfn "%s: %.2f%%" name percentage)
