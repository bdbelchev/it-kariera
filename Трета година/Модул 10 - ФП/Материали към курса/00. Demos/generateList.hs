generateList n m =
    if n == m
        then (n : [])
    else if n < m
        then n : (generateList (n + 1) m)
    else n : (generateList (n - 1) m)

getAt [] _ = error "Empty array"
getAt array n = head $ drop n array

main = do
    let arr = []
    getAt arr "5"