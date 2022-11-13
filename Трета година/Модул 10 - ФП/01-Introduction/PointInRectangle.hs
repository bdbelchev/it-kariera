isInRect x1 y1 x2 y2 xP yP = do
    if xP >= x1 && xP <= x2 && yP >= y1 && yP <= y2
        then putStrLn "INSIDE"
    else putStrLn "OUTSIDE"

main = do
    bottomLeftX <- getLine
    bottomLeftY <- getLine
    topRightX <- getLine
    topRightY <- getLine
    pointX <- getLine
    pointY <- getLine

    let x1 = read bottomLeftX :: Int
    let y1 = read bottomLeftY :: Int
    let x2 = read topRightX :: Int
    let y2 = read topRightY :: Int
    let xP = read pointX :: Int
    let yP = read pointY :: Int

    isInRect x1 y1 x2 y2 xP yP
