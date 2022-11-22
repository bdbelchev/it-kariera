reverseList' arr current =
    if null arr then current
    else reverseList' (tail arr) (head arr : current)

reverseList arr = reverseList' arr []
