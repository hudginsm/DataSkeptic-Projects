series <- c(1:9)

cat("Series:", series, "\n")

slice <- series[1:3]
cat("Slice:", slice, "\n")

totals <- series + slice
cat("Totals:", totals, "\n")

slice <- series[1:4]
cat("Slice:", slice, "\n")

totals <- series + slice
cat("New Total:", totals, "\n")