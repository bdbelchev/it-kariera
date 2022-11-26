-- BUGS ARE STILL PRESENT

reverseArr' arr from count index current reversed =
    if length reversed >= count then current ++ reversed ++ arr
    else if index >= from then reverseArr' (tail arr) from count (index + 1) current ([head arr] ++ reversed)
    else reverseArr' (tail arr) from count (index + 1) (current ++ [head arr]) reversed
reverseArr arr from count = reverseArr' arr from count 0 [] []

divide n m = floor $ ((fromIntegral n) / (fromIntegral m))

mergeArray firstPartition secondPartition =
    if (null firstPartition) && (null secondPartition)
        then []
    else if (null firstPartition)
        then secondPartition
    else if (null secondPartition)
        then firstPartition
    else if ((head firstPartition) < (head secondPartition))
        then (head firstPartition) : (mergeArray (tail firstPartition) secondPartition)
    else (head secondPartition) : (mergeArray firstPartition (tail secondPartition))

mergeSort array =
    if (length array) < 2
        then array
    else mergeArray (mergeSort (take (divide (length array) 2) array)) (mergeSort (drop (divide (length array) 2) array))

sortArr' arr from count index current sorted =
    if length sorted >= count then current ++ mergeSort sorted ++ arr
    else if index >= from then sortArr' (tail arr) from count (index + 1) current (sorted ++ [head arr])
    else sortArr' (tail arr) from count (index + 1) (current ++ [head arr]) sorted
sortArr arr from count = sortArr' arr from count 0 [] []

rollLeft' arr times count =
    if count >= times then arr
    else rollLeft' (tail arr ++ [head arr]) times (count + 1)
rollLeft arr times = rollLeft' arr times 0

rollRight' arr times count =
    if count >= times then arr
    else rollRight' ([last arr] ++ init arr) times (count + 1)
rollRight arr times = rollRight' arr times 0

split' str del result current =
    if null str then result ++ [current]
    else if head str == del then split' (tail str) del (result ++ [current]) []
    else split' (tail str) del result (current ++ [head str])
split str del = split' str del [] []

readUntil cmd arr = do
    input <- getLine
    if input == cmd then print arr
    else do
        let func = split input ' '
        let task = head func
        if task == "reverse" then do
            let from = read (func !! 2) :: Int
            let to = read (func !! 4) :: Int
            if from < 0 || to < 0 then do
                putStrLn "Invalid input parameters."
                readUntil cmd arr
            else do
                if from >= length arr then readUntil cmd (reverseArr arr (length arr - 1) to)
                else if to > (length $ drop from arr) then readUntil cmd (reverseArr arr from (length $ drop from arr))
                else readUntil cmd (reverseArr arr from to)
        else if task == "sort" then do
            let from = read (func !! 2) :: Int
            let to = read (func !! 4) :: Int
            if from < 0 || to < 0 then do
                putStrLn "Invalid input parameters."
                readUntil cmd arr
            else if from >= length arr then readUntil cmd (sortArr arr (length arr - 1) to)
            else if to > (length $ drop from arr) then readUntil cmd (sortArr arr from (length $ drop from arr))
            else readUntil cmd (sortArr arr from to)
        else if task == "rollLeft" then do
            let count = read (func !! 1) :: Int
            if count < 0 then do
                putStrLn "Invalid input parameters."
                readUntil cmd arr
            else readUntil cmd (rollLeft arr count)
        else if task == "rollRight" then do
            let count = read (func !! 1) :: Int
            if count < 0 then do
                putStrLn "Invalid input parameters."
                readUntil cmd arr
            else readUntil cmd (rollRight arr count)
        else readUntil cmd arr
main = do
    input <- getLine
    let arr = split input ' '
    readUntil "end" arr
