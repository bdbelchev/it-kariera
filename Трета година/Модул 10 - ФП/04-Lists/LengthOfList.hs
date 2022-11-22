lengthOf' arr l =
    if null arr then l
    else lengthOf' (tail arr) (l + 1)

lengthOf arr = lengthOf' arr 0
