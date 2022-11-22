cut' arr start end i res =
    if i > end || null arr then res
    else if i < start then cut' (tail arr) start end (i + 1) res
    else cut' (tail arr) start end (i + 1) (res ++ [head arr])

cut arr start end = cut' arr start end 0 []
