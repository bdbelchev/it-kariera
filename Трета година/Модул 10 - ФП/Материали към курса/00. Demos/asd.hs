reverseArray list = 
    if null list
        then []
    else (reverseArray (tail list)) ++ ([head list])

generateMath :: [Int] -> String

generateMath list =
    if null list
        then ""
    else if null (tail list)
        then (show (head list))
    else ("(" ++ (generateMath (tail list)) ++ "+" ++ (show (head list)) ++ ")")

main = do
    print (generateMath (reverseArray [1, 2, 3, 4]))