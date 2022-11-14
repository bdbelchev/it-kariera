isEven x = if mod x 2 == 0 then True else False

main = do
    input <- getLine
    let n = read input
    print $ isEven n
