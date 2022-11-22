addZip arr1 arr2 =
    foldl (\a b -> a ++ [fst b + snd b]) [] (zip arr1 arr2)
