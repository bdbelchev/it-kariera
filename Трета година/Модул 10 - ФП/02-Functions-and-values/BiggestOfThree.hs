maxThree a b c = if a > b && a > c then a else if b > a && b > c then b else c

main = do
    input1 <- getLine
    input2 <- getLine
    input3 <- getLine
    let a = read input1 :: Int
    let b = read input2 :: Int
    let c = read input3 :: Int
    print $ maxThree a b c
