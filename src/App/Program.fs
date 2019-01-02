open System


let rec readInput () =
    printfn "What would you like to do?"

    match stdin.ReadLine() with
        | "quit" -> 0
        | _ -> readInput()


[<EntryPoint>]
let main argv =
    let msg = """
______             _  _____         _             
| ___ \           | ||_   _|       | |            
| |_/ / ___   ___ | | _| |_ __ __ _| | _____ _ __ 
| ___ \/ _ \ / _ \| |/ / | '__/ _` | |/ / _ \ '__|
| |_/ / (_) | (_) |   <| | | | (_| |   <  __/ |   
\____/ \___/ \___/|_|\_\_/_|  \__,_|_|\_\___|_|   

Welcome to BookTraker a simple console based book tracking system!
    """
    printfn "%s" msg

    let input = readInput()
    input