fib n = 
    if n == 1 || n == 2 then 1
    else fib (n - 1) + fib (n - 2)

fibList n = [fib x | x <- [1..n]]
