-- WORKS WITH SINGLE CHARS ONLY :(

split' str del result current =
    if null str then result ++ [current]
    else if head str == del then split' (tail str) del (result ++ [current]) []
    else split' (tail str) del result (current ++ [head str])

split str del = split' str del [] []
