readUntil cmd arr = do
    input <- getLine
    if input == cmd then return arr
    else readUntil cmd (arr ++ [input])
