triangle n = 
    if n == 0 then return ()
    else do
        putStrLn $ replicate n '*'
        triangle (n - 1)
        putStrLn $ replicate n '#'

main = do
    input <- getLine
    let n = read input :: Int
    triangle n
