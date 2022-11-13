guessNum n g = do
    if g == n
        then putStrLn "You win!"
        else do
            if g > n
                then putStrLn "Too high!"
                else putStrLn "Too low!"
            newGuess <- getLine
            let newG = read newGuess :: Int
            guessNum n newG

main = do
    number <- getLine
    guess <- getLine
    let n = read number :: Int
    let g = read guess :: Int
    guessNum n g
