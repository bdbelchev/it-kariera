add1 x = x + 1
remove1 x = x - 1

execute f x = f x

main = do
    function <- getLine
    input <- getLine
    let x = read input :: Int

    if function == "add1" then print $ execute add1 x else print $ execute remove1 x
