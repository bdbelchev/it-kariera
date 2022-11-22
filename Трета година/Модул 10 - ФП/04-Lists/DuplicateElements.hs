duplicate' arr result =
    if null arr then result
    else duplicate' (tail arr) (result ++ replicate 2 (head arr))

duplicate arr = duplicate' arr []
