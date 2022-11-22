replicateList arr n = foldl (\a b -> a ++ replicate n b) [] arr
