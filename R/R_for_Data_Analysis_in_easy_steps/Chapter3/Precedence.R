sum <- 1 + 4 * 3

print(paste("Defalt Order:", sum))

sum <- (1 + 4) * 3

print(paste("Forced Order:", sum))

sum <- 7 - 4 + 2

print(paste("Defalt Order:", sum))

sum <- 7 - (4 + 2)
print(paste("Forced Order:", sum))