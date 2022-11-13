-- IsDigit

isDigit str = elem str ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]

-- End IsDigit

-- Distinct

distinct :: (Foldable t, Eq a) => t a -> [a]
distinct arr = foldl (\a e -> a ++ if elem e a then [] else [e]) [] arr

-- End Distinct

-- Split

findNextIndex :: String -> String -> Int -> Int
findNextIndex str spliterator currentIndex = 
    if null str
        then -1
    else if (take (length spliterator) str) == spliterator
        then currentIndex
    else findNextIndex (tail str) spliterator (currentIndex + 1)

splitArray :: String -> String -> [String]
splitArray str spliterator = 
    if null str
        then []
    else if findNextIndex str spliterator 0 == -1
        then [str]
    else [take (findNextIndex str spliterator 0) str] ++ splitArray (drop ((findNextIndex str spliterator 0) + (length spliterator)) str) spliterator

split :: String -> String -> [String]
split str spliterator =
    splitArray str spliterator

-- End Split

-- Tuple

getElement :: [(String, [String])] -> String -> (String, [String]) 
getElement tuple key = 
    head (filter (\x -> fst x == key) tuple)

contains :: [(String, [String])] -> String -> Bool
contains tuple key = not $ null $ filter (\x -> fst x == key) tuple 

addElement :: [(String, [String])] -> String -> [String] -> [(String, [String])]
addElement tuple key element 
    | contains tuple key = [(key, distinct ((snd (getElement tuple key)) ++ element))] ++ filter (\x -> fst x /= key) tuple
    | otherwise = tuple

-- End Tuple

-- Sort

collectionInputLineInnerSorter :: String -> String -> Int
collectionInputLineInnerSorter firstMethod secondMethod
    | (length $ distinct firstMethod) < (length $ distinct secondMethod) = -1
    | (length $ distinct firstMethod) > (length $ distinct secondMethod) = 1
    | otherwise = 0

collectionInputLineSorter :: String -> String -> Int
collectionInputLineSorter firstMethod secondMethod
    | (length firstMethod) < (length secondMethod) = -1
    | (length firstMethod) > (length secondMethod) = 1
    | otherwise = collectionInputLineInnerSorter firstMethod secondMethod

digitInputLineSorter :: (String, [String]) -> (String, [String]) -> Int
digitInputLineSorter firstCollection secondCollection
    | (length $ snd firstCollection) < (length $ snd secondCollection) = -1 
    | (length $ snd firstCollection) > (length $ snd secondCollection) = 1
    | otherwise = 0

digitInputLineMethodSorter :: String -> String -> Int
digitInputLineMethodSorter firstMethod secondMethod
    | (length firstMethod) < (length secondMethod) = 1
    | (length firstMethod) > (length secondMethod) = -1
    | otherwise = collectionInputLineInnerSorter firstMethod secondMethod

finaleMethodSorter :: String -> String -> Int
finaleMethodSorter firstMethod secondMethod
    | (length firstMethod) < (length secondMethod) = -1
    | (length firstMethod) > (length secondMethod) = 1
    | otherwise = 0

finaleCollectionInnerSorter :: (String, [String]) -> (String, [String]) -> Int
finaleCollectionInnerSorter firstCollection secondCollection
    | (length $ last (sortArray (snd firstCollection) finaleMethodSorter)) < (length $ last (sortArray (snd secondCollection) finaleMethodSorter)) = -1
    | (length $ last (sortArray (snd firstCollection) finaleMethodSorter)) > (length $ last (sortArray (snd secondCollection) finaleMethodSorter)) = 1
    | otherwise = 0

finaleCollectionSorter :: (String, [String]) -> (String, [String]) -> Int
finaleCollectionSorter firstCollection secondCollection
    | (length $ snd firstCollection) < (length $ snd secondCollection) = -1
    | (length $ snd firstCollection) > (length $ snd secondCollection) = 1
    | otherwise = finaleCollectionInnerSorter firstCollection secondCollection

sortArrayInner :: [a] -> (a -> a -> Int) -> Int -> Int -> [a]
sortArrayInner arr comparer currentIndex currentInnerIndex
    | currentIndex >= length arr = arr
    | currentInnerIndex >= length arr = sortArrayInner arr comparer (currentIndex + 1) 0
    | otherwise = 
        if comparer (arr!!currentIndex) (arr!!currentInnerIndex) > 0
            then sortArrayInner (swap arr currentIndex currentInnerIndex) comparer currentIndex (currentInnerIndex + 1)
        else sortArrayInner arr comparer currentIndex (currentInnerIndex + 1)

sortArray :: [a] -> (a -> a -> Int) -> [a]
sortArray arr comparer = sortArrayInner arr comparer 0 0

swap arr index otherIndex 
    | index == otherIndex = arr
    | index > otherIndex = swap arr otherIndex index
    | otherwise = (take index arr) 
    ++ [head (drop otherIndex arr)] 
    ++ take (otherIndex - index - 1) (tail (drop index arr)) 
    ++ [head (drop index arr)] 
    ++ tail (drop otherIndex arr)

-- End Sort

-- Delete Chars

deleteChars :: String -> [Char] -> String
deleteChars str chars = 
    if null str
        then []
    else if elem (head str) chars
        then deleteChars (tail str) chars
    else [head str] ++ deleteChars (tail str) chars

processNormalInputLine :: [String] -> [(String, [String])] -> ([(String, [String])], [String])
processNormalInputLine currentParams collections = 
    if contains collections (head currentParams)
        then (addElement collections (head currentParams) (map (\x -> deleteChars x ['(', ')']) (tail currentParams)), [])
    else (collections ++ [(head currentParams, distinct $ map (\x -> deleteChars x ['(', ')']) (tail currentParams))], [])

processCollectionInputLine :: [String] -> [(String, [String])] -> ([(String, [String])], [String])
processCollectionInputLine currentParams collections = 
    if not $ contains collections (head currentParams)
        then (collections, [])
    else (collections, map ("* " ++) (sortArray (snd (getElement collections (head currentParams))) collectionInputLineSorter))

processDigitInputLine :: [String] -> [(String, [String])] -> ([(String, [String])], [String])
processDigitInputLine currentParams collections = 
    (collections, map ("* " ++) (take (read (head currentParams) :: Int) (sortArray (snd (head (sortArray collections digitInputLineSorter))) digitInputLineMethodSorter)))

processInputLine :: [String] -> [(String, [String])] -> ([(String, [String])], [String])
processInputLine currentParams collections
    | isDigit $ head currentParams = processDigitInputLine currentParams collections
    | null $ tail currentParams = processCollectionInputLine currentParams collections
    | otherwise = processNormalInputLine currentParams collections

printOutput :: [String] -> IO()
printOutput output = 
    if null output
        then return ()
    else do 
        putStrLn (head output)
        printOutput (tail output)

formatFinaleCollectionAll :: (String, [String]) -> [String]
formatFinaleCollectionAll collection = [fst collection] ++ map ("* " ++) (sortArray (snd collection) finaleMethodSorter)

processFinale :: [(String, [String])] -> [String] -> IO()
processFinale collections finalParams = do
    if last finalParams == "collection"
        then do
            printOutput $ map fst (sortArray (filter (\m -> elem (head finalParams) (snd m)) collections) digitInputLineSorter)
    else do
        printOutput $ foldl (\a x -> a ++ x) [] (map formatFinaleCollectionAll (sortArray (filter (\m -> elem (head finalParams) (snd m)) collections) finaleCollectionSorter))


doMagic :: [String] -> String -> [(String, [String])] -> IO()
doMagic lines finalLine collections = do
    if null lines
        then do
            let finalParams = split finalLine " "
            processFinale collections finalParams
    else do
        let currentParams = split (head lines) "."
        let processedCollectionsAndOutput = processInputLine currentParams collections
        let processedCollections = fst processedCollectionsAndOutput
        let processedOutput = snd processedCollectionsAndOutput

        if not $ null processedOutput 
            then do
                printOutput processedOutput
                doMagic (tail lines) finalLine processedCollections
            else do
                doMagic (tail lines) finalLine processedCollections

readUntil :: [String] -> IO()
readUntil arr = do
    line <- getLine
    if line == "exit"
        then do
            finalLine <- getLine
            doMagic arr finalLine []
    else do
        readUntil (arr ++ [line])

main :: IO()
main = do
    readUntil []