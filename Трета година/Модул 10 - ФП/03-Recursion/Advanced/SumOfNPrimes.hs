sumPrimes' n sum index currentN =
    if currentN >= n then sum
    else if checkPrime index == True then sumPrimes' n (sum + index) (index + 1) (currentN + 1)
    else sumPrimes' n sum (index + 1) currentN

checkPrime n = if n > 1 then null [x | x <- [2..n - 1], n `mod` x == 0] else False

sumPrimes n = sumPrimes' n 0 0 0
