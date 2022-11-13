doIt :: Integer -> [Integer]

doIt n = do
    if (divide n 4) >= 4
        then [(divide n 4), (divide n 4), (divide n 4), (divide n 4), (mod n 4)]
    else if (divide n 3) >= 3
        then [(divide n 3), (divide n 3), (divide n 3), (mod n 3), 0]
    else if (divide n 2) >= 2
        then [(divide n 2), (divide n 2), (mod n 2), 0, 0]
    else [n, 0, 0, 0, 0]

divide n m = floor $ ((fromIntegral n) / (fromIntegral m))

main = do
    print $ doIt 46
    -- 11 | 3 3 3 2 0
    -- 16 | 4 4 4 4 0
    -- 17 | 4 4 4 4 1
    -- 46 | 11 11 11 11 2