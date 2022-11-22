reverseArray' arr current =  
    if null arr then current
    else reverseArray' (tail arr) ([head arr] ++ current)

reverseArray arr = reverseArray' arr []
