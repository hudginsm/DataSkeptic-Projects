alphabet <- c("Alpha", "Bravo", "Charlie")

print(alphabet)

print(paste("Second Element:", alphabet[2]))

print(paste("Vector Length:", length(alphabet)))

alphabet[5] <- "Echo"
print(alphabet)
print(paste("Vector Length Now:", length(alphabet)))

print(paste("Is alphabet a Vector:", is.vector(alphabet)))