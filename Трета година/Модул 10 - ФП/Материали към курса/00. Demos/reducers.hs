reduceArray func initial list =
    if null list
        then initial
    else reduceArray func (func initial (head list)) (tail list)

reduceRightArray func initial list =
    if null list
        then initial
    else func initial (reduceRightArray func (head list) (tail list))

reduce func list =
    reduceRightArray func (head list) (tail list)

maxNum x y =
    if x > y
        then x
    else y

main = do
    print (reduce (\x y -> maxNum x y) [1, 2, 3, 15, 5])
