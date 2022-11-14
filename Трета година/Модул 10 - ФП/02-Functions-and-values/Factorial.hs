factorial x =
    if x == 1 || x == 0
        then 1
        else x * factorial (x - 1)

main = do
    input <- getLine
    let x = read input :: Int
    print $ factorial x
