factorial n = 
    if n <= 1 then 1
    else n * factorial (n - 1)

factList n = [factorial x | x <- [0..n-1]]
