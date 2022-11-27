import Data.Char

analyze input = do
    let lowercase = length [x | x <- input, isLower x]
    let uppercase = length [x | x <- input, isUpper x]
    let symbol = length [x | x <- input, not $ isLetter x]
    putStrLn $ show lowercase ++ " " ++ show uppercase ++ " " ++ show symbol

main = do
    input <- getLine
    analyze input
