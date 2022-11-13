filterArray array comp =
    if null array
        then []
    else if comp (head array)
        then (head array) : (filterArray (tail array) comp)
    else filterArray (tail array) comp

main = do
    let array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    print (filterArray array (\elem -> (mod elem 2) == 0))