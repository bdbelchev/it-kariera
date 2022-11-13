printTriangle n = do
    if n == 0
        then return ()
    else do
        print (take n (repeat "*"))
        printTriangle (n - 1)
    
main = do
    n <- getLine
    let num = read n :: Int
    printTriangle num
