-- brokenZip arr1 arr2 = foldl (\a b -> if fst b < 0 || snd b < 0 then a ++ [0] else a ++ [fst b + snd b]) [] (zip arr1 arr2)

brokenZip arr1 arr2 = zipWith (\a b -> if a < 0 || b < 0 then 0 else a + b) arr1 arr2
