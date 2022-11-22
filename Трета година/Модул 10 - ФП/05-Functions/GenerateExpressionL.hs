genExpr arr = foldl (\x y -> if null x then y else "(" ++ x ++ "+" ++ y ++ ")") "" (map show arr)
