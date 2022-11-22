fibonacci' n iv pv i =
    if i >= n then iv
    else fibonacci' n (iv + pv) iv (i + 1)

fibonacci n = fibonacci' n 1 0 1

main = do
    input <- getLine
    let n = read input :: Int
    print $ fibonacci n
