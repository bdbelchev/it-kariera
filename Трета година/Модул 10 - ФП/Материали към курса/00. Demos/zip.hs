zipArray array1 array2 array3 =
    if null array1
        then []
    else [((head array1), (head array2), (head array3))] ++ (zipArray (tail array1) (tail array2) (tail array3))

main = do
    print (zipArray [1, 2, 3] [4, 5, 6] [7, 8, 9])
    -- print (zip [(1,2), (2,3), (3,4)] [(4,5), (5,6), (6,7)])
    -- print (map (\((x1, y1), (x2, y2)) -> x1 + y1 + x2 + y2) (zip [(1,2), (2,3), (3,4)] [(4,5), (5,6), (6,7)]))