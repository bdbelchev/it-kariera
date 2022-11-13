area r = pi * r ^ 2

main = do
    radius <- getLine
    print $ area $ read radius
