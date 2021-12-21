high.temps <- read.csv("DataSet-HighTemps.csv")
low.temps <- read.csv("DataSet-LowTemps.csv")

display <- function(frame){
  cat("\nAnnual Temperatures (degrees C)...\n")
  print(frame)
}

display(high.temps)
display(low.temps)

avg.temp <- merge(high.temps, low.temps, by.x="State", by.y="State.Code")
display(avg.temp)

avg.temp$Capital <- NULL

avg.temp$Average <- (avg.temp$High + avg.temp$Low)/2
display(avg.temp)