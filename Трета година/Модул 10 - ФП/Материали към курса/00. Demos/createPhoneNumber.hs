createPhoneNumber' array index = 
    if null array
        then ""
    else if index == 0
        then "(" ++ (head array) ++ (createPhoneNumber' (tail array) (index + 1))
    else if index == 2
        then (head array) ++ ") " ++ (createPhoneNumber' (tail array) (index + 1))
    else if index == 5
        then (head array) ++ "-" ++ (createPhoneNumber' (tail array) (index + 1))
    else (head array) ++ (createPhoneNumber' (tail array) (index + 1))

createPhoneNumber array =
    createPhoneNumber' (map (\x -> (show x)) array) 0


main = do
    print $ createPhoneNumber [1,2,3,4,5,6,7,8,9,0]