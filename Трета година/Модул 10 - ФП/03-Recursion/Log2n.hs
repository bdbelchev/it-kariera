log2n n =
    if n == 1 then 0
    else 1 + log2n (n `div` 2) 

main = do
    input <- getLine
    let n = read input :: Int
    print $ log2n n
