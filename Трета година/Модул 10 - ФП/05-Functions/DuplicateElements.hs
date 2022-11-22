duplicate arr = foldl (\a b -> a ++ replicate 2 b) [] arr
