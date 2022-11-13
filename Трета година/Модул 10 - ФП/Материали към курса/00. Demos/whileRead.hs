whileRead command = do
    input <- getLine
    
    if input == command
        then []
    else do
        (read [input] :: [Int]) ++ whileRead command

main = do
    print $ whileRead "end"