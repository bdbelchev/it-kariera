isPrime :: Integer -> Integer -> Bool

isPrime n j =
    if (fromIntegral j) > (sqrt (fromIntegral n))
        then True
    else if (mod n j) == 0
        then False
    else isPrime n (j + 1)

sumNPrimeNumbers :: Integer -> Integer -> Integer -> Integer

sumNPrimeNumbers sum n i =
    if n == 0
        then sum
    else if (isPrime i 2)
        then sumNPrimeNumbers (sum + i) (n - 1) (i + 1)
    else sumNPrimeNumbers sum n (i + 1)

sumFirstNPrimeNumbers :: Integer -> Integer

sumFirstNPrimeNumbers n = 
    sumNPrimeNumbers 0 n 2

main = do
    print (sumFirstNPrimeNumbers 10000)