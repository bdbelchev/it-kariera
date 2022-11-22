removeN' n arr i current =
    if null arr then current
    else if i `mod` n == 0 then removeN' n (tail arr) (i + 1) current
    else removeN' n (tail arr) (i + 1) (current ++ [head arr])

removeN arr n = removeN' n arr 1 []
