distinct result array = 
    if null array
        then []
    else if (elem (head array) result)
        then distinct result (tail array)
    else (head array) : (distinct ((head array) : result) (tail array))

main = do
    -- print (elem 83 [1,2,3,3,3,6,6,6,7,7,73,83,73,3,4,4,4,4,5,5,5])
    print (distinct [] [1,2,3,3,3,6,6,6,7,7,73,83,73,3,4,4,4,4,5,5,5])