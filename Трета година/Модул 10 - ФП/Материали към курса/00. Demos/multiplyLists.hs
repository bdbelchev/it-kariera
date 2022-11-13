multiplyArray array n =
    if null array
        then []
    else ((head array) * n) : (multiplyArray (tail array) n)

main = do
    let array = [1, 2, 3, 4, 5]
    print (multiplyArray array 10)