tribonacci n =
    if n == 0 || n == 1 then 0
    else if n == 2 then 1
    else tribonacci (n - 3) + tribonacci (n - 2) + tribonacci (n - 1)

main = do
    input <- getLine
    let n = read input :: Int
    print $ tribonacci n
