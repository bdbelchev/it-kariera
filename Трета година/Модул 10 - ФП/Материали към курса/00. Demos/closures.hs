initWriter fileName = (\line -> appendFile fileName line)

main = do
    let write = initWriter "test.txt"
    write "Gosho"
    write "Pesho"