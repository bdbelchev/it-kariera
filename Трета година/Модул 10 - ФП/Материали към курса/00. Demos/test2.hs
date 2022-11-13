main = do
    let arr = [1, 2, 3]
    print ((take 2 arr) ++ (drop 2 arr))