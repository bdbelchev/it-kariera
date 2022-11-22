printStars n = 
    if n == 0 then return ()
    else do
        putStrLn $ replicate n '*'
        printStars (n - 1)

main = do
    input <- getLine
    let n = read input :: Int
    printStars n
