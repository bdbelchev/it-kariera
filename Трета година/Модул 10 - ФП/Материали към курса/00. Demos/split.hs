nextSpaceIndex str separator i = 
    if null str
        then -1
    else if (take (length separator) str) == separator
        then i
    else nextSpaceIndex (tail str) separator (i + 1)

split str separator =
    if (null str) || ((nextSpaceIndex str separator 0) == -1)
        then [str]
    else (take (nextSpaceIndex str separator 0) str) : (split (drop ((nextSpaceIndex str separator 0) + (length separator)) str) separator)

mapArray array mapper =
    if null array
        then []
    else (mapper (head array)) : (mapArray (tail array) mapper)

main = do
    let str = "1 2 3 4 5"
    let splitArray = (split str " ")
    let mappedArray = mapArray splitArray (\x -> read x :: Integer)
    print mappedArray