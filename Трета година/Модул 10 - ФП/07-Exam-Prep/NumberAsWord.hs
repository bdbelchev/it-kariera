import System.Exit

readUntil cmd = do
    input <- getLine
    if input == cmd then exitWith ExitSuccess
    else do
        putStrLn $ numToWord (read input :: Int)
        readUntil cmd

numToWord n =
    if n == 0 then "Zero"
    else if n == 1 then "One"
    else if n == 2 then "Two"
    else if n == 3 then "Three"
    else if n == 4 then "Four"
    else if n == 5 then "Five"
    else if n == 6 then "Six"
    else if n == 7 then "Seven"
    else if n == 8 then "Eight"
    else if n == 9 then "Nine"
    else "Please only enter single digit positive numbers"

main = do
    readUntil "End"
