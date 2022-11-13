repeatStr n k =
    if k == 0
        then ""
    else n ++ (repeatStr n (k - 1))

sumDigits n =
    if null n
        then 0
    else (read [(head n)] :: Integer) + (sumDigits (tail n)) 

getAt array n =
    if null array
        then error "Empty list"
    else if (n >= (length array)) || (n < 0)
        then error "Index outside the bounds of the array"
    else head $ drop n array

getFirstNumberIndex str i =
    if (getAt str i) == ' '
        then i - 1
    else getFirstNumberIndex str (i + 1)

compressNum n =
    if (length n) < 2
        then n
    else compressNum (show (sumDigits n))

main = do
    str <- getLine
    let strNum = show str
    let firstNumIndex = getFirstNumberIndex strNum 0
    let n = take firstNumIndex str
    let k = (read (drop (firstNumIndex + 1) str) :: Integer)
    let sumOfDigitsOfN = (read (compressNum n) :: Integer) * k
    print (read (compressNum (show sumOfDigitsOfN)) :: Integer)

    -- 593 10
    -- 593593593593593..
    -- 17 * 10 = 170
    -- 