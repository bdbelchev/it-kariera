genExpr arr = foldr (\x y -> if null y then x else "(" ++ x ++ "+" ++ y ++ ")") "" (map show arr)
