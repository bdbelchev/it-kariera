-- printAsd :: Integer -> [Integer] -> [Integer] -> ()

printAsd n array arraySec = do
    let result = (array ++ arraySec)
    print result
    -- return (concat result)

main = do
    printAsd 5 [1, 2, 3] [4, 5, 6]