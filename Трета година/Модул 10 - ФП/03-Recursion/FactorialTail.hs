factorial' n v i =
    if i > n then v
    else factorial' n (v*i) (i+1)

factorial n =
    factorial' n 1 1

main = do
    input <- getLine
    let n = read input :: Int
    print $ factorial n
