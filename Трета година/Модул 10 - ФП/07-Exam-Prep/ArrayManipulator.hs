split' str del result current =
    if null str then result ++ [current]
    else if head str == del then split' (tail str) del (result ++ [current]) []
    else split' (tail str) del result (current ++ [head str])
split str del = split' str del [] []

exchange' index arr currentIndex currentArr =
    if null arr then currentArr  
    else if currentIndex > index then arr ++ currentArr
    else exchange' index (tail arr) (currentIndex + 1) (currentArr ++ [head arr])
exchange index arr = exchange' index arr 0 []

onlyEven arr = [x | x <- arr, x `mod` 2 == 0] 
onlyOdd arr = [x | x <- arr, x `mod` 2 /= 0] 
hasEven arr = if null (onlyEven arr) then False else True
hasOdd arr = if null (onlyOdd arr) then False else True

maxEven' arr currentIndex bestElement bestIndex =
    if null arr then bestIndex
    else if head arr `mod` 2 == 0 && head arr >= bestElement 
        then maxEven' (tail arr) (currentIndex + 1) (head arr) currentIndex
    else maxEven' (tail arr) (currentIndex + 1) bestElement bestIndex
maxEven arr = maxEven' arr 0 0 0

maxOdd' arr currentIndex bestElement bestIndex =
    if null arr then bestIndex
    else if head arr `mod` 2 /= 0 && head arr >= bestElement 
        then maxOdd' (tail arr) (currentIndex + 1) (head arr) currentIndex
    else maxOdd' (tail arr) (currentIndex + 1) bestElement bestIndex
maxOdd arr = maxOdd' arr 0 0 0

minEven' arr currentIndex bestElement bestIndex =
    if null arr then bestIndex
    else if head arr `mod` 2 == 0 && head arr <= bestElement 
        then minEven' (tail arr) (currentIndex + 1) (head arr) currentIndex
    else minEven' (tail arr) (currentIndex + 1) bestElement bestIndex
minEven arr = minEven' arr 0 (maxBound :: Int) 0

minOdd' arr currentIndex bestElement bestIndex =
    if null arr then bestIndex
    else if head arr `mod` 2 /= 0 && head arr <= bestElement 
        then minOdd' (tail arr) (currentIndex + 1) (head arr) currentIndex
    else minOdd' (tail arr) (currentIndex + 1) bestElement bestIndex
minOdd arr = minOdd' arr 0 (maxBound :: Int) 0

firstOdd n arr = take n $ onlyOdd arr
firstEven n arr = take n $ onlyEven arr
lastOdd n arr = drop (length (onlyOdd arr) - n) (onlyOdd arr)
lastEven n arr = drop (length (onlyEven arr) - n) (onlyEven arr)

readUntil cmd arr = do
    input <- getLine
    if input == cmd then print arr
    else do
        let func = split input ' '
        let task = head func
        if task == "exchange" then do
            let index = read (head (tail func)) :: Int
            if index > length arr then do
                putStrLn "Invalid index"
                readUntil cmd arr
            else readUntil cmd (exchange index arr)
        else if task == "max" then do
            let option = head (tail func)
            if option == "even" then
                if hasEven arr then print $ maxEven arr else putStrLn "No matches"
            else do if hasOdd arr then print $ maxOdd arr else putStrLn "No matches"
            readUntil cmd arr
        else if task == "min" then do
            let option = head (tail func)
            if option == "even" then
                if hasEven arr then print $ minEven arr else putStrLn "No matches"
            else do if hasOdd arr then print $ minOdd arr else putStrLn "No matches"
            readUntil cmd arr
        else if task == "first" then do
            let n = read (head (tail func)) :: Int
            if n > length arr then putStrLn "Invalid count" else do
                let option = head (tail (tail func))
                if option == "even" then
                    print $ firstEven n arr
                else print $ firstOdd n arr
            readUntil cmd arr
        else if task == "last" then do
            let n = read (head (tail func)) :: Int
            if n > length arr then putStrLn "Invalid count" else do
                let option = head (tail (tail func))
                if option == "even" then
                    print $ lastEven n arr
                else print $ lastOdd n arr
            readUntil cmd arr
        else readUntil cmd arr

main = do
    input <- getLine
    let arr = map (\x -> read x :: Int) (split input ' ')
    readUntil "end" arr 
